using System;

class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}
