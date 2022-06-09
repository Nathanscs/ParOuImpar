using System;

namespace aaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade, i, total;
            int[] numeros;

            Console.WriteLine("Quantos numeros vc vai digitar? ");
            quantidade=int.Parse(Console.ReadLine());
            
            numeros = new int[quantidade];

            for(i=0; i<quantidade; i++)
            {
                Console.WriteLine("Digite o {0}° numero: ", i+1);
                numeros[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\nPar: ");

            for(i=0; i<quantidade; i++)
            {
                total=numeros[i]%2;
                if(total == 0)
                {
                    Console.WriteLine("{0} ", numeros[i]);
                }
            }

            Console.WriteLine("\nImpar: ");

            for(i=0; i<quantidade; i++)
            {
                total=numeros[i]%2;
                if(total != 0)
                {
                    Console.WriteLine("{0} ", numeros[i]);
                }
            }
        }  
    }
}
