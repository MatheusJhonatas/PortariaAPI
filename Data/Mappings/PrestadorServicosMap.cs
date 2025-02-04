
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class PrestadoresMap : IEntityTypeConfiguration<PrestadorServico>
{
    public void Configure(EntityTypeBuilder<PrestadorServico> builder)
    {
        builder.ToTable("Prestador");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

        builder.Property(c => c.Nome)
        .IsRequired()
        .HasColumnName("Nome Prestador")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);

        builder.Property(c => c.DocumentoRG)
        .IsRequired()
        .HasColumnName("Documento RG:")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(60);

        builder.Property(c => c.Rua)
        .IsRequired()
        .HasColumnName("Rua")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(50);
        builder.Property(c => c.NumeroCasa)
        .IsRequired()
        .HasColumnName("Numero")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(140);
        builder.Property(c => c.Tipo)
            .IsRequired()
            .HasMaxLength(50);


    }
}