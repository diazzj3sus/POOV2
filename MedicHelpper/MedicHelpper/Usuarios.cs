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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txbnombreusuarioreg.Clear();
            txbapellidousurioreg.Clear();
            txbduiusuarioreg.Clear();
            txbbuscarnombre.Clear();
            txbbuscarapellido.Clear();
            txbbuscardui.Clear();
            txbbusquedamuestranombre.Clear();
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
        //registrar usuario------------------------------------------------------------
        private void txbnombreusuarioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)){ e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txbapellidousurioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbduiusuarioreg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnlimpiarusuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btningresarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                string DUI = txbduiusuarioreg.Text;
                string nombre= txbnombreusuarioreg.Text, apellido = txbapellidousurioreg.Text;
                if (DUI.Length == 9)
                {
                    if(nombre.Length >= 5 && apellido.Length >= 5)
                    {
                        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    }
                    else
                    {
                        MessageBox.Show("ALERTA: Revise nombre y apellido ingresado.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ALERTA: DUI debe tener 9 caracteres.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //------------------------------------------------------------
        //Modificar usuario------------------------------------------------------------
        private void txbbuscarnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txbbuscarapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbbuscardui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txbnombrebusqueda.Text;
                if (nombre.Length > 4)
                {
                    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                }
                else
                {
                    MessageBox.Show("ALERTA: Verifique los datos ingresados para la busqueda.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {

                string DUI = txbbuscardui.Text;
                string nombre = txbbuscarnombre.Text, apellido = txbbuscarapellido.Text;
                if (DUI.Length == 9)
                {
                    if (nombre.Length >= 5 && apellido.Length >= 5)
                    {
                        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    }
                    else
                    {
                        MessageBox.Show("ALERTA: Revise nombre y apellido ingresado.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ALERTA: DUI debe tener 9 caracteres.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    private void btnlimpiarbusqueda_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //------------------------------------------------------------
        //mostrar usuarios------------------------------------------------------------
        private void txbnombrebusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txbbusquedamuestranombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscarEnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txbbusquedamuestranombre.Text;
                if (nombre.Length > 4)
                {
                    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                }
                else
                {
                    MessageBox.Show("ALERTA: Verifique los datos ingresados para la busqueda.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pctAtras_Click(object sender, EventArgs e)
        {

            this.Hide();
            MenuAdministrador menu = new MenuAdministrador("");
            menu.Show();
        }

    }
        //------------------------------------------------------------
}
