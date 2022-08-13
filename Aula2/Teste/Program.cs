using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                Console.Write("Informe uma Largura: ");
                // string largura = Console.ReadLine();
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe uma Altura: ");
                //string altura = Console.ReadLine();
                double altura = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("A área equivale a: " + CalculaArea(largura, altura));
            }
        
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            static double CalculaArea (double largura, double altura) 
            {
                 return largura * altura;
            }
        }
    }
}