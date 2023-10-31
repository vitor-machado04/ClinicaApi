﻿// <auto-generated />
using System;
using ClinicaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicaAPI.Migrations
{
    [DbContext(typeof(ClinicaDbContext))]
    [Migration("20231005233045_FixedRelationships")]
    partial class FixedRelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ClinicaAPI.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataHora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Razao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Prontuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataCriacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PacienteId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tratamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Prontuario");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataEmissao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dosagem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdMedico")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InstrucoesUso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Medicamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Consulta", b =>
                {
                    b.HasOne("ClinicaAPI.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicaAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Exame", b =>
                {
                    b.HasOne("ClinicaAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Prontuario", b =>
                {
                    b.HasOne("ClinicaAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ClinicaAPI.Models.Receita", b =>
                {
                    b.HasOne("ClinicaAPI.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });
#pragma warning restore 612, 618
        }
    }
}
