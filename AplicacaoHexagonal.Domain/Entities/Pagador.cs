using AplicacaoHexagonal.Domain.ValueObject;

namespace AplicacaoHexagonal.Domain.Entities
{
    public class Pagador
    {
        public Guid Id { get; set; }
        public CNPJ Cnpj { get; set; }
        public string ChavePix { get; set; }
        //Pode ser um value object?
    }
}
