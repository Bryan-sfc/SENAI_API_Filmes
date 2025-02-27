﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_filmes_senai.Context;

#nullable disable

namespace api_filmes_senai.Migrations
{
    [DbContext(typeof(Filmes_Context))]
    [Migration("20250218184529_Db_Context")]
    partial class Db_Context
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api_filmes_senai.Domains.Filme", b =>
                {
                    b.Property<Guid>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGenero")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdFilme");

                    b.HasIndex("IdGenero");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("api_filmes_senai.Domains.Genero", b =>
                {
                    b.Property<Guid>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("IdGenero");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("api_filmes_senai.Domains.Filme", b =>
                {
                    b.HasOne("api_filmes_senai.Domains.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
