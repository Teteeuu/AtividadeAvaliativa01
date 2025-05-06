using System;

class Program
{
    static void Main()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);
        int chute = 0;
        int tentativas = 0;

        Console.WriteLine("Adivinhe o número de 1 a 100:");

        while (chute != numeroSecreto)
        {
            Console.Write("Digite um número: ");
            chute = int.Parse(Console.ReadLine());
            tentativas++;

            if (chute < numeroSecreto)
            {
                Console.WriteLine("O número é maior!");
            }
            else if (chute > numeroSecreto)
            {
                Console.WriteLine("O número é menor!");
            }
        }

        Console.WriteLine("Parabéns! Você acertou em " + tentativas + " tentativa(s).");
    }
}
