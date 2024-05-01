public class CursoIngles : Curso
{
    public CursoIngles(string nome, int duracao) : base(nome, duracao)
    {
    }

    public override double CalcularMedia()
    {
        if (Notas.Count == 0)
            return 0;

        double soma = 0;
        foreach (var nota in Notas)
        {
            soma += nota;
        }
        return soma / Notas.Count;
    }

    public override void GerarCertificado()
    {
        if (CalcularMedia() >= 7)
            Console.WriteLine($"Certificado de conclusão do curso de Inglês: {Nome}");
        else
            Console.WriteLine($"Aluno não atendeu aos requisitos para o certificado do curso de Inglês: {Nome}");
    }
}
