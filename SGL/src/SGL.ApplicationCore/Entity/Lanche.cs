using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.ApplicationCore.Entity
{
   public class Lanche
    {
        public Lanche()
        {

        }
        public int LancheId { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
