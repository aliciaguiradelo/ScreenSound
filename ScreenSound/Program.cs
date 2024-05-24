//C# é uma linguagem fortemente tipada igual o java
//ou seja, precisamos declarar as variáveis

using System;

//Para declarar variável, usa camelCase
//Para declarar funções, usa PascalCase

void ExibirMensagemBoasVindas()
{
    String mensagemBoasVindas = "Olá! Seja bem-vindo!";
    Console.WriteLine("************************************");
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("************************************");
}



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