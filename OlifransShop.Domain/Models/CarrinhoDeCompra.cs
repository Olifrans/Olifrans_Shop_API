using System;
using System.Collections.Generic;
using System.Text;

namespace OlifransShop.Domain.Models
{
    public class CarrinhoDeCompra
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        public double Precototal { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
