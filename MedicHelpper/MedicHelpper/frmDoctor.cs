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
    public partial class frmDoctor : MedicHelpper.frmPadre
    {
        Validaciones validar = new Validaciones();
        bool CampoCodCita, CampoTarjCita, NombreAdd, ApellidoAdd,CodUsuario, CodUsuarioDoc, FechaCita= true, Descripcion;

        public frmDoctor()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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

        private void pctAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuAdministrador frm = new MenuAdministrador("");
            frm.Visible = true;
        }
        // validacion para que los campos no queden vacios

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
            else if ((e.KeyChar == '.') && (!txt.Text.Contains(".")))
            {
                ok = true;
                e.Handled = false;
            }
            else
            {
                ok = false;
                e.Handled = true;
                error.SetError(txt, "Ingrese datos numericos en el campo");
                txt.Text = "";
            }
            return ok;
        }
        private bool ValidarCampoLetras(TextBox txt, KeyPressEventArgs e, ErrorProvider error)
        {
            bool ok = true;
            //condicion solo para letras
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                ok = true;
            }
            //tecla backspac
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
                error.SetError(txt, "Ingrese unicamente Numeros");
                txt.Text = "";
            }
            return ok;
        }

        private bool ValidarFechaCita(DateTimePicker dt)
        {
            DateTime fechaSeleccionada = dt.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada < fechaActual)
            {
                errorFecha.SetError(dateTimePicker1, "Error la fecha seleccionada es menor a la fecha actual");
                ok = false;
            }
            return ok;
        }

        private void BorrarValidar()
        {
            //errorCodigoCita.SetError(textBox4, "");
            errorCodigoTarjeta.SetError(textBox1, "");
            errorCodigoCita.SetError(txt_CODCITa, "");
            ErrorPaciente.SetError(txt_codPaci, "");
            errorFech.SetError(txt_fecha, "");
            errorCita.SetError(txt_cita, "");
            errorCodigoCons.SetError(txt_ConsultaDoc, "");
            errorCodUSuario.SetError(txt_codusuario, "");
            errorCodigoCita.SetError(txt_codigocita, "");
            errorFech.SetError(txt_fecha_doc, "");
            errorDescripcion.SetError(txt_DescripcionDoc, "");


        }
    
        private void txt_CODCITa_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(txt_CODCITa, "");
            NombreAdd = ValidarCampoLetras(txt_CODCITa, e, errorCodigoCita);
        }
        private void txt_codusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            errorCodUSuario.SetError(txt_codusuario, "");
            CodUsuarioDoc = ValidarCamposNumericos(txt_codusuario, e, errorCodUSuario);
        }
        private void txt_codigocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoCita.SetError(txt_codigocita, "");
            NombreAdd = ValidarCampoLetras(txt_codigocita, e, errorCodigoCita);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {    
            errorCodigoCita.SetError(textBox4, "");
            CampoCodCita = ValidarCamposNumericos(textBox4, e, errorCodigoCita);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoTarjeta.SetError(textBox1, "");
            CampoTarjCita = validar.ValidarCamposVacios(textBox1, errorCodigoTarjeta);
        }

        private void txt_fecha_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorFech.SetError(txt_fecha_doc, "");
            FechaCita = ValidarCamposVacios(txt_fecha_doc, errorFech);
        }

        private void txt_DescripcionDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorDescripcion.SetError(txt_DescripcionDoc, "");
            Descripcion = ValidarCamposVacios(txt_DescripcionDoc, errorDescripcion);
        }

        private void txt_codPaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorPaciente.SetError(txt_codPaci, "");
            ApellidoAdd = ValidarCampoLetras(txt_codPaci, e, ErrorPaciente);
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorFech.SetError(txt_fecha, "");
            ApellidoAdd = ValidarCampoLetras(txt_fecha, e, errorFech);
        }

        private void txt_cita_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCita.SetError(txt_cita, "");
            ApellidoAdd = ValidarCampoLetras(txt_cita, e, errorCita);
        }

       
        private void txt_ConsultaDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodUSuario.SetError(txt_codusuario, "");
            CodUsuario = ValidarCamposNumericos(txt_codusuario, e, errorCodUSuario);
            
        }
   

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            errorFecha.SetError(dateTimePicker1, "");
            FechaCita = ValidarFechaCita(dateTimePicker1);

        }

        private void btnAddCita_Click(object sender, EventArgs e)
        {
            BorrarValidar();
            if (validar.ValidarCamposVacios(textBox1, errorCodigoTarjeta) && validar.ValidarCamposVacios(textBox4, errorCodigoCita)
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


    }
}
