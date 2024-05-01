using System;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("Soma de 2 e 3: " + calc.Somar(2, 3));
        Console.WriteLine("Soma de 2, 3 e 4: " + calc.Somar(2, 3, 4));
        Console.WriteLine("Soma de 2.5 e 3.7: " + calc.Somar(2.5, 3.7));

        Console.WriteLine();

        Animal animal = new Animal();
        Animal cachorro = new Cachorro();
        Animal gato = new Gato();

        animal.EmitirSom(); 
        cachorro.EmitirSom(); 
        gato.EmitirSom(); 
    }
}
