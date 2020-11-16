using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, anoAtual, idade, semanas;

            Console.WriteLine("Qual seu ano de nascimento?");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano você está?");
            anoAtual = int.Parse(Console.ReadLine());

            idade = (anoAtual-anoNascimento);
            semanas = (idade*52);

            Console.WriteLine("Você tem "+idade+" anos, que em semanas são "+semanas);
        }
    }
}
