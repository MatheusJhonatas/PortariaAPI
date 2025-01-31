using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RegistrosMap : IEntityTypeConfiguration<Registro>
{
    public void Configure(EntityTypeBuilder<Registro> builder)
    {
        builder.ToTable("Registro");

        builder.HasKey(c => c.Numero);
        builder.Property(c => c.horarioEntrada)
        .IsRequired();
        builder.Property(c => c.horarioSaida)
        .IsRequired(false);
        builder.Property(c => c.Status)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(c => c.visitante)
        .WithMany(v => v.Registros)
        .HasForeignKey(c => c.VisitanteId);

        builder.HasOne(e => e.morador)
        .WithMany(m => m.Registros)
        .HasForeignKey(e => e.moradorId);

        builder.HasOne(h => h.prestadorServico)
        .WithMany(p => p.Registros)
        .HasForeignKey(e => e.PrestadorServicoId);


    }
}