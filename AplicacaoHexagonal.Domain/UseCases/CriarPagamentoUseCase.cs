using AplicacaoHexagonal.Domain.Contracts;
using AplicacaoHexagonal.Domain.Interfaces;
using System;

namespace AplicacaoHexagonal.Domain.UseCases
{  
    public class CriarPagamentoUseCase : IUseCase<CriarPagamentoRequest, CriarPagamentoResponse>
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IPagamentoService _pagamentoService;

        public CriarPagamentoUseCase(IPagamentoRepository pagamentoRepository, IPagamentoService pagamentoService)
        {
            _pagamentoRepository = pagamentoRepository;
            _pagamentoService = pagamentoService;
        }

        public Task<CriarPagamentoResponse> Execute(CriarPagamentoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
