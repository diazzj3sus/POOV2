using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MedicHelpper
{
    class ClassDoctor : ClassUsuarios
    {

        private string cadena = "server=DESKTOP-GAJK8NQ\\WILLIAM;database=MedicHelpperBDD;integrated security = True;";
        public SqlConnection AgDoc;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        private void Conexion()
        {
            AgDoc = new SqlConnection(cadena);
        }
        public ClassDoctor()
        {
            Conexion();
        }

        public bool AgregarCita(string sql)
        {
            AgDoc.Open();
            comando = new SqlCommand(sql, AgDoc);
             int i = comando.ExecuteNonQuery();
            AgDoc.Close();
            if (i>0)
            {
                return true;

            }else { return false; }

        }
        public void BuscarCita(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, AgDoc);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);


        }
        public void IngresarDiagnostico()
        {

        }
    }
}