using System;

namespace Maior_E_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor , i = 0 , menor = double.MaxValue , maior = double.MinValue;

            Console.WriteLine("{0} , {1}"  ,menor, maior);
            do
            {
                Console.WriteLine("Digite um numero inteiro {0}:", i + 1 );
                valor = double.Parse(Console.ReadLine());
                Console.WriteLine("{0} , {1}", menor, maior);
                if (valor < menor)
                {
                    menor = valor;
                }
                else if (valor > maior)
                {
                    maior = valor;
                }

                i++;
                Console.WriteLine("{0} , {1}", menor, maior);
            } while (i < 15 );
            Console.WriteLine("O menor valor eh {0} e o maior valor eh {1}", menor, maior);
        }
    }
}
