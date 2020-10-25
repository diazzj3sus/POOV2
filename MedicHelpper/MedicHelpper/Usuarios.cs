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
using System.Data.SqlClient;

namespace MedicHelpper
{
    public partial class Usuarios : Form
    {
        ConexionSqlServer conectar = new ConexionSqlServer();
        public Usuarios()
        {
            InitializeComponent();
            //cuenta la cantiad de registros
            conectar.conexion.Open();
            string consulta = "SELECT COUNT(*) FROM TipoUsuario ";
            SqlCommand contador = new SqlCommand(consulta, conectar.conexion);
            int conta = Convert.ToInt32(contador.ExecuteScalar());
            conectar.conexion.Close();
            for (int x = 0; x < conta; x++)
            {
                conectar.conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TipoUsuario where IdTipoUsuario = " + x, conectar.conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cmbtipousuarioreg.Items.Add(Convert.ToString(dr["TipoUsuario"]));
                    cmbbuscartipo.Items.Add(Convert.ToString(dr["TipoUsuario"]));
                }
                conectar.conexion.Close();
            }
        }
        private void Limpiar()
        {
            txbnombreusuarioreg.Clear();
            txbapellidousurioreg.Clear();
            txbduiusuarioreg.Clear();
            txbcontraseñareg.Clear();
            txbbuscarnombre.Clear();
            txbbuscarapellido.Clear();
            txbbuscardui.Clear();
            txbbusquedamuestranombre.Clear();
            txbcontraseñabuscar.Clear();
            cmbbuscartipo.SelectedIndex = -1;
            cmbtipousuarioreg.SelectedIndex = -1;
            dtpfechanacreg.Value = DateTime.Today;

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
        private void cmbtipousuarioreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnlimpiarusuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private string generarCodigoUsuario(string nombre, string apellido, int dia, int año)
        {
            string diaNuveo = "";
            string añoNuevo = Convert.ToString(año);
            string añoN =""+añoNuevo[2] + añoNuevo[3];
            if(dia> 0 && dia <= 9)
            {
                diaNuveo = 0+Convert.ToString(dia);
            }
            else
            {
                diaNuveo = Convert.ToString(dia);
            }
            string primeraLNombre = Convert.ToString( nombre[0]);
            string primeraLApellido = Convert.ToString(apellido[0]);
            string cadenaCodigo = primeraLNombre + primeraLApellido + diaNuveo + añoN;
            return cadenaCodigo.ToUpper();
        }
        private void btningresarusuario_Click(object sender, EventArgs e)
        {
            //try
            //{
                string DUI = txbduiusuarioreg.Text;
                string nombre= txbnombreusuarioreg.Text, apellido = txbapellidousurioreg.Text;
                if (DUI.Length == 9)
                {
                    if(nombre.Length >= 4 && apellido.Length >= 4)
                    {
                        if(cmbtipousuarioreg.SelectedIndex > -1)
                        {
                            //REGISTRAMOS USUARIOS
                            int año = dtpfechanacreg.Value.Year;
                            int mes = dtpfechanacreg.Value.Month;
                            int dia = dtpfechanacreg.Value.Day;
                            string codigoGenerado = generarCodigoUsuario(txbnombreusuarioreg.Text, txbapellidousurioreg.Text, dia,año);
                            MessageBox.Show("" + codigoGenerado);
                            int tipousuario=-1;
                            if (cmbtipousuarioreg.Text == "Administrador")
                            {
                                tipousuario = 0;
                            }
                            else if (cmbtipousuarioreg.Text == "Enfermeria")
                            {
                                tipousuario = 1;
                            }
                            else if (cmbtipousuarioreg.Text == "Dotores")
                            {
                                tipousuario = 2;
                            }
                            else if (cmbtipousuarioreg.Text == "Farmaceutico")
                            {
                                tipousuario = 2;
                            }
                            string nuevafecha = Convert.ToString(dia) + "-" + Convert.ToString(mes) +"-" +Convert.ToString(año);
                            string cadenaInsertar = "INSERT INTO Usuarios VALUES ('" + codigoGenerado + "','" + txbcontraseñareg.Text +"','" + nombre + "','"+apellido +"','"+ dtpfechanacreg.Value +"','"+DUI+"','" + tipousuario + "');";
                            conectar.conexion.Open();
                            SqlCommand inserto = new SqlCommand(cadenaInsertar, conectar.conexion);
                            inserto.ExecuteNonQuery();
                            conectar.conexion.Close();
                            MessageBox.Show("Usuario insertado con éxito\nDatos ingresados:\nCodigo del usuario: " + codigoGenerado +
                                "\nNombre: " + nombre + apellido + "\nFecha de nacimiento: " + dia + "-" + mes + "-" + año + "\nDUI: " + DUI + "\nTipo usuario: " + cmbtipousuarioreg.Text);
                            Limpiar();
                        
                        
                        }
                        else
                        {
                            MessageBox.Show("ALERTA: Seleccione el tipo usuario.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

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
            //}
            //catch
            //{
            //    MessageBox.Show("ALERTA: Verifique los datos ingresados.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
