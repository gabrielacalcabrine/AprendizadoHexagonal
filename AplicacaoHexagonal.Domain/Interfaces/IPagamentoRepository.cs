using AplicacaoHexagonal.Domain.Entities;

namespace AplicacaoHexagonal.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task SalvarPagamento(Pagamento pagamento);
        Task BuscarPagamento(Pagamento pagamento);
    }
}
