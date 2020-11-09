﻿using MedicHelpper.Properties;
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
        ClassEnfermero enfermer = new ClassEnfermero();
        public frmEnfer()
        {
            InitializeComponent();
            tipAgregar.SetToolTip(txtnum, "Ingrese el numero de tarjeta del paciente con el sigiente formato: P00001");
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
            errorCodigoCita.SetError(txtCita, "");
            errorCodigoTarjeta.SetError(txtTarjeta, "");
            errorNombreAgg.SetError(txtnom, "");
            errorApellidoAgg.SetError(txtape, "");
            errorNTarjetaFind.SetError(NTarjeta, "");
            errorFechaNacimiento.SetError(dtFechadeNacimiento, "");
            errorNtarjetaPaciente.SetError(txtnum, "");
        }
        //Procesos para cuando se precionen teclas no debidas en los textbox los error provider se activen
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(txtCita, "");
            CampoCodCita= validar.ValidarCamposNumericos(txtCita, e, errorCodigoCita);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoTarjeta.SetError(txtTarjeta, "");
            CampoTarjCita= validar.ValidarCamposVacios(txtTarjeta, errorCodigoTarjeta);
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

        private void dtpCita_ValueChanged(object sender, EventArgs e)
        {
            errorFecha.SetError(dtpCita, "");
            FechaCita = validar.ValidarFechaCita(dtpCita, errorFecha);
            txtTarjeta.Clear();
            label8.Visible = false;
            txtCita.Visible = false;

        }

        private void dtFechadeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            errorFechaNacimiento.SetError(dtFechadeNacimiento, "");
            FechaNacimiento = validar.ValidarFechaNacimiento(dtFechadeNacimiento, errorFechaNacimiento);
        }

        //Validaciones y procesos necesarios en los botones agregar citas y pacientes
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = enfermer.MostrarPaciente();
        }
        private void btnAddCita_Click(object sender, EventArgs e)
        {
            BorrarValidar();            
            if (validar.ValidarCamposVacios(txtTarjeta,errorCodigoTarjeta)
                   && FechaCita)
            {
                enfermer.AgregarCita(dtpCita, txtTarjeta.Text,label8,txtCita);
                
                errorFecha.SetError(dtpCita, "");
            }
            else
            {
                if (!FechaCita)
                {
                    errorFecha.SetError(dtpCita, "Campo con datos no validos, ingrese fechas proximas");
                }
                else if (!CampoTarjCita)
                {
                    errorCodigoTarjeta.SetError(txtTarjeta, "Campo con datos no validos,\n Vuelva a intentar ingresar");
                }
                else 
                {
                    errorCodigoTarjeta.SetError(txtTarjeta, "Campos con datos vacios");
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
                string nombre = txtnom.Text;
                string apellido = txtape.Text;
                string tarjeta = txtnum.Text;
                string anio = dtFechadeNacimiento.Value.Year.ToString();
                string mes = dtFechadeNacimiento.Value.Month.ToString();
                string dia = dtFechadeNacimiento.Value.Day.ToString();
                string fecha = dia + "-" + mes + "-" + anio;
                enfermer.AgregarPaciente(tarjeta, nombre, apellido, fecha);
                txtape.Clear();
                txtnom.Clear();
                txtnum.Clear();
                dtFechadeNacimiento.Value = System.DateTime.Today;
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
                else if (!FechaNacimiento)
                {

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
        
    }
}
