public class TransferenciaBancaria : IMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Transferência bancária no valor de R${valor} realizada com sucesso.");
    }

    public string VerificarStatusPagamento()
    {
        return "Transferência bancária confirmada.";
    }
}
