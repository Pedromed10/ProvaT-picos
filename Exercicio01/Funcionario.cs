using System;

class Funcionario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public decimal Salario { get; set; }

    public Funcionario(string nome, string sobrenome, decimal salario)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Salario = salario;
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}.");
    }
}
