using POOCliente.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClientes.Datos
{
    public class Clientes
    {
        private Dictionary<string, Cliente> _clientes;
        private Dictionary<string, List<Cliente>> _clientesPorPais;

        public Dictionary<string,Cliente> ObtenerClientes()
        {
            return _clientes;
        }

        public Dictionary<string, List<Cliente>> ObtenerClientesPorPais()
        {
            return _clientesPorPais;
        }
        public Clientes()
        {
             //Preguntar punto I
             _clientes = new Dictionary<string, Cliente>();
            SetClientes();
        }

        private Dictionary<string,Cliente> SetClientes()
        {
            _clientes=CsvManager.GetAllCostumers();
            return _clientes;
        }

        private void SetCostumersByCountry()
        {

        }
        //Preguntar punto M, K,L(si debo usar el punto k para hacer el L)
        public List<Cliente> GetAllCostumers()
        {
            var listaClientes=new List<Cliente>();
            foreach (var cliente in _clientes.Values)
            {
                if (_clientes.ContainsKey(cliente.getClienteId()))
                {
                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }

        public KeyValuePair<string, Cliente> GetCountryAt(int indice)
        {
            if (indice >= 0 || indice <_clientes.Count())
            {
                return this._clientes.ElementAt(indice);
            }
            throw new Exception("El Pais esta fuera del rango");

        }

        public List <Cliente> GetCostumersByCountry(string nombrePais) 
        {
            var listaCliente= new List<Cliente>();
            foreach (var item in _clientes.Values)
            {
                if (item.getPais()==nombrePais)
                { 
                    listaCliente.Add(item); 
                }
            }
            return listaCliente;
        }

        public List<string> GetCountries()
        {
            var listaCournties = new List<string>();
            foreach (var c in _clientes.Values)
            {
                if (_clientes.ContainsValue(c))
                {
                    listaCournties.Add(c.getPais());
                }
            
            }
            return listaCournties;
        }

        public int GetCount()
        {
            return _clientes.Count;
        }
        public bool EliminarPaisPorCodigo(string CodigoParaBorrar)
        {
            if (_clientes.ContainsKey(CodigoParaBorrar))
            {
                _clientes.Remove(CodigoParaBorrar);
                Console.WriteLine("Cliente eliminado");
                return true;
            }
            Console.WriteLine("Codigo de Cliente mal ingresado");
            return false;
        }

        public static bool operator ==(Clientes clientes, Cliente cliente)
        {
            if (clientes.Equals(cliente.getClienteId()))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Clientes clientes, Cliente cliente)
        {
            return !(clientes.Equals(cliente));
        }
    }

}
