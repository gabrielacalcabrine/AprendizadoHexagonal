﻿using AplicacaoHexagonal.Domain.Entities;
using AplicacaoHexagonal.Domain.Interfaces;

namespace AplicacaoHexagonal.Repository
{
    internal class PagamentoRepositorySqlServer : IPagamentoRepository
    {
        public Task BuscarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task SalvarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
