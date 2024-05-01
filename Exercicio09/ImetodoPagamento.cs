public interface IMetodoPagamento
{
    void RealizarPagamento(double valor);
    string VerificarStatusPagamento();
}
