using MedicHelpper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class frmEnfer : MedicHelpper.frmPadre
    {
        //Declaracion de variables globales necesarias
        Validaciones validar = new Validaciones();
        bool CampoCodCita, CampoTarjCita, FechaCita=true, NombreAdd, ApellidoAdd,FechaNacimiento = true,AddTarjeta;
        public frmEnfer()
        {
            InitializeComponent();
            tipVerificar.SetToolTip(btnEstado, "Solo ingresar el codigo de la consulta");//tool tip para darle la indicacion al usuario
        }
        //Procedimiento para minimizar la pantalla
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Procedimiento para restaurar la pantalla
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Maximized;
                btnRestaurar.Image = Resources.restaurar;
            }
        }
        //--------NAVEGACION ENTRE PANTALLAS----
        private void pctAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador frmMenu = new MenuAdministrador("");
            frmMenu.Visible = true;
        }
        //Procedimiento para cerrar la pantalla
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        //Para resetear los Error Provider
        public void BorrarValidar()
        {
            errorCodigoCita.SetError(textBox4, "");
            errorCodigoTarjeta.SetError(textBox1, "");
            errorNombreAgg.SetError(txtnom, "");
            errorApellidoAgg.SetError(txtape, "");
            errorNTarjetaFind.SetError(NTarjeta, "");
            errorFechaNacimiento.SetError(dtFechadeNacimiento, "");
            errorNtarjetaPaciente.SetError(txtnum, "");
        }
        //Procesos para cuando se precionen teclas no debidas en los textbox los error provider se activen
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(textBox4, "");
            CampoCodCita= validar.ValidarCamposNumericos(textBox4, e, errorCodigoCita);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoTarjeta.SetError(textBox1, "");
            CampoTarjCita= validar.ValidarCamposVacios(textBox1, errorCodigoTarjeta);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorNombreAgg.SetError(txtnom, "");
            NombreAdd = validar.ValidarCampoLetras(txtnom, e, errorNombreAgg);
        }
        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorApellidoAgg.SetError(txtape, "");
            ApellidoAdd = validar.ValidarCampoLetras(txtape, e, errorApellidoAgg);
        }
        //private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    errorNtarjetaPaciente.SetError(txtape, "");
        //    AddTarjeta = validar.ValidarCamposVacios(txtnum, errorNtarjetaPaciente);
        //}

        private void dtFechadeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            errorFechaNacimiento.SetError(dtFechadeNacimiento, "");
            FechaNacimiento = validar.ValidarFechaNacimiento(dtFechadeNacimiento, errorFechaNacimiento);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            errorFecha.SetError(dateTimePicker1, "");
            FechaCita= validar.ValidarFechaCita(dateTimePicker1,errorFecha);
        }




        //Validaciones y procesos necesarios en los botones agregar citas y pacientes
        private void btnAddCita_Click(object sender, EventArgs e)
        {
            BorrarValidar();
            if (validar.ValidarCamposVacios(textBox1,errorCodigoTarjeta)&& validar.ValidarCamposVacios(textBox4,errorCodigoCita)
                  && CampoCodCita && CampoTarjCita && FechaCita)
            {
                //Falta codigo para  la fase 3 funcionamiento debido
                MessageBox.Show("Campos completados correctamente");
            }
            else
            {
                if (!FechaCita)
                {
                    errorFecha.SetError(dateTimePicker1, "Campo con datos no validos, ingrese fechas proximas");
                }
                else if (!CampoCodCita)
                {
                    errorCodigoCita.SetError(textBox4, "Campo con datos no validos,s\n Vuelva a intentar ingresar");
                }
                else if (!CampoTarjCita)
                {
                    errorCodigoTarjeta.SetError(textBox1, "Campo con datos no validos,\n Vuelva a intentar ingresar");
                }
                else 
                {
                    errorCodigoCita.SetError(textBox4, "Campos con datos  vacios");
                    errorCodigoTarjeta.SetError(textBox1, "Campos con datos vacios");
                }
            }
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            BorrarValidar();
            if (validar.ValidarCamposVacios(txtnom, errorNombreAgg) && validar.ValidarCamposVacios(txtape, errorApellidoAgg)
                && validar.ValidarFechaNacimiento(dtFechadeNacimiento, errorFechaNacimiento)
                && validar.ValidarCamposVacios(txtnum, errorNtarjetaPaciente) && NombreAdd && ApellidoAdd
                && FechaNacimiento)
            {
                MessageBox.Show("Felicidades textos ingresados validos");
            }
            else
            {
                if (!NombreAdd)
                {
                    errorNombreAgg.SetError(txtnom, "Datos no ingresados correctamente\n Vuelva a intentar ingresar");
                }
                else if (!ApellidoAdd)
                {
                    errorApellidoAgg.SetError(txtape, "Datos no ingresados correctamente\n Vuelva a intentar ingresar");
                }
                else if (!FechaNacimiento) { 

                    errorFechaNacimiento.SetError(dtFechadeNacimiento, "Fecha de nacimiento no valida\n Vuelva a intentar ingresar");
                }
                else if (!AddTarjeta)
                {
                    errorNtarjetaPaciente.SetError(txtnum, "El campo no puede estar vacío");
                }
                else
                {
                    errorNombreAgg.SetError(txtnom, "Campos con datos vacíos");
                    errorApellidoAgg.SetError(txtape, "Campos con datos vacíos");
                }
            }
        }
        private void btnEstado_Click(object sender, EventArgs e)
        {


        }
    }
}
