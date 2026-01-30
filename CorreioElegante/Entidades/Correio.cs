namespace CorreioElegante.Entidades
{
    public class Correio
    {
        public long Id { get; set; }
        public string EmailRemetente { get; set; } = string.Empty;
        public string EmailDestinatario { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
    }
}
