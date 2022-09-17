using System;
using Console;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int penultimo=0;
                int ultimo=1;
                int valor = Convert.ToDouble(Console.ReadLine());
               for (int i=2, i<valor, i++)
               {
                
               int proximo=ultimo+penultimo;
               Console.Write(proximo);
               penultimo=ultimo;
               ultimo=proximo;
                 
              
            }
       }
}