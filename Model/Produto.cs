using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPizzaria.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public double Valor { get; set; }
    }
}
