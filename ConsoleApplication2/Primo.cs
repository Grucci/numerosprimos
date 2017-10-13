using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Primo : IPrimo
    {
        public string nprimo(int numero)
        {
            int a=0;
            for (int i = numero; i > 0; i--)
            {
                if (numero % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                return "o número " + numero + " é Primo";
            }
            else
            {
                return "o número " + numero + " não é Primo";
            }
        }
    }
}
