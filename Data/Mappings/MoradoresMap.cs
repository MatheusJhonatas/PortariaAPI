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
        builder.HasMany(m => m.Registros)
            .WithOne(r => r.morador)
            .HasForeignKey(r => r.MoradorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.DocumentoRG)
        .IsRequired()
        .HasColumnName("RG")
        .HasColumnType("VARCHAR")
        .HasMaxLength(15);

        builder.Property(x => x.Rua)
        .IsRequired()
        .HasColumnName("Rua")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);
        builder.Property(c => c.NumeroCasa)
        .IsRequired()
        .HasColumnName("Numero")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        builder.Property(x => x.Tipo)
        .IsRequired();
    }
}
