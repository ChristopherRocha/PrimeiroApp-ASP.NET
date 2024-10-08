﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoGerenciarTarefas.Contexts;

#nullable disable

namespace ProjetoGerenciarTarefas.Migrations
{
    [DbContext(typeof(Contextos))]
    [Migration("20240820040613_CreateParaFazerTable")]
    partial class CreateParaFazerTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ProjetoGerenciarTarefas.Models.ParaFazer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DataFinalicao")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DataLimite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("aFazeres");
                });
#pragma warning restore 612, 618
        }
    }
}
