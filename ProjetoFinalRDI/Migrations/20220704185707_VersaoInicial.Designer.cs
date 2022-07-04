﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalRDI.Context;

#nullable disable

namespace ProjetoFinalRDI.Migrations
{
    [DbContext(typeof(ProjetoFinalContext))]
    [Migration("20220704185707_VersaoInicial")]
    partial class VersaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalRDI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("dataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("sexo");

                    b.Property<int>("TotalFaltas")
                        .HasColumnType("int")
                        .HasColumnName("totalFaltas");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurmaId");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("ProjetoFinalRDI.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("Turmas", (string)null);
                });

            modelBuilder.Entity("ProjetoFinalRDI.Models.Aluno", b =>
                {
                    b.HasOne("ProjetoFinalRDI.Models.Turma", "Turma")
                        .WithMany("Aluno")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("ProjetoFinalRDI.Models.Turma", b =>
                {
                    b.Navigation("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}