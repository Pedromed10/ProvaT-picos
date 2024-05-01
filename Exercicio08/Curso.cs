using System;
using System.Collections.Generic;

public class Curso
{
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public List<double> Notas { get; }

    public Curso(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
        Notas = new List<double>();
    }

    public void AdicionarNota(double nota)
    {
        Notas.Add(nota);
    }

    public virtual double CalcularMedia()
    {
        if (Notas.Count == 0)
            return 0;

        double soma = 0;
        foreach (var nota in Notas)
        {
            soma += nota;
        }
        return soma / Notas.Count;
    }

    public virtual void GerarCertificado()
    {
        Console.WriteLine($"Certificado de conclusão do curso de {Nome}");
    }
}
