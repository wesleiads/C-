using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                Console.Write("Informe um valor: ");
               
                double valor = Convert.ToDouble(Console.ReadLine());

                double dolar = 5.17;
                double euro = 6.14;
                double pesos = 0.05;
            
                Console.Write("Valor em Dólar: " + CalculaDol(valor, dolar));
                Console.Write(" Valor em Euro: " + CalculaEu(valor, euro));
                Console.Write(" Valor em Pesos: " + CalculaPe(valor, pesos));
            }
        
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            static double CalculaDol (double valor, double dolar)
            {
                 return valor * dolar;
            }
             static double CalculaEu (double valor, double euro)
             {
                 return valor * euro;
             }
              static double CalculaPe (double valor, double pesos) 
              
            {
                 return valor * pesos;
            }
        }
    }
}