using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortariaAPI.Models;

public class VisitantesMap : IEntityTypeConfiguration<Visitante>
{
    public void Configure(EntityTypeBuilder<Visitante> builder)
    {
        builder.ToTable("Visitantes");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nome)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(c => c.DocumentoRG)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(c => c.Endereco)
        .IsRequired()
        .HasColumnType("NVARCHAR")
        .HasMaxLength(140);
        builder.Property(c => c.Tipo)
            .IsRequired(false)
            .HasMaxLength(50);


    }
}