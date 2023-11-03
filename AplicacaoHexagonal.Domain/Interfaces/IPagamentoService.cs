using AplicacaoHexagonal.Domain.Entities;

namespace AplicacaoHexagonal.Domain.Interfaces
{
    public interface IPagamentoService
    {
        Task VerificarPagamento(Pagamento pagamento);
        Task Pagar(Pagamento pagamento);
    }
}
