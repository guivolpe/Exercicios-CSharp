using System;

namespace aumentosalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario,aumento;
            
            Console.Write("Digite o salário:");
            salario = double.Parse(Console.ReadLine());
            aumento = 1.3;

            if (salario <500)
            {
                Console.Write ($"Seu novo salário é: R$ {salario * aumento}");
            }         
            else
            {
                Console.Write ("Infelizmente você não teve aumento");
            }


        }
    }
}
