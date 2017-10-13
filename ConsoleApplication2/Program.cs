using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroPrimo = new Primo();
            Console.Write("Informe o número a ser verificado: ");
           var resultado = numeroPrimo.nprimo(Convert.ToInt16(Console.ReadLine()));

            Console.Write(resultado);

            
            Console.ReadKey();
        }
    }
}
