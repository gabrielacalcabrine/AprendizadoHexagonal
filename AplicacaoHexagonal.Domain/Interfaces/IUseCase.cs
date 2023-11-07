namespace AplicacaoHexagonal.Domain.Interfaces
{
    public interface IUseCase<TRequest, TResponse> 
    {
        Task<TResponse> Execute(TRequest request);
    }
}
