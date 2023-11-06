using AplicacaoHexagonal.Domain.ValueObject;

namespace AplicacaoHexagonal.Domain.Entities
{
    public class Recebedor
    {
        public Guid Id { get; set; }
        public CPF Cpf { get; set; }
        public string ChavePix { get; set; }
        //Pode ser um value object?
    }
}
