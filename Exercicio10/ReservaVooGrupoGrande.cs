public class ReservaVooGrupoGrande : IReserva
{
    private string _numeroVoo;

    public void ReservarVoo(string numeroVoo)
    {
        _numeroVoo = numeroVoo;
        Console.WriteLine($"Reserva para grupo grande confirmada para o voo {numeroVoo}.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva para grupo grande cancelada.");
        _numeroVoo = null;
    }

    public string VerificarStatusReserva()
    {
        return _numeroVoo != null ? "Reserva para grupo grande confirmada" : "Sem reserva";
    }
}

