using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransShop.Domain.Models
{
    public class Produtos
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public string FotoUrl { get; set; }
    }
}
