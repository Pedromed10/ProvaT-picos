public class ReservaVooRegular : IReserva
{
    private string _numeroVoo;

    public void ReservarVoo(string numeroVoo)
    {
        _numeroVoo = numeroVoo;
        Console.WriteLine($"Reserva confirmada para o voo regular {numeroVoo}.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo regular cancelada.");
        _numeroVoo = null;
    }

    public string VerificarStatusReserva()
    {
        return _numeroVoo != null ? "Reserva confirmada" : "Sem reserva";
    }
}
