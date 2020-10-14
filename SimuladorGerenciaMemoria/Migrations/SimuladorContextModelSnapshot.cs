﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimuladorGerenciaMemoria;

namespace SimuladorGerenciaMemoria.Migrations
{
    [DbContext(typeof(SimuladorContext))]
    partial class SimuladorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimuladorGerenciaMemoria.Models.Frame", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProcessID")
                        .HasColumnType("int");

                    b.Property<long>("RegB")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("MemoryID");

                    b.HasIndex("ProcessID");

                    b.ToTable("Frames");
                });

            modelBuilder.Entity("SimuladorGerenciaMemoria.Models.Memory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("FramesQTD")
                        .HasColumnType("bigint");

                    b.Property<long>("FramesSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Memories");
                });

            modelBuilder.Entity("SimuladorGerenciaMemoria.Models.Process", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RegB")
                        .HasColumnType("bigint");

                    b.Property<long>("RegL")
                        .HasColumnType("bigint");

                    b.Property<double>("TimeToFindIndex")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("SimuladorGerenciaMemoria.Models.Simulation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Simulations");
                });

            modelBuilder.Entity("SimuladorGerenciaMemoria.Models.Frame", b =>
                {
                    b.HasOne("SimuladorGerenciaMemoria.Models.Memory", null)
                        .WithMany("Frames")
                        .HasForeignKey("MemoryID");

                    b.HasOne("SimuladorGerenciaMemoria.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID");
                });
#pragma warning restore 612, 618
        }
    }
}
