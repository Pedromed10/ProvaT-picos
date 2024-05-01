public class BoletoBancario : IMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Boleto bancário no valor de R${valor} gerado e pronto para pagamento.");
    }

    public string VerificarStatusPagamento()
    {
        return "Boleto bancário aguardando pagamento.";
    }
}
