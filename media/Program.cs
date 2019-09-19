using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3,nota4,media;
            
            Console.Write("entre com a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("entre com a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("entre com a terceira nota:");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("entre com a quarta nota:");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media <=7)
            {Console.Write ("Reprovado!");}
            else
            {Console.Write ("Aprovado");}

            Console.Write("  A media é:  " +media);
        }
    }
}
