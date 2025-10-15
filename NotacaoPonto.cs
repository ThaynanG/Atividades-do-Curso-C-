using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudação = "olá".ToUpper().Insert(3, "World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudação);
            Console.WriteLine("Teste".Length);

            // nil
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
