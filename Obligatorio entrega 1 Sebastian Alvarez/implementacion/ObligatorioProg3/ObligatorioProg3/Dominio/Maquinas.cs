using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProg3.Dominio
{
    internal class Maquinas
    {
        private static int _idMaquina;
        private string _nombreMaquina;
        private string _tipoMaquina;
        private string _disponible;
        private static int _precioCompra;
        private static int _vidaUtil;
        
        public int IdMaquina
        {
            get { return _idMaquina; }
            set { _idMaquina = value; }
        }

        public string NombreMaquina
        {
            get { return _nombreMaquina; }
            set { _nombreMaquina = value; }
        }

        public string TipoMaquina
        {
            get { return _tipoMaquina; }
            set { _tipoMaquina = value; }
        }

        public string Disponible
        {
            get { return _disponible; }
            set { _disponible = value; }
        }

        public int PrecioCompra
        {
            get { return _precioCompra; }
            set { _precioCompra = value; }
        }

        public int VidaUtil
        {
            get { return _vidaUtil; }
            set { _vidaUtil = value; }
        }
    }
}
