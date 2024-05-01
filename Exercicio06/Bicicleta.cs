using System;

class Bicicleta : Veiculo
{
    public int NumeroMarchas { get; set; }

    public Bicicleta(string marca, string modelo, int ano, int numeroMarchas)
        : base(marca, modelo, ano)
    {
        NumeroMarchas = numeroMarchas;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Número de marchas: {NumeroMarchas}");
    }
}
