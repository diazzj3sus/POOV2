using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicHelpper
{
    class ClassPaciente
    {

        private string Nombres;
        private string Apellido;
        private string NTelefono;
        private string Direccion;
        private int Edad;
        private string Ntarjeta;

        public ClassPaciente()
        {
        }
    
        public string Nombres1 { get { return Nombres; } set { Nombres = value; } }
        public string Apellido1 { get {return Apellido; } set { Apellido = value; } }
        public string NTelefono1 { get { return NTelefono; } set { NTelefono = value; } }
        public string Direccion1 { get {return Direccion; } set { Direccion = value; } }
        public int Edad1 { get { return Edad; } set { Edad = value; } }
        public string Ntarjeta1 { get {return Ntarjeta; } set { Ntarjeta = value; } }
            
    }
}