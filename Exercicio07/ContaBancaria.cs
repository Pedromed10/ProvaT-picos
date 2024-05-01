using System;

class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; protected set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositado: {valor:C}. Novo saldo: {Saldo:C}");
    }

    public virtual void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Sacado: {valor:C}. Novo saldo: {Saldo:C}");
        }
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular}, Saldo: {Saldo:C}");
    }
}
