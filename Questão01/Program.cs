using System.Text.RegularExpressions;

class Program {

static void Main()
{

    Console.WriteLine("Digite sua senha de validação");
    string senha = Console.ReadLine();

    bool tamanhoMinimo = senha.Length >= 8;

    bool temMaiuscula = Regex.IsMatch(senha, "[A-Z]");

    bool temNumero = Regex.IsMatch(senha, "[0-9]");

    bool temEspecial = Regex.IsMatch(senha, @"[!@#$%¨&*()+=\-]");

    if (temNumero && temMaiuscula && temEspecial)
    {
        Console.WriteLine("Senha forte! Todos os critérios foram atendidos");
    }
    else
    {
        Console.WriteLine("Senha fraca. Verifique os seguintes pontos:");

        if (!tamanhoMinimo)

            Console.WriteLine("A senha deve ter no minimo 8 caracteres");

        if (!temMaiuscula)

            Console.WriteLine("A senha deve conter uma letra maiuscula");

        if (!temEspecial)

            Console.WriteLine("A senha deve conter um caracter especial");

        if (!temNumero)

            Console.WriteLine("A senha deve conter um numero");


    }

}
}