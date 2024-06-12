﻿//C# é uma linguagem fortemente tipada igual o java
//ou seja, precisamos declarar as variáveis

using System;

//Para declarar variável, usa camelCase
//Para declarar funções, usa PascalCase

//Instanciando uma lista já populada no escopo global.
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

//Vou substituir a lista pelo dicionário
//Criando dicionário
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//Inserindo bandas no dicionário
bandasRegistradas.Add("LinkPark", new List<int> { 10, 8, 6});
bandasRegistradas.Add("Beatles", new List<int>());

//Criando as funções
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
    ExibirMensagemBoasVindas();
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
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Fim!");
            break;
        default: Console.WriteLine("Opção inválida.");
            break;

    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Cadastrar uma nova banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    //Inutilizei a lista listaDasBandas e substitui pelo dicionário bandasRegistradas
    //listaDasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());
    //Interpolação de string
    Console.WriteLine($"A banda {nomeBanda} foi cadastrada com sucesso!"); Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcoes("Listando as bandas...");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    //aceita qualquer tecla
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesMenu();

void AvaliarBanda()
{
    //digitar banda que deseja avaliar
    //verificar se a banda existe
    //se sim, atribuir uma nota
    //se não, volta ao menu principal

    Console.Clear();
    ExibirTituloOpcoes("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        //Adicionando a nota pra banda
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(2000);
        Console.Clear();

    } else { Console.WriteLine($"A banda {nomeBanda} não está cadastrada");
        Console.WriteLine("Digite uma tecla para voltar para o menu principal");
        Console.ReadKey(); Console.Clear();
        ExibirOpcoesMenu();
    }
}