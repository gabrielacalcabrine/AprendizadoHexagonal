namespace AplicacaoHexagonal.Domain.Entities
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public DateTime diasPesquisa { get; set; }
        public Recebedor recebedor { get; set; }
        public Pagador pagador { get; set; }
    }
}
