using System.Data.Entity.ModelConfiguration;

namespace RelatoriosReport.Models
{
    public class ItemPedidoMap : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMap()
        {
            this.HasKey(t => t.ItemPedidoId);
            this.Property(t => t.PedidoId).IsRequired();
            this.Property(t => t.ProdutoId).IsRequired();
            this.Property(t => t.Quantidade).IsRequired();
            this.Property(t => t.ValorTotal).IsRequired();

            this.ToTable("ItemPedido");
            this.Property(t => t.ItemPedidoId).HasColumnName("ItemPedidoId");
            this.Property(t => t.PedidoId).HasColumnName("PedidoId");
            this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorTotal).HasColumnName("ValorTotal");

        }
    }
}