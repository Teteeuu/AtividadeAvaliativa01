using System;

class Program
{
    static void Main()
    {
        int escolha = 0;

        while (escolha != 3)
        {
            Console.Clear();
            Console.WriteLine("=== Conversor de Temperatura ===");
            Console.WriteLine("1 - Converter de Celsius para Fahrenheit");
            Console.WriteLine("2 - Converter de Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção (1, 2 ou 3): ");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out escolha))
            {
                if (escolha == 1)
                {
                    Console.Write("Digite a temperatura em Celsius: ");
                    string tempCelsius = Console.ReadLine();
                    double celsius = Convert.ToDouble(tempCelsius);
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit.ToString("F2") + " °F");
                }
                else if (escolha == 2)
                {
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    string tempFahrenheit = Console.ReadLine();
                    double fahrenheit = Convert.ToDouble(tempFahrenheit);
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Temperatura em Celsius: " + celsius.ToString("F2") + " °C");
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Saindo do programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

            if (escolha != 3)
            {
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
