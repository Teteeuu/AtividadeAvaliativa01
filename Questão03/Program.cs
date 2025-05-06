using System;
using System.Numerics; 

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo:");
        string entrada = Console.ReadLine();
        int numero;

        bool convertido = int.TryParse(entrada, out numero);

        if (!convertido || numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um número inteiro positivo.");
            return;
        }

        BigInteger resultado = 1;

        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        Console.WriteLine($"Fatorial de {numero} é:\n{resultado}");
    }
}
