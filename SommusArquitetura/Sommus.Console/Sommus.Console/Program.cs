using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sommus.Domain;


namespace SommusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes c = new Clientes();

            Console.WriteLine(c.ClienteID);
            Console.WriteLine(c.LimiteCredito);

            ItensNotasFiscais i = new ItensNotasFiscais();
            i.Quantidade = 10;
            i.ValorUnitario = 250;

            Console.WriteLine(i.ValorTotal);

            Console.ReadKey();
        }
    }
}
