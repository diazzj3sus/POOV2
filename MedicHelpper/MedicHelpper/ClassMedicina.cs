using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicHelpper
{
    class ClassMedicinas
    {

        private string NombreMedicamento;
        private string ViaDeAdministracion;
        private string Familia;
        private string Cod_Medicamento;
        private int Existencia;

        public ClassMedicinas()
        {
        }
        
        public string NombreMedicamento1 { get { return NombreMedicamento; } set { NombreMedicamento = value; } }
        public string ViaDeAdministracion1 { get { return ViaDeAdministracion; } set { ViaDeAdministracion = value; } }
        public string Familia1 { get { return Familia; } set { Familia = value; } }
        public string Cod_Medicamento1 { get { return Cod_Medicamento; } set { Cod_Medicamento = value; } }
        public int Existencia1 { get { return Existencia; } set { Existencia = value; } }
        
    }
}