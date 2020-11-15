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
    class ClassFarmaceutico : ClassUsuarios
    {
        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        public SqlConnection far;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        private void Conectar()
        {
            far = new SqlConnection(cadena);
        }

        public ClassFarmaceutico()
        {
            Conectar();
        }
        public DataTable MostrarMedicamento()
        {
            SqlDataAdapter da = new SqlDataAdapter("BMD_Medicamento", far);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable BusquedaReceta()
        {
            SqlDataAdapter da = new SqlDataAdapter("RM_MostrarMedicamento", far);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void BusquedaMedicamentos(TextBox txtBuscarMed)
        {
            try
            {
                string selec = "SELECT * FROM Medicamentos WHERE IdMedicamento = @idMedi";
                comando = new SqlCommand(selec, far);                
                comando.Parameters.Add(new SqlParameter("@idMedi", SqlDbType.Int));
                comando.Parameters["@idMedi"].Value = Convert.ToInt32(txtBuscarMed.Text);
                far.Open();
                SqlDataReader Buscar = comando.ExecuteReader();
                if (Buscar.Read())
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando.ToString(), far);                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    far.Close();
                }
                else
                {
                    DialogResult mensaje;
                    mensaje = MessageBox.Show("No se encontro el Medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    far.Close();
                }
                far.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Medicamento no encontrado o no ha sido ingresado, error en la busqueda."+ex, "Reintentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                far.Close();
            }
            finally
            {
                far.Close();
            }
        }
        public bool  AñadirMedicamentos(string sql)
        {
            far.Open();
            comando = new SqlCommand(sql, far);
            int i = comando.ExecuteNonQuery();
            far.Close();
            if (i > 0) { return true; }else { return false; }
            
        }
      
        public bool DespachoMedicamento(string tabla,string condicion)
        {
            far.Open();
            string Sql = " update " + tabla + " set " + "where"+condicion;
            comando = new SqlCommand(Sql, far);
            int i = comando.ExecuteNonQuery();
            far.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
