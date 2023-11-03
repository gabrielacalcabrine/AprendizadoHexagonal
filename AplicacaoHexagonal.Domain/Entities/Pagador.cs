using AplicacaoHexagonal.Domain.ValueObject;

namespace AplicacaoHexagonal.Domain.Entities
{
    public class Pagador
    {
        public CNPJ Cnpj { get; set; }
        public string ChavePix { get; set; }
    }
}
