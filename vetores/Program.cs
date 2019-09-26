using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6]; //para onde o número será armazenado
            int pares =0;
            int impares =0;

            for(int cont = 0; cont <6; cont ++){ // matriz a partir do zero - menor que 6 - somando-se 1 a cada comando
                Console.WriteLine(" Digite um número: ");
                vetor[cont] = int.Parse(Console.ReadLine()); //ler o numero que o usuário digitou - converte string em int
            } 
            foreach (int num in vetor){ // para cada número inteiro dentro do meu vetor, faça isso:
                if(num%2 == 0){
                    pares += 1;
                    // pares = pares +1;
                    // pares++;
                    }
                else{
                    impares += 1;                
                    }              
            }
            Console.WriteLine($"Você tem {pares} números pares e {impares} números ímpares");

        }

    }
}
