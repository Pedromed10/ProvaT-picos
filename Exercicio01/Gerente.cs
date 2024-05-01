using System;

class Gerente : Funcionario
{
    public string Departamento { get; set; }

    public Gerente(string nome, string sobrenome, decimal salario, string departamento)
        : base(nome, sobrenome, salario)
    {
        Departamento = departamento;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, sou a gerente {Nome} {Sobrenome} do departamento {Departamento}.");
    }
}
