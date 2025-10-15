using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //preço desconto 
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            Console.WriteLine(total);
            Console.WriteLine(totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O IMC É: {0}", imc);

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2);
        }
    }
}
