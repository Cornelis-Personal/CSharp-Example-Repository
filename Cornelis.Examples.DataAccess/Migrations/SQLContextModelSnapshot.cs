﻿// <auto-generated />
using System;
using Cornelis.Examples.DataAccess.DataContexts.SQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cornelis.Examples.DataAccess.Migrations
{
    [DbContext(typeof(SQLContext))]
    partial class SQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cornelis.Examples.Models.Data.Animal", b =>
                {
                    b.Property<string>("Rfid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AnimalPlantHistoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("BodyNumber")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HumpHeight")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KillDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ossification")
                        .HasColumnType("int");

                    b.HasKey("Rfid");

                    b.HasIndex("AnimalPlantHistoryId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.AnimalPlantHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rfid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TransferDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AnimalPlantHistory");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalPlantHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalPlantHistoryId");

                    b.ToTable("Plant");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.Animal", b =>
                {
                    b.HasOne("Cornelis.Examples.Models.Data.AnimalPlantHistory", null)
                        .WithMany("Animals")
                        .HasForeignKey("AnimalPlantHistoryId");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.Plant", b =>
                {
                    b.HasOne("Cornelis.Examples.Models.Data.AnimalPlantHistory", null)
                        .WithMany("Plants")
                        .HasForeignKey("AnimalPlantHistoryId");
                });

            modelBuilder.Entity("Cornelis.Examples.Models.Data.AnimalPlantHistory", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}
