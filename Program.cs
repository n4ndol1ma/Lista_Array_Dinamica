using System;
using System.Collections.Generic;

class Program
{
    static List<int> arrayInteiros = new List<int>();

    static void Main()
    {
        Menu();

    }

    static void Menu()
    {

        Console.Clear();

        Console.WriteLine("Array Dinamica, adicione quantos numeros quiser!");
        Console.WriteLine("Qual opção deseja utilizar?");
        Console.WriteLine("1 - Listar Cadastrados");
        Console.WriteLine("2 - Criar Cadastro");
        Console.WriteLine("3 - Sair");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Selecione a função desejada");

        short opt = short.Parse(Console.ReadLine());


        switch (opt)
        {


            case 1: OptListar(); break;
            case 2: OptCadastrar(); break;
            case 3: System.Environment.Exit(0); break;
            default: Menu(); break;

        }

        static void OptListar()
        {
            Console.Clear();

            Console.WriteLine("Conteúdo da lista:");

            foreach (int numero in arrayInteiros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Pressione Enter para voltar ao menu principal");
            Console.ReadLine();
            Menu();
        }

        static void OptCadastrar()
        {
            Console.Clear();

            Console.WriteLine("Digite o número que deseja adicionar à lista: ");
            int numero = int.Parse(Console.ReadLine());

            arrayInteiros.Add(numero);

            Console.WriteLine("Número adicionado com sucesso!");

            Console.WriteLine("Pressione Enter para voltar ao menu principal");
            Console.ReadLine();
            Menu();

        }
    }
}

