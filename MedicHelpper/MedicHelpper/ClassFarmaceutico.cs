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
            da = new SqlDataAdapter(sql, far);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
         
        }
        public void BusquedaDeMedicamentos(string sql,string tabla)
        {
            da = new SqlDataAdapter(sql, far);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }
        public bool  AñadirMedicamentos(string sql)
        {
           
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
