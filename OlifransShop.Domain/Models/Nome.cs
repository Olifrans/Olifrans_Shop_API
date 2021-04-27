using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransShop.Domain.Models
{
    public class Nome
    {
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }

        public string SegundoNome { get; set; }

        public string Iniciais { get; set; }
    }
}
