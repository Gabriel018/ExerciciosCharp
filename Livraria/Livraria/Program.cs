// See https://aka.ms/new-console-template for more information
using Livraria;

Menu.Exibir();

public static class Menu
{
    public static void Exibir()
    {
        Console.WriteLine("Bem vindo a livraria");
        Console.WriteLine("");
        Console.WriteLine("Escolhar uma opçao");
        Console.WriteLine("");
        Console.WriteLine("1- Cadastrar  usuario");
        Console.WriteLine("2- Cadastrar livros");
        Console.WriteLine("3- Exibir usuarios");
        Console.WriteLine("4- Exibir livros");
        Console.WriteLine("5- Sair");


        int operacao = Convert.ToUInt16(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                Cliente.Insert();
                break;
            case 2:
                Console.WriteLine("Opçao 1");
                break;
            case 3:
                Console.WriteLine("Opçao 1");
                break;
            case 4:
                Console.WriteLine("Opçao 1");
                break;
            case 5:
                Console.WriteLine("Opçao 1");
                break;
        }



    }
}


