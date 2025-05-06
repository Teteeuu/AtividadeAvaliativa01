using System;
class Program{
    static void Main(){

    Console.WriteLine("Digite um número");
    int numero = int.Parse (Console.ReadLine());

    for (int i = 0; i <= 10; i++)
    {
        int resultado = numero * i;
    Console.WriteLine ($"{numero} x {i} = {resultado}");
    }  
    

    }
}