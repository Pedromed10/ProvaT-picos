public class CartaoCredito : IMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado com sucesso via cartão de crédito.");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamento com cartão de crédito processado.";
    }
}
