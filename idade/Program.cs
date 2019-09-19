using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            
            Console.WriteLine("Digite a Idade");
            num1 = int.Parse(Console.ReadLine());
            num2 = 12;

            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

        }
    }
}
