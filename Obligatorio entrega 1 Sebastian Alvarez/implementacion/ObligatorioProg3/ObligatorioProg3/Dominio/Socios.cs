using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProg3.Dominio
{
    internal class Socios : Personas
    {
        private static int _idSocio;
        private string _tipoSocio;
        private string _telefonoSocio;
        private string _mailSocio;

        public int IdSocio
        {
            get { return _idSocio; }
            set { _idSocio = value; }
        }

        public string TipoSocio
        {
            get { return _tipoSocio; }
            set { _tipoSocio = value; }
        }

        public string TelefonoSocio
        {
            get { return _telefonoSocio; }
            set { _telefonoSocio = value; }
        }

        public string MailSocio
        {
            get { return _mailSocio; }
            set { _mailSocio = value; }
        }
    }
}
