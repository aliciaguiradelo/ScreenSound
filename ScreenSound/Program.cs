//C# é uma linguagem fortemente tipada igual o java
//ou seja, precisamos declarar as variáveis

using System;

//Para declarar variável, usa camelCase
//Para declarar funções, usa PascalCase

void ExibirMensagemBoasVindas()
{
    //O @ é um Verbatim literal que serve para mostrar a String exatamente como ela vai aprecer no console
    Console.WriteLine(@"

    ░██████╗░█████╗░██████╗░███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

}

void Exercicio01()
{
    //Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
    String curso = "Curso C# e .NET";

    //Mostrar o conteúdo da variável curso no console
    Console.WriteLine(curso);

    // Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome
    String nome = "Alicia ";
    String sobrenome = "Guiradelo";
    Console.WriteLine("Aluna: " + nome + sobrenome);

    //Mostrar na tela o nome dos instrutores do curso
    String instrutor = "Guilherme";
    Console.WriteLine("Instrutor: " + instrutor);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("1. Cadastrar uma banda");
    Console.WriteLine("2. Listar bandas");
    Console.WriteLine("3. Avaliar banda");
    Console.WriteLine("4. Exibir média de uma banda");
    Console.WriteLine("5. Sair");
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você esclhoeu a opção " + opcaoEscolhidaNumerica);
    }
}

ExibirMensagemBoasVindas();
ExibirOpcoesMenu();
