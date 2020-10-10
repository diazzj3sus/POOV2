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
        public frmEnfer()
        {
            InitializeComponent();
        }
        //Declaracion de variables globales necesarias
        bool CampoCodCita, CampoTarjCita, FechaCita, NombreAdd,ApellidoAdd;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuAdministrador frm = new MenuAdministrador("");
            frm.Visible = true;
            
        }
        //Metodo para validar que ningun campo quede vacío
        private bool ValidarCamposVacios(TextBox txt, ErrorProvider error)
        {
            bool ok = true;
            if (txt.Text == "")
            {
                ok = false;
                error.SetError(txt, "Ingrese datos en el campo.");
            }
            return ok;
        }
        //Metodo para validar  que en los campos solo se ingresen  numeros donde sea necesario
        private bool ValidarCamposNumericos(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            if (char.IsDigit(e.KeyChar))
            {
                ok = true;
                e.Handled = false;
            }
            //tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                ok = true;
                e.Handled = false;
            }
            //Verifica que pueda ingresar punto y solo punto
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                ok = true;
                e.Handled = false;
            }
            //si no cumple nada el errorprovider se activa y la funcion devuelve un false ademas de no dejar escribir y borrar el texto 
            //Para evitar que escriba mal de nuevo
            else
            {
                ok = false;
                e.Handled = true;
                error.SetError(txt, "Ingrese datos numericos en el campo");
                txt.Text = "";
            }
            return ok;
        }
        //Metodo de validacion done la fecha seleccionada sea MAYOR  a la actual
        private bool ValidarFechaCita(DateTimePicker dtp)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada < fechaActual)
            {
                errorFecha.SetError(dateTimePicker1, "Error la fecha seleccionada es menor a la fecha actual");
                ok = false;
            }
            return ok;
        }
        //Metodo para evaluar que solo se ingresen letras en los campos donde sea necesario
        private bool ValidarCampoLetras(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            //condicion solo para letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //Verifica que admite tecla espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //si no cumple nada lo deja pasar
            else
            {
                e.Handled = true;
                ok = false;
                error.SetError(txt, "Ingrese unicamente letras");
                txt.Text = "";
            }
            return ok;
        }
        //resetar los error provider
        private void BorrarValidar()
        {
            errorCodigoCita.SetError(textBox4, "");
            errorCodigoTarjeta.SetError(textBox1, "");
            errorNombreAgg.SetError(txtnom, "");
            errorApellidoAgg.SetError(txtape, "");
            errorNTarjetaAdd.SetError(txtnum, "");
            errorNTarjetaFind.SetError(NTarjeta, "");
        } 

        //Validar textbox que solo permitan numeros y puntos
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(textBox4, "");
            CampoCodCita= ValidarCamposNumericos(textBox4, e, errorCodigoCita);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoTarjeta.SetError(textBox1, "");
            CampoTarjCita= ValidarCamposNumericos(textBox1, e, errorCodigoTarjeta);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorNombreAgg.SetError(txtnom, "");
            NombreAdd = ValidarCampoLetras(txtnom,e,errorNombreAgg);
        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorApellidoAgg.SetError(txtape, "");
            ApellidoAdd = ValidarCampoLetras(txtape, e, errorApellidoAgg);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            errorFecha.SetError(dateTimePicker1, "");
            FechaCita= ValidarFechaCita(dateTimePicker1);
        }

        private void btnAddCita_Click(object sender, EventArgs e)
        {
            BorrarValidar();
            if (ValidarCamposVacios(textBox1,errorCodigoTarjeta)&&ValidarCamposVacios(textBox1,errorCodigoCita)
                &&CampoCodCita&&CampoTarjCita&&FechaCita)
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
                    errorCodigoCita.SetError(textBox4, "Ultimos intentos de ingreso fueron caracteres letras\n Vuelva a intar ingresar");
                }
                else if (!CampoTarjCita)
                {
                    errorCodigoTarjeta.SetError(textBox1, "Ultimos intentos de ingreso fueron caracteres letras\n Vuelva a intar ingresar");
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
            if (ValidarCamposVacios(txtnom,errorNombreAgg)&&ValidarCamposVacios(txtape,errorApellidoAgg)&&NombreAdd&&ApellidoAdd)
            {
                MessageBox.Show("Felicidades textos ingresados validos");
            }
            else
            {
                if (!NombreAdd)
                {
                    errorNombreAgg.SetError(txtnom, "Ultimos intentos de ingreso fueron caracteres numericos\n Vuelva a intar ingresar");
                }
                else if(!ApellidoAdd)
                {
                    errorApellidoAgg.SetError(txtape, "Ultimos intentos de ingreso fueron caracteres numericos\n Vuelva a intar ingresar");
                }
                else
                {
                    errorNombreAgg.SetError(txtnom, "Campos con datos vacíos");
                    errorApellidoAgg.SetError(txtape, "Campos con datos vacíos");
                }
            }
        }
    }
}
