using MedicHelpper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class Farmaceuticos : Form
    {
        public Farmaceuticos()
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
        private void btnRestaurar_Click_1(object sender, EventArgs e)
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
        private void pctAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador login = new MenuAdministrador("");
            login.Show();
        }
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
        private bool ValidarFechaCita(DateTimePicker dtp)
        {
            DateTime fechaSeleccionada = datmMedicamento.Value;
            DateTime fechaActual = System.DateTime.Now;
            bool ok = true;
            if (fechaSeleccionada < fechaActual)
            {
                errorFechaMedicamento.SetError(datmMedicamento, "Error la fecha seleccionada es menor a la fecha actual");
                ok = false;
            }
            return ok;
        }
        private void BorrarValidar ()
        {
            errorFechaMedicamento.SetError(datmMedicamento, "");
            errorNombre.SetError(txtNOmbreMEdicamento, "");
            errorUbicacion.SetError(txtUbicacionMed, "");
            errorDescripcion.SetError(txtDescripcionmed, "");
            errorCodigoMed.SetError(txtCodigo, "");
            errorCantidad.SetError(txtCantidadMed, "");
            

        }

        private void datmMedicamento_ValueChanged(object sender, EventArgs e)
        {
          // errorFechaMedicamento.SetError(datmMedicamento, "");
           // FechaExpir =ValidarCamposVacios(datmMedicamento, errorFechaMedicamento);
        }

        private void datmMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }
        bool FechaExpir;

        private void txtNOmbreMEdicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorNombre.SetError(txtNOmbreMEdicamento, "");
            nomr = ValidarCamposVacios(txtNOmbreMEdicamento, errorNombre);
        }
        bool nomr;

        private void txtUbicacionMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorUbicacion.SetError(txtUbicacionMed, "");
            ubi = ValidarCamposVacios(txtUbicacionMed,  errorUbicacion);

        }
        bool ubi;
private void txtDescripcionmed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorDescripcion.SetError(txtDescripcionmed, "");
            des = ValidarCamposVacios(txtDescripcionmed, errorDescripcion);
        }
        bool des;

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodigoMed.SetError(txtCodigo, "");
            cod = ValidarCamposNumericos(txtCodigo, e,errorCodigoMed);
        }
        bool cod;

        private void txtCantidadMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCantidad.SetError(txtCantidadMed, "");
            cant = ValidarCamposNumericos(txtCantidadMed, e, errorCantidad);
        }
        bool cant;
        //Farmaceuticos obDatos = new Farmaceuticos();
        private void btningresarusuario_Click(object sender, EventArgs e)
        {
           

           
        }

        private void btnMostMedicamento_Click(object sender, EventArgs e)
        {

        }
    }
}

