using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicHelpper
{
    class ClassUsuarios
    {

        protected string Nombre;
        protected string Apellido;
        protected string TipoDeUsuario;
        protected string Password;
        protected string DUI;

        public ClassUsuarios()
        {
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string TipoDeUsuario1 { get => TipoDeUsuario; set => TipoDeUsuario = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string DUI1 { get => DUI; set => DUI = value; }
    }
}