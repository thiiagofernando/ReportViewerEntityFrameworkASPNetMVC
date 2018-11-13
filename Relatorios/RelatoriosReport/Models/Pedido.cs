using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelatoriosReport.Models
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
    }
}