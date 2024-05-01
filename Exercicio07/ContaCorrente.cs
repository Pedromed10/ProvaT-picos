using System;

class ContaCorrente : ContaBancaria
{
    public ContaCorrente(string titular) : base(titular)
    {
    }

    public override void Sacar(double valor)
    {
        const double taxaSaque = 0.05; 
        double valorComTaxa = valor * (1 + taxaSaque);
        base.Sacar(valorComTaxa);
    }
}
