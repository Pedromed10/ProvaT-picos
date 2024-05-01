using System; 

    Carro carro = new Carro("Audi", "RS6", 2020, 4);
    Moto moto = new Moto("BMW", "S1000RR", 2021, 1000);
    Bicicleta bicicleta = new Bicicleta("Caloi", "Elite", 2019, 21);

    Console.WriteLine("Informações do Carro:");
    carro.ExibirInformacoes();

    Console.WriteLine("\nInformações da Moto:");
    moto.ExibirInformacoes();

    Console.WriteLine("\nInformações da Bicicleta:");
    bicicleta.ExibirInformacoes();
