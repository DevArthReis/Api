
namespace TechLibrary.Comunication.Requests
{
    public class RequestMedicamentoJson
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 0;
        public string Fornecedor { get; set; } = string.Empty;
        public string Validade { get; set; }
    }
}
