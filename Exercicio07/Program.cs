using System;

    ContaCorrente contaCorrente = new ContaCorrente("João");
    contaCorrente.Depositar(1000);
    contaCorrente.Sacar(100);

    ContaPoupanca contaPoupanca = new ContaPoupanca("Maria");
    contaPoupanca.Depositar(2000);
    contaPoupanca.CalcularJuros(0.5);

    ContaEmpresarial contaEmpresarial = new ContaEmpresarial("Empresa XYZ");
    contaEmpresarial.Depositar(5000);
    contaEmpresarial.Sacar(1000);
