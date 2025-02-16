using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PorteirosMap : IEntityTypeConfiguration<Porteiro>
{
    public void Configure(EntityTypeBuilder<Porteiro> builder)
    {
        builder.ToTable("Porteiro");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

        builder.Property(x => x.Nome)
        .IsRequired()
        .HasColumnName("Nome")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(100);

        builder.HasMany(p => p.Registros)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
    }
}