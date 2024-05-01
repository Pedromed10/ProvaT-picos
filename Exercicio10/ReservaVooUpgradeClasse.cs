public class ReservaVooUpgradeClasse : IReserva
{
    private string _numeroVoo;

    public void ReservarVoo(string numeroVoo)
    {
        _numeroVoo = numeroVoo;
        Console.WriteLine($"Reserva com upgrade de classe confirmada para o voo {numeroVoo}.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva com upgrade de classe cancelada.");
        _numeroVoo = null;
    }

    public string VerificarStatusReserva()
    {
        return _numeroVoo != null ? "Reserva com upgrade de classe confirmada" : "Sem reserva";
    }
}
