
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MedicHelpper
{
    class ClassEnfermero : ClassUsuarios
    {


        private string cadena = "server=LAPTOP-B09UIF2D\\MSSQLSERVERDEV;database=MedicHelpperBDD;integrated security = True";
        public SqlConnection conexion;
        //private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void conectar()
        {
            conexion = new SqlConnection(cadena);
        }
        public ClassEnfermero()
        {
            conexion = new SqlConnection(cadena);
            conectar();
        }
        public void AgregarCita(DateTimePicker fechaCita, string nCita, string nTarjeta)
        {
            int estado = 1;
            int año = fechaCita.Value.Year;
            int mes = fechaCita.Value.Month;
            int dia = fechaCita.Value.Day;
            string fecha = dia.ToString() + "-" + mes.ToString() + "-" + año.ToString();
            string insertar;
            // insertar = "INSERT INTO Cita ()"

        }
        public void AgregarPaciente(string id, string nombre, string apellido, string fechaNacimiento)
        {
            try
            {
                conexion.Open();
                string insertar;
                insertar = "INSERT INTO Pacientes (IdPaciente,Nombre,Apellido,FechaDeNacimiento)";
                insertar += "VALUES(@id,@nombre,@apellido,@fechaNacimiento)";
                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                comando.Parameters["@id"].Value = id;
                comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 75));
                comando.Parameters["@nombre"].Value = nombre;
                comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar, 75));
                comando.Parameters["@apellido"].Value = apellido;
                comando.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.DateTime, 75));
                comando.Parameters["@fechaNacimiento"].Value = fechaNacimiento;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Paciente añadido al sistema exitosamente", "Insercion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Paciente no ingresado, error en la base de datos" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void BuscarPaciente()
        {

        }
        public DataTable MostrarPaciente()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarPacientes", cadena);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}