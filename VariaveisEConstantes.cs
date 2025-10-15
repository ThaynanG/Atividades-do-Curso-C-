using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes()
    {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            Console.WriteLine(raio);
            Console.WriteLine(PI);

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é:    " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long :" + menorValorLong);

            ulong populacaoMundial = 8_100_000_000;
            Console.WriteLine("Pupulação Mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Do compuador:" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor máximo decimal " + distanciaEntreEstrelas); 
        }
    }
}
