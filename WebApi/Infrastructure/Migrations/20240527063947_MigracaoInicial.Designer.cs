﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(KnightsContext))]
    [Migration("20240527063947_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Attributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("charisma")
                        .HasColumnType("int");

                    b.Property<int>("constitution")
                        .HasColumnType("int");

                    b.Property<int>("dexterity")
                        .HasColumnType("int");

                    b.Property<int>("intelligence")
                        .HasColumnType("int");

                    b.Property<int>("strength")
                        .HasColumnType("int");

                    b.Property<int>("wisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("Domain.Entities.Knight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttributesId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Birthday")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsHero")
                        .HasColumnType("bit");

                    b.Property<string>("KeyAttribute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttributesId");

                    b.ToTable("Knights");
                });

            modelBuilder.Entity("Domain.Entities.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Equipped")
                        .HasColumnType("bit");

                    b.Property<int?>("KnightId")
                        .HasColumnType("int");

                    b.Property<int>("Mod")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KnightId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Domain.Entities.Knight", b =>
                {
                    b.HasOne("Domain.Entities.Attributes", "Attributes")
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attributes");
                });

            modelBuilder.Entity("Domain.Entities.Weapon", b =>
                {
                    b.HasOne("Domain.Entities.Knight", null)
                        .WithMany("Weapons")
                        .HasForeignKey("KnightId");
                });

            modelBuilder.Entity("Domain.Entities.Knight", b =>
                {
                    b.Navigation("Weapons");
                });
#pragma warning restore 612, 618
        }
    }
}
