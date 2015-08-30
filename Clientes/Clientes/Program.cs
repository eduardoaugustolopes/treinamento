using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes c = new Clientes();
            c.ClienteID = 1;
            c.ClienteNome = "João";
            c.CnpjCliente = "11.222.333/0001-11";

            Console.WriteLine(c.ClienteNome);

            Console.ReadKey();
        }
    }
}
