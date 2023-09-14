using POOCliente.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClientes.Datos
{
    public static class CsvManager
    {
        private static string _cvsFilePath = @"C:\Users\uri8m\OneDrive\Escritorio\Programación Orientada a Objetos(POO)\POOCliente\Customers.csv";

        public static Dictionary<string, Cliente> GetAllCostumers()
        {
            var diccionarioCliente = new Dictionary<string, Cliente>();
            if (File.Exists(_cvsFilePath))
            {
                using (var reader = new StreamReader(_cvsFilePath))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        var cvsLine = reader.ReadLine();
                        Cliente cliente = ConstruirCliente(cvsLine);
                        diccionarioCliente.Add(cliente.getClienteId(), cliente);
                    }
                } 
            }
            return diccionarioCliente;
        }

        private static Cliente ConstruirCliente(string cvsLine)
        {
            string[] archivos= cvsLine.Split(';');

            string Ciudad = string.Empty;
            string ClienteId = string.Empty;
            string CodigoPostal = string.Empty;
            string Direccion = string.Empty;
            string NombreCompania = string.Empty;
            string Pais = string.Empty;
            string Telefono= string.Empty;


            ClienteId = archivos[0];
            NombreCompania = archivos[1];
            Direccion = archivos[2];
            Ciudad = archivos[3];
            Pais= archivos[4];
            CodigoPostal = archivos[5];
            Telefono= archivos[6];
           

            return new Cliente( Ciudad, ClienteId, CodigoPostal, Direccion, NombreCompania, Pais,Telefono);
        }
    }
}
