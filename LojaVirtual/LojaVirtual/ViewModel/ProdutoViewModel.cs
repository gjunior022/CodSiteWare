using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.ViewModel
{
    public class ProdutoViewModel
    {
        public int quantidade { get; set; }

        public decimal preco { get; set; }

        public string nomePromocao { get; set; }

        public string nomeProduto { get; set; }
    }
}