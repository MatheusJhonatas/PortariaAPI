﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PortariaAPI.Migrations
{
    [DbContext(typeof(PortariaDataContext))]
    partial class PortariaDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentoRG")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("RG");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Rua");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Morador", (string)null);
                });

            modelBuilder.Entity("PortariaAPI.Models.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentoRG")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Rua");

                    b.Property<string>("Tipo")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Visitantes", (string)null);
                });

            modelBuilder.Entity("Porteiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentoRG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Nome");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Porteiro", (string)null);
                });

            modelBuilder.Entity("PrestadorServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentoRG")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Documento RG:");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Nome Prestador");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasMaxLength(140)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Numero");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Rua");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prestador", (string)null);
                });

            modelBuilder.Entity("Registro", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<int>("MoradorId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroCasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PorteiroId")
                        .HasColumnType("int");

                    b.Property<int>("PrestadorServicoId")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VisitanteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("horarioEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("horarioSaida")
                        .HasColumnType("datetime2");

                    b.HasKey("Numero");

                    b.HasIndex("MoradorId");

                    b.HasIndex("PorteiroId");

                    b.HasIndex("PrestadorServicoId");

                    b.HasIndex("VisitanteId");

                    b.ToTable("Registro", (string)null);
                });

            modelBuilder.Entity("Registro", b =>
                {
                    b.HasOne("Morador", "morador")
                        .WithMany("Registros")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Porteiro", null)
                        .WithMany("Registros")
                        .HasForeignKey("PorteiroId");

                    b.HasOne("PrestadorServico", "prestadorServico")
                        .WithMany("Registros")
                        .HasForeignKey("PrestadorServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortariaAPI.Models.Visitante", "visitante")
                        .WithMany("Registros")
                        .HasForeignKey("VisitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("morador");

                    b.Navigation("prestadorServico");

                    b.Navigation("visitante");
                });

            modelBuilder.Entity("Morador", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("PortariaAPI.Models.Visitante", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("Porteiro", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("PrestadorServico", b =>
                {
                    b.Navigation("Registros");
                });
#pragma warning restore 612, 618
        }
    }
}
