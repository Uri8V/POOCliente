using POOCliente.Entidades;
using POOClientes.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCliente.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clientes = new Clientes();
            foreach (var item in clientes.GetCostumersByCountry("USA"))
            {
                Console.WriteLine(item.ShowData());

            }
            Console.ReadLine();
        }
    }
}
