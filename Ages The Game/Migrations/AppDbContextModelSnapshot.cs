﻿// <auto-generated />
using System;
using Ages_The_Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ages_The_Game.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ages_The_Game.Models.ImagensModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Ano")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Base64Imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Continente")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Dica1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Dica2")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Dica3")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int>("IDDaLista")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IDDaLista");

                    b.ToTable("ItensDaLista");
                });

            modelBuilder.Entity("Ages_The_Game.Models.ListaImagensModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lista");
                });

            modelBuilder.Entity("Ages_The_Game.Models.ImagensModels", b =>
                {
                    b.HasOne("Ages_The_Game.Models.ListaImagensModels", null)
                        .WithMany("ImagemDoDia")
                        .HasForeignKey("IDDaLista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ages_The_Game.Models.ListaImagensModels", b =>
                {
                    b.Navigation("ImagemDoDia");
                });
#pragma warning restore 612, 618
        }
    }
}
