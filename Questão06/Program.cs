
using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();

            Console.WriteLine($"\nProduto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\nProdutos cadastrados:\n");

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: R$ {p.Preco:F2}");
            Console.WriteLine($"Quantidade: {p.Quantidade}");
            Console.WriteLine($"Valor total em estoque: R$ {p.ValorTotalEmEstoque():F2}\n");
        }
    }
}
