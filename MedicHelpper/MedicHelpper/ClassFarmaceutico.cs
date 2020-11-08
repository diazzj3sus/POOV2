using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace MedicHelpper
{
    class ClassFarmaceutico : ClassUsuarios
    {
        private string cadena = "server=localhost;database=MedicHelpperBDD;integrated security = True";
        public SqlConnection far;
        private SqlCommandBuilder cmb;
        public DataSet ds= new DataSet();
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

        public void BusquedaReceta(string sql, string tabla)
        {
            sql = "select * from where(IdMedicamentoReceta=txtIdReceta)" + tabla;
            da = new SqlDataAdapter(sql, far);
            DataSet dts = new DataSet();
            da.Fill(dts);
        }
        public void BusquedaDeMedicamentos(string sql,string tabla)
        {
            sql = "select * from where(IdMedicamentos=txtCOdBuscaMEdicamneto)" + tabla;
            da = new SqlDataAdapter(sql, far);
            DataSet dts = new DataSet();
            da.Fill(dts);

        }
        public bool  AñadirMedicamentos(string tabla,string campos,string condicion)
        {
            far.Open();
            string sql = "update" + tabla + " set " + " where " + condicion;
            comando = new SqlCommand(sql, far);
            int i = comando.ExecuteNonQuery();
            far.Close();
            if (i > 0) { return true; }else { return false; }
            
        }
        public DataTable AñadirMedicamentos_Tabla(String tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, far);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public bool DespachoMedicamento(string tabla,string condicion)
        {
            far.Open();
            string Sql = " delete from " + tabla + " where " + condicion;
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
