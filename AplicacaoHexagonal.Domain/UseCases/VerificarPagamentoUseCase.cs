using AplicacaoHexagonal.Domain.Contracts;
using AplicacaoHexagonal.Domain.Interfaces;

namespace AplicacaoHexagonal.Domain.UseCases
{
    public class VerificarPagamentoUseCase : IUseCase<CriarPagamentoRequest, CriarPagamentoResponse>
    {
        public Task<CriarPagamentoResponse> Execute(CriarPagamentoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
