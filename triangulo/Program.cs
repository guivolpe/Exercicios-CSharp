using System;

namespace triandulo
{
    class Program
    {
        static void Main(string[] args){
            

            Console.WriteLine("Tamanho do triangulo");
            int tamanhoTriangulo = int.Parse (Console.ReadLine());
            Console.WriteLine("Quantidade de triangulos");
            int qntTriangulo = int.Parse (Console.ReadLine());
       

            for (int i = 0; i <qntTriangulo; i ++){
                string estrelas = "";

                for(int j=0; j <tamanhoTriangulo; j ++){
                    estrelas += "*";
                    Console.WriteLine(estrelas);
                }
                Console.WriteLine();
            }
        }
    }
}
