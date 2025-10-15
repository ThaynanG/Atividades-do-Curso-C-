using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolação {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "dell";
            double preco = 58000.00;
            Console.WriteLine("O " + nome + " da Marca "
                + marca + " custa " + preco + ".");
            Console.WriteLine("O {0} da Marca {1} custa {2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é Legal!!");
            Console.WriteLine($"1 + 1 = {1 + 1}!");

            
        }
    }
}
