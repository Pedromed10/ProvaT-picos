using System;

class ContaEmpresarial : ContaBancaria
{
    public ContaEmpresarial(string titular) : base(titular)
    {
    }

    public override void Sacar(double valor)
    {
        const double saldoMinimo = 1000;
        if (Saldo - valor < saldoMinimo)
        {
            Console.WriteLine($"Saldo mínimo não pode ser ultrapassado. Saldo mínimo: {saldoMinimo:C}");
        }
        else
        {
            base.Sacar(valor);
        }
    }
}
