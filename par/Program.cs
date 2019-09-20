using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num;
            do
                {
                    Console.WriteLine("Digite um número ou 0 para terminar:");
                    num = double.Parse(Console.ReadLine());
            
                    if (num !=0)
                        {
                        if (num % 2 == 0 )
                        {Console.WriteLine ("Seu número é Par!");}
                        else
                        {Console.WriteLine ("Seu número é Impar!");}
                        }
                } 
                while(num !=0);



        }
    }
}
