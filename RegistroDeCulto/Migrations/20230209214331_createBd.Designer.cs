// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroDeCulto.Data;

#nullable disable

namespace RegistroDeCulto.Migrations
{
    [DbContext(typeof(RegistroDbContext))]
    [Migration("20230209214331_createBd")]
    partial class createBd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RegistroDeCulto.Models.Culto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Adultos")
                        .HasColumnType("int");

                    b.Property<string>("Avisos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BencaoApostolica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Criancas")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("datetime2");

                    b.Property<int>("HinosHarpa")
                        .HasColumnType("int");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("LouvorOfertas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oportunidades")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OracaoFinal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OracaoOfertas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OracaoOportunidades")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OracaoPreleitor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PalavraInicial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preleitor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Culto");
                });
#pragma warning restore 612, 618
        }
    }
}
