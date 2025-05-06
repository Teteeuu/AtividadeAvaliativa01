using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase palíndromo (sem acento):");
        string texto = Console.ReadLine();

        texto = texto.ToLower();

        texto = texto.Replace(" ", "");

        string textoInvertido = "";

        int i = texto.Length - 1;
        while (i >= 0)
        {
            textoInvertido = textoInvertido + texto[i];
            i--;
        }

        if (texto == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}
