using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CorreioElegante.Entidades;

namespace CorreioElegante.Configs
{
    public class CorreioConfiguration : IEntityTypeConfiguration<Correio>
    {
        public void Configure(EntityTypeBuilder<Correio> builder)
        {
            // Nome da tabela
            builder.ToTable("Correios");

            // Chave primária
            builder.HasKey(c => c.Id);

            // Propriedades
            builder.Property(c => c.EmailRemetente)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.EmailDestinatario)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Mensagem)
                   .IsRequired()
                   .HasMaxLength(1000);
        }
    }
}
