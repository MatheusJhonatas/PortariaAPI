using Microsoft.EntityFrameworkCore;
using PortariaAPI.Models;
public class PortariaDataContext : DbContext
{
    public DbSet<Porteiro> Porteiros { get; set; }
    public DbSet<Morador> Moradores { get; set; }
    public DbSet<Visitante> Visitantes { get; set; }
    public DbSet<Registro> Registros { get; set; }
    public DbSet<PrestadorServico> PrestadorServicos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Portaria;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new PorteirosMap());
        modelBuilder.ApplyConfiguration(new MoradoresMap());
        //modelBuilder.ApplyConfiguration(new VisitantesMap());
        // modelBuilder.ApplyConfiguration(new RegistrosMap());
        modelBuilder.ApplyConfiguration(new PrestadoresMap());

        modelBuilder.Entity<Registro>()
            .HasOne(r => r.visitante)
            .WithMany(v => v.Registros)
            .HasForeignKey(r => r.VisitanteId);

        modelBuilder.Entity<Registro>()
            .HasOne(r => r.morador)
            .WithMany(m => m.Registros)
            .HasForeignKey(r => r.moradorId);
        modelBuilder.Entity<Registro>()
        .HasOne(r => r.prestadorServico)
        .WithMany(p => p.Registros)
        .HasForeignKey(h => h.PrestadorServicoId);

    }
}