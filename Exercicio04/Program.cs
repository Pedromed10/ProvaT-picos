using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("MacBook", 6000.0, 10);
        
        Console.WriteLine("Valor total em estoque: " + produto.CalcularValorTotalEmEstoque());

        produto.AdicionarAoEstoque(5);
        Console.WriteLine("Valor total em estoque após adição: " + produto.CalcularValorTotalEmEstoque());

        produto.RemoverDoEstoque(3);
        Console.WriteLine("Valor total em estoque após remoção: " + produto.CalcularValorTotalEmEstoque());
    }
}
