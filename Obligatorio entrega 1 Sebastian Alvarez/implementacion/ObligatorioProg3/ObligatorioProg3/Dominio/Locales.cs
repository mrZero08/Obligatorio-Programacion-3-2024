using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProg3.Dominio
{
    internal class Locales
    {
        private static int _idLocal;
        private string _nombreLocal;
        private string _direccionLocal;
        private string _ciudadLocal;
        private string _telefonoLocal;
        private string _responsableLocal;
        private string _telResponsableLocal;
        public int IdLocal
        {
            get { return _idLocal; }
            set { _idLocal = value; }
        }

        public string NombreLocal
        {
            get { return _nombreLocal; }
            set { _nombreLocal = value; }
        }

        public string DireccionLocal
        {
            get { return _direccionLocal; }
            set { _direccionLocal = value; }
        }

        public string CiudadLocal
        {
            get { return _ciudadLocal; }
            set { _ciudadLocal = value; }
        }

        public string TelefonoLocal
        {
            get { return _telefonoLocal; }
            set { _telefonoLocal = value; }
        }

        public string ResponsableLocal
        {
            get { return _responsableLocal; }
            set { _responsableLocal = value; }
        }

        public string TelResponsableLocal
        {
            get { return _telResponsableLocal; }
            set { _telResponsableLocal = value; }
        }
    }
}
