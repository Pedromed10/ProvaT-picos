using System;

class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(string titular) : base(titular)
    {
    }

    public void CalcularJuros(double taxa)
    {
        double juros = Saldo * taxa / 100;
        Saldo += juros;
        Console.WriteLine($"Juros calculados: {juros:C}. Novo saldo: {Saldo:C}");
    }
}
