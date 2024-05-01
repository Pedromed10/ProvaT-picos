using System;
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarAoEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
        }
    }

    public void RemoverDoEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} removidas do estoque.");
        }
        else if (quantidade > QuantidadeEmEstoque)
        {
            Console.WriteLine($"Não é possível remover {quantidade} unidades. Estoque insuficiente.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
        }
    }

    public double CalcularValorTotalEmEstoque()
    {
        return Preco * QuantidadeEmEstoque;
    }
}
