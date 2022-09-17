using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                Console.Write("Informe o primeiro número: ");
                
                int valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o segundo número: ");

                int valor2 = Convert.ToDouble(Console.ReadLine());
              
                
            }
        
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            if (valor > valor2)

            {
                
                 Console.WriteLine("O valor é maior");
            
            }
            else if (valor < valor2)
            {
                Console.WriteLine("O valor é menor");
            }
        }
    }
}