namespace CorreioElegante.Dtos
{
    public class SalvarCorreioDto
    {
        public string EmailRemetente { get; set; } = string.Empty;
        public string EmailDestinatario { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
    }
}
