using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Você me ama" + " " + (nome) + "?" );
            string ama = Console.ReadLine();

            Console.WriteLine("Ama quanto?");
            long quanto = long.Parse(Console.ReadLine());

            Console.WriteLine("Eu amo você" + " " + quanto + " " + "Vezes o infinito");
        }
    }
}   
