using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] atividade = new int[6];
            string numeros = "", tipo = "";
            for (int i = 1  ;  i < 6  ;  i++)
            {
                Console.WriteLine ($"Insira o {i} numero: ");
                atividade[i] = int.Parse(Console.ReadLine());
                tipo += atividade[i] % 2 == 1 ? "impar, " : "par, ";
                numeros += atividade[i] + ", ";
            }
            Console.Write($"Seus números são: \n{numeros}\n{tipo}");
        }
    }
}
