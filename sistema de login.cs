using System;

class Program
{
    static void Main()
    {
        // Usuário fixo
        string usuarioCorreto = "admin";
        string senhaCorreta = "1234";

        int tentativas = 3;
        bool logado = false;

        Console.WriteLine("=== Sistema de Login ===");
        Console.WriteLine();

        while (tentativas > 0 && !logado)
        {
            Console.Write("Usuário: ");
            string usuarioDigitado = Console.ReadLine();

            Console.Write("Senha: ");
            string senhaDigitada = Console.ReadLine();

            if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("\nLogin realizado com sucesso!");
                logado = true;
            }
            else
            {
                tentativas--;
                Console.WriteLine($"\nUsuário ou senha incorretos! Tentativas restantes: {tentativas}");
                Console.WriteLine();
            }
        }

        if (!logado)
        {
            Console.WriteLine("Você errou muitas vezes. Acesso bloqueado!");
        }

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}
