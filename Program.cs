using System;

namespace Calculadora_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoIdade, anoAtual, idade, semanas;

            Console.WriteLine("Calculadora de idade iniciada\n");

            Console.Write("Digite o seu ano de nascimento: ");
            anoIdade = int.Parse(Console.ReadLine());
            anoAtual = System.DateTime.Now.Year;

            idade = anoAtual - anoIdade;
            semanas = idade * 52;

            Console.WriteLine("\nSua idade atual em anos é de " + idade + " anos.");
            Console.WriteLine($"Sua idade atual em semanas é de {semanas} semanas.");

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
