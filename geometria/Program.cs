using System;

namespace geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            double basemaior = 0;
            double basemenor = 0;
            double altura = 0;
            double raio = 0;
            double pi = 3.14;

      
            pi=3.14;
                   
                   Console.WriteLine("Digite a forma");
                   forma = Console.ReadLine();                              

              switch(forma){
                
                // *************************TRIÂNDULO******************************  
                    case "triangulo":
                    Console.WriteLine("qual a basemaior?");
                    basemaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a altura?");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{basemaior} * {altura} / 2 = {(basemaior*altura) / 2}");
                break;

                // *************************QUADRADO******************************  
                    case "quadrado":
                    Console.WriteLine("qual a basemaior?");
                    basemaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a altura?");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{basemaior} * {altura}  = {(basemaior*altura)}");
                break;

                // *************************RETÂNGULO******************************                   
                    case "retangulo":
                    Console.WriteLine("qual a basemaior?");
                    basemaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a altura?");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{basemaior} * {altura}  = {(basemaior*altura)}");
                break;

                // *************************TRAPÉSIO******************************    
                    case "trapesio":
                    Console.WriteLine("qual a basemaior?");
                    basemaior = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a basemenor?");
                    basemenor = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a altura?");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"(({basemaior} + {basemenor}) * {altura}) / 2 = {((basemaior+basemenor)*altura) / 2}");
                break;

                // *************************CÍRCULO******************************    
                    case "circulo":
                    Console.WriteLine("qual o raio?");
                    raio = double.Parse(Console.ReadLine());
                    Console.WriteLine($"({pi}*({raio}*{raio}) = {(pi *( raio * raio ))}");
                break;    

                default:
                    Console.WriteLine("Operação não reconhecida");
                break;
                }
        }
    }
}
