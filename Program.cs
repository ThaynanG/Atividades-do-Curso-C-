using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMétodos;
using static CursoCSharp.ClassesEMétodos.CalculadoraCadeia;

namespace CursoCSharp {
    class Program {
       public static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"Variáveis e Constante - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLógicos.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresDeAtribuição.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnários.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernários.Executar},

                // Estrutura de Controle
                {"Estrutura IF - EstruturasDeControle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - EstruturasDeControle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - EstruturasDeControle", EstruturaIfElseIF.Executar},
                {"Estrutura Switch - EstruturasDeControle", EstruturaSwitch.Executar},
                {"Estrutura While - EstruturasDeControle", EstruturaWhile.Executar},
                {"Estrutura Do While - EstruturasDeControle", EstruturaDoWhile.Executar},
                {"Estrutura For - EstruturasDeControle", EstruturaFor.Executar},
                {"Estrutura For Each - EstruturasDeControle", EstruturaForEach.Executar},
                {"Usando Break - EstruturasDeControle", UsandoBreak.Executar},
                {"Usando Continue - EstruturasDeControle", UsandoContinue.Executar},


                // Classes e Métodos  
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MétodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MétodosEstáticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstáticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParâmetrosNomeados.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"ExemploEnum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct VS Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor VS Referência - Classes e Métodos", ValorVsReferencia.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}