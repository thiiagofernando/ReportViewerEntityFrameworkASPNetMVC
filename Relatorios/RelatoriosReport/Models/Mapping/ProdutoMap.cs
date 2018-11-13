using System.Data.Entity.ModelConfiguration;

namespace RelatoriosReport.Models.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.HasKey(t => t.ProdutoId);
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(200);
            this.Property(t => t.Preco).IsRequired();

            this.ToTable("Produto");
            this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Preco).HasColumnName("Preco");

        }
    }
}