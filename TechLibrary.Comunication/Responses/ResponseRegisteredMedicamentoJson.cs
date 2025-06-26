namespace TechLibrary.Comunication.Responses
{
    public class ResponseRegisteredMedicamentoJson
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade{ get; set; } = 0;
        public string Fornecedor { get; set; } = string.Empty;
        public string Validade { get; set; } = string.Empty;
    }
}
