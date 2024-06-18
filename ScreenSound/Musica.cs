class Musica
{
    //atributos (caracteristicas da classe)
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    //além de caracteristicas as classes também tem comportamentos que são os métodos
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Está disponível no plano");
        } else { Console.WriteLine("Não está disponível!");
        }
    }
}

