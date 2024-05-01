using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias dos diferentes métodos de pagamento
        IMetodoPagamento cartaoCredito = new CartaoCredito();
        IMetodoPagamento boletoBancario = new BoletoBancario();
        IMetodoPagamento transferenciaBancaria = new TransferenciaBancaria();

        // Realizando pagamentos
        RealizarPagamento(cartaoCredito, 100.00);
        RealizarPagamento(boletoBancario, 50.00);
        RealizarPagamento(transferenciaBancaria, 200.00);
    }

    static void RealizarPagamento(IMetodoPagamento metodoPagamento, double valor)
    {
        // Realizando o pagamento com o método específico
        metodoPagamento.RealizarPagamento(valor);

        // Verificando o status do pagamento
        string statusPagamento = metodoPagamento.VerificarStatusPagamento();
        Console.WriteLine($"Status do pagamento: {statusPagamento}");

        Console.WriteLine();
    }
}
