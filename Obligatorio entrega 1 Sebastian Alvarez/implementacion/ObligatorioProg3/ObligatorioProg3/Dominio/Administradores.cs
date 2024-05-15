using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProg3.Dominio
{
    internal class Administradores : Personas
    {
        private static int _idAdmin;
        private string _usuario;
        private string _contraseña;

        public int IdAdmin
        {
            get { return _idAdmin; }
            set { _idAdmin = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
    }
}
