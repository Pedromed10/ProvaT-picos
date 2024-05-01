using System;

class Program
{
    static void Main(string[] args)
    {
        IMetodoPagamento cartaoCredito = new CartaoCredito();
        IMetodoPagamento paypal = new PayPal();
        IMetodoPagamento transferenciaBancaria = new TransferenciaBancaria();

        ProcessarPagamento(cartaoCredito);
        ProcessarPagamento(paypal);
        ProcessarPagamento(transferenciaBancaria);
    }

    static void ProcessarPagamento(IMetodoPagamento metodoPagamento)
    {
        Console.WriteLine("Processando pagamento...");
        metodoPagamento.ProcessarPagamento();
        Console.WriteLine("Pagamento processado com sucesso!\n");
    }
}
