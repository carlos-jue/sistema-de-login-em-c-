using System;

class Program
{
    static void Main()
    {
        string usuario = "admin";
        string senha = "1234";

        Console.WriteLine("Login");
        Console.Write("Digite o usuario: ");
        string userDigitado = Console.ReadLine();

        Console.Write("Digite a senha: ");
        string senhaDigitada = Console.ReadLine();

        if (userDigitado == usuario && senhaDigitada == senha)
        {
            Console.WriteLine("Logado com sucesso!");
        }
        else
        {
            Console.WriteLine("Usuario ou senha errado!");
        }

        Console.ReadLine();
    }
}
