namespace Api.Application.Security
{
    public class TokenConfigurations
    {
        public string Issuer { get; set; } //Emissor
        public string Audience { get; set; } //Destinatário
        public int Seconds { get; set; } //Tempo de validade
    }
}
