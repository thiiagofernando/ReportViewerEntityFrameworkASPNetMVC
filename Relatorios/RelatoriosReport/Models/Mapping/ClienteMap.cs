using System.Data.Entity.ModelConfiguration;

namespace RelatoriosReport.Models.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.HasKey(t => t.ClienteId);
            this.Property(t => t.Nome).IsRequired().HasMaxLength(200);

            this.ToTable("Cliente");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}