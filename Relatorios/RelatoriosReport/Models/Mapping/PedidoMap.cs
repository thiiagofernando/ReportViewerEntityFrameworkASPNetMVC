using System.Data.Entity.ModelConfiguration;
namespace RelatoriosReport.Models.Mapping
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            this.HasKey(t => t.PedidoId);
            this.Property(t => t.ClienteId).IsRequired();
            this.Property(t => t.DataPedido).IsRequired();

            this.ToTable("Pedido");
            this.Property(t => t.PedidoId).HasColumnName("PedidoId");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");
            this.Property(t => t.DataPedido).HasColumnName("DataPedido");

        }
    }
}