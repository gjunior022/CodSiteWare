//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaVirtual.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KitPromocao
    {
        public int codProduto { get; set; }
        public int codPromocao { get; set; }
        public string descricao { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}