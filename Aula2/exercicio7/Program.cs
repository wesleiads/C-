using System;

namespace exercicio7
{
    class Program
    {
        static double calcalaMedia(double[] numeros)
        {
            double soma = 0.0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma / numeros.Length;
        }

        static double calcalaMediana(double[] numeros)
        {
            Array.Sort (numeros);
            int meio = numeros.Length / 2;
            if (numeros.Length % 2 == 0)
            {
                return (numeros[meio] + numeros[meio - 1]) / 2;
            }
            else
            {
                return numeros[meio];
            }
        }

        static double calculaModa(double[] numeros)
        {
            double[] repeticoes = new double[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                double atual = numeros[i];
                int cont = 0;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] == atual)
                    {
                        cont++;
                    }
                }
                repeticoes[i] = cont;
            }
            int maior = 0;
            for (int i = 1; i < repeticoes.Length; i++)
            {
                if (repeticoes[i] > repeticoes[i - 1])
                {
                    maior = i;
                }
            }
            return numeros[maior];
        }

        static void Main(string[] args)
        {
            double[] numeros = { 1, 1, 4, 8, 2, 6 };
            double media = calcalaMedia(numeros);
            Console.WriteLine("A media " + media);
            double mediana = calcalaMediana(numeros);
            Console.WriteLine("A mediana " + mediana);
            double moda = calculaModa(numeros);
            Console.WriteLine("A moda " + moda);
        }
    }
}
