using System;

namespace loginsenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;
            string guilherme;

            string senhausu;
            string admin;

            guilherme = "guilherme";
            senhausu = "A123";
            admin = "adm";
            
           

            Console.Write("digite o login: ");
            login = Console.ReadLine();
       
            Console.Write("digite sua senha: ");
            senha = Console.ReadLine();


            if ((login == guilherme) && (senha == senhausu)){
                Console.WriteLine("você é um usuário comum");
                }
                else if ((login == admin) && (senha == admin)){
                    Console.WriteLine("você é um administrador de sistema");   
                }
                else {
                    Console.WriteLine("Você não está cadastrado");
                }
                
                         
        }
    }
}
