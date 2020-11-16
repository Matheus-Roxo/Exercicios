using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, dias, horas, minutos;
            
            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            meses = (idade*12);
            dias = (idade*365);
            horas = (idade*8760);
            minutos = (idade*525600);
            
            Console.WriteLine("Você viveu durante "+meses+" Meses, "+dias+" dias, "+horas+" horas, "+minutos+" e minutos.");
        }
    }
}
