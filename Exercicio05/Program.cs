using System;

class Program
{
    static void Main(string[] args)
    {
        Filme filme = new Filme("Transformers", "Ficção Científica", 120);
        
        filme.RegistrarLocacao();
        filme.VerificarDisponibilidade();
        
        filme.RegistrarDevolucao();
        filme.VerificarDisponibilidade();
    }
}
