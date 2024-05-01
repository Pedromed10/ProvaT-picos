using System;

class Program
{
    static void Main(string[] args)
    {
        IReserva reservaRegular = new ReservaVooRegular();
        IReserva reservaUpgradeClasse = new ReservaVooUpgradeClasse();
        IReserva reservaGrupoGrande = new ReservaVooGrupoGrande();

        ReservarVoo(reservaRegular, "123");
        ReservarVoo(reservaUpgradeClasse, "456");
        ReservarVoo(reservaGrupoGrande, "789");

        CancelarReserva(reservaRegular);
        CancelarReserva(reservaUpgradeClasse);
        CancelarReserva(reservaGrupoGrande);
    }

    static void ReservarVoo(IReserva reserva, string numeroVoo)
    {
        reserva.ReservarVoo(numeroVoo);
        Console.WriteLine($"Status da reserva: {reserva.VerificarStatusReserva()}");
        Console.WriteLine();
    }

    static void CancelarReserva(IReserva reserva)
    {
        reserva.CancelarReserva();
        Console.WriteLine($"Status da reserva: {reserva.VerificarStatusReserva()}");
        Console.WriteLine();
    }
}
