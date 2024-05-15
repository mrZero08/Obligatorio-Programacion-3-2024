using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProg3.Dominio
{
    public class Personas
    {
        public string _nombre;
        public string _apellido;
        public string _edad;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _nombre = value; }
        }

        public string Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
    }
}
