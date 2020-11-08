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
        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        public SqlConnection enfer;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public void conectar() 
        {
            enfer = new SqlConnection(cadena);
        }
        public ClassEnfermero()
        {
            conectar();
        }
    public void AgregarCita(DateTimePicker fechaCita, string nCita, string nTarjeta) {
            int estado = 1;
            int año = fechaCita.Value.Year;
            int mes = fechaCita.Value.Month;
            int dia = fechaCita.Value.Day;
            string fecha = dia.ToString() + mes.ToString() + año.ToString();
            string sql = "INSERT INTO Cita VALUES ('" + fecha + "','" + nCita + "','"+ nTarjeta+ "','"+estado+"');";
            enfer.Open();
            SqlCommand inserto = new SqlCommand(sql, enfer);
            inserto.ExecuteNonQuery();
            enfer.Close();
        }
        public void AgregarPaciente() {
          
        }        
        public void BuscarPaciente() {
                   
        }
        public DataTable MostrarPaciente() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarPacientes",cadena);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}