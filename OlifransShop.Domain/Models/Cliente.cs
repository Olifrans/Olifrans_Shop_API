using System.Collections.Generic;

namespace OlifransShop.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public Nome Nome { get; set; }

        public long Ssn { get; set; }

        public ICollection<DadosDeContato> DadosDeContato { get; set; }

        public string NomeUsuario { get; set; }
    }
}