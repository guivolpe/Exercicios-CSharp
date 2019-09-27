using System;

namespace McBonalds
{
    public class Cliente
    {                                       //Atributos
        
        public string Nome {get;set;}  //(get;set;) - para criar uma regra
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        DateTime DataNascimento {get;set;}

                                            //Construtor    -    constroi a classe - instancia a classe.

        public Cliente(string nome, string telefone, string email){  //método (torna obrigatório o preenchimento desses atributos)
            this.Nome = nome;//this - especifica a variável da classe e atribui à variável do método 
            this.Telefone = telefone;
            this.Email = email;
        }

        public Cliente()
        {
        }
    }
}