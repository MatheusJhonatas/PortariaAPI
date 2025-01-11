using Microsoft.EntityFrameworkCore;
using PortariaAPI.Models;

public class PortariaDataContext : DbContext
{
    public DbSet<Visitante> Visitantes { get; set; }
    public DbSet<Registro> Registros { get; set; }
    public DbSet<PrestadorServico> PrestadorServicos { get; set; }
    // public DbSet<FuncionarioPortaria> FuncionarioPortarias { get; set; }
    // public DbSet<Portaria> Portarias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Portaria;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
    }
}