using System;

namespace qualaidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int idade;
            int anoatual = 2019;

            Console.Write("digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            //int.parse (converte o valor string em outra variável)

            idade = anoatual - ano;
            Console.WriteLine("sua idade é " + idade + " anos");

            if (idade <=3){
                Console.WriteLine("você é um Recém-Nascido");
                }
                else if (idade >3 && idade <=12)
                {
                    Console.WriteLine("você é uma Criança");   
                }
                else if (idade >12 && idade <=20)
                {
                    Console.WriteLine("você é um Adolescente");  
                }
                else if (idade >20 && idade <=65)
                {
                    Console.WriteLine("você é um Adulto");      
                }
                else if (idade >65){Console.WriteLine("você é um Idoso");
                }          
        }
    }
}
