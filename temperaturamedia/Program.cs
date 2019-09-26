using System;

namespace temperaturamedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[12];
            double maior = 0;
            double menor = 0;
            
            for(int i = 0; i < 12; i++){
                Console.Write($"Digite a temperatura do mês {i+1}: "); // i+1 é porque não existe mês 0 - janeiro é o mês 1 (i+1) 
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            // Diz que a maior temperatura e a menor é a primeira informada
            maior = temperaturas[0];
            menor = temperaturas[0];

            //comparando para saber qual é a temperatura maior e a menor
            foreach (double temp in temperaturas){
                if(temp > maior){
                    maior = temp;
                }
                else if(temp < menor){
                    menor = temp;
                }   
            }
            Console.WriteLine($"A maior temperatura é {maior}");
            Console.WriteLine($"A menor temperatura é {menor}");
        }
    }
}
