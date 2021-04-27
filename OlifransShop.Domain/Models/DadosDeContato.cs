namespace OlifransShop.Domain.Models
{
    public class DadosDeContato
    {
        public int Id { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public int ClienteId { get; set; }
    }
}