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

void Exercicio02()
{
    //Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.
    //Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
    int notaMedia = 0;
    if (notaMedia >= 5)
    {
        Console.WriteLine("nota suficiente para aprovação");
    }
    //Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

    //Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

    //Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado,
    //exibir a n - ésima posição de uma lista.
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
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            Console.WriteLine("Você esclhoeu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção inválida.");
            break;

    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Cadastrar banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    //Interpolação de string
    Console.WriteLine($"A banda {nomeBanda} foi cadastrada com sucesso!");

}

ExibirMensagemBoasVindas();
ExibirOpcoesMenu();
