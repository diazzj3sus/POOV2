using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicHelpper
{
    class ClassUsuarios
    {
        protected string usuario;
        protected string nombre;
        protected string apellido;
        protected string fechaNacimiento;
        protected string tipoDeUsuario;
        protected string password;
        protected string dui;

        public ClassUsuarios()
        {
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string DUI { get => dui; set => dui = value; }
        public string TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
    }
}