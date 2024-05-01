using System;

    CursoIngles inglesBasico = new CursoIngles("Inglês Básico", 6);
    inglesBasico.AdicionarNota(7.5);
    inglesBasico.AdicionarNota(8.0);

    CursoEspanhol espanholIntermediario = new CursoEspanhol("Espanhol Intermediário", 8);
    espanholIntermediario.AdicionarNota(6.5);
    espanholIntermediario.AdicionarNota(7.0);

    CursoFrances francesAvancado = new CursoFrances("Francês Avançado", 12);
    francesAvancado.AdicionarNota(8.5);
    francesAvancado.AdicionarNota(9.0);

    Console.WriteLine($"Média do curso de Francês: {francesAvancado.CalcularMedia()}");

    inglesBasico.GerarCertificado();
    espanholIntermediario.GerarCertificado();
    francesAvancado.GerarCertificado();
