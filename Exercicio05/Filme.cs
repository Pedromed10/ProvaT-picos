using System;

class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; private set; }

    public Filme(string titulo, string genero, int duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true; 
    }

    public void RegistrarLocacao()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"O filme \"{Titulo}\" foi alugado.");
        }
        else
        {
            Console.WriteLine($"O filme \"{Titulo}\" não está disponível para locação.");
        }
    }

    public void RegistrarDevolucao()
    {
        if (!Disponivel)
        {
            Disponivel = true;
            Console.WriteLine($"O filme \"{Titulo}\" foi devolvido.");
        }
        else
        {
            Console.WriteLine($"O filme \"{Titulo}\" já está disponível para locação.");
        }
    }

    public void VerificarDisponibilidade()
    {
        if (Disponivel)
        {
            Console.WriteLine($"O filme \"{Titulo}\" está disponível para locação.");
        }
        else
        {
            Console.WriteLine($"O filme \"{Titulo}\" não está disponível para locação.");
        }
    }
}
