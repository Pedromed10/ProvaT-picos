using System;

    IMetodoPagamento cartaoCredito = new CartaoCredito();
    IMetodoPagamento boletoBancario = new BoletoBancario();
    IMetodoPagamento transferenciaBancaria = new TransferenciaBancaria();

    RealizarPagamento(cartaoCredito, 100.00);
    RealizarPagamento(boletoBancario, 50.00);
    RealizarPagamento(transferenciaBancaria, 200.00);


    static void RealizarPagamento(IMetodoPagamento metodoPagamento, double valor)
    {
    metodoPagamento.RealizarPagamento(valor);

    string statusPagamento = metodoPagamento.VerificarStatusPagamento();
    Console.WriteLine($"Status do pagamento: {statusPagamento}");

    Console.WriteLine();
    }

