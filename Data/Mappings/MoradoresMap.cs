using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MoradoresMap : IEntityTypeConfiguration<Morador>
{
    public void Configure(EntityTypeBuilder<Morador> builder)
    {
        builder.ToTable("Morador");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

        builder.Property(x => x.Nome)
        .IsRequired()
        .HasMaxLength(100);
        builder.HasMany(x => x.Autorizacoes)
        .WithOne(x => x.morador)
        .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.DocumentoRG)
        .IsRequired()
        .HasColumnName("RG")
        .HasColumnType("VARCHAR")
        .HasMaxLength(15);

        builder.Property(x => x.Endereco)
        .IsRequired()
        .HasColumnName("Endereço")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        builder.Property(x => x.Tipo)
        .IsRequired(false);
    }
}
