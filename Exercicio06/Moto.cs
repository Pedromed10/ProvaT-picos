
using System;

class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public Moto(string marca, string modelo, int ano, int cilindrada)
        : base(marca, modelo, ano)
    {
        Cilindrada = cilindrada;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Cilindrada: {Cilindrada} cc");
    }
}
