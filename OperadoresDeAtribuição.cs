using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresDeAtribuição {
        public static void Executar(){
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine("Número 1 = {0}", num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine("Número A = {0}", a);
            Console.WriteLine("Número B = {0}", b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);


        }
    }
}
