namespace TechLibrary.Api.Domain.Entities
{
    public class Medicamento
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Fornecedor { get; set; }
        public string Nome { get; set; }
        public string Validade { get; set; }
        public int Quantidade { get; set; }
    }
}
