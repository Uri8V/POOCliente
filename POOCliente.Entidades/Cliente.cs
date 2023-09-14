using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCliente.Entidades
{
    public class Cliente
    {
        private string _ciudad { get; set; }
        private string _clienteId { get; }
        private string _codigoPostal { get; set; }
        private string _direccion { get; set; }
        private string _nombreCompania { get; set; }
        private string _pais { get; set; }
        private string _telefono { get; set; }

        public string getClienteId()
        {
            return _clienteId;
        }

        public string getPais()
        {
            return _pais;
        }
       

        public Cliente( string ciudad,  string clienteId ,string direccion, string nombreCompania, string pais)
        {
            _ciudad = ciudad;
            _clienteId = clienteId;
            _direccion = direccion;
            _nombreCompania = nombreCompania;
            _pais = pais;
        }

        public Cliente(string ciudad, string clienteId, string codigoPostal, string direccion, string nombreCompania, string pais, string telefono)
        {
            _ciudad = ciudad;
            _clienteId = clienteId;
            _codigoPostal = codigoPostal;
            _direccion = direccion;
            _nombreCompania = nombreCompania;
            _pais = pais;
            _telefono = telefono;
        }

        public bool Validar()
        {
            bool valido = true;
            if(string.IsNullOrEmpty(_direccion))
            {
                valido = false;
            }
            if(string.IsNullOrEmpty(_ciudad))
            {
                valido = false;
            }
            if (string.IsNullOrEmpty(_nombreCompania))
            {
                valido = false;
            }
            if(string.IsNullOrEmpty(_clienteId))
            {
                valido = false;
            }
            if(string.IsNullOrEmpty(_pais))
            {
                valido = false;
            }
            return valido;
        }

        public string ShowData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El ID del Cliente es {_clienteId}");
            sb.AppendLine($"El nombre de la compania es {_nombreCompania}");
            sb.AppendLine($"Se encuentra en el País {_pais}, en la ciudad de {_ciudad} y su dirección es {_direccion}");
            return sb.ToString();
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            if(c1._clienteId == c2._clienteId && c1._nombreCompania==c2._nombreCompania)
            { 
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
