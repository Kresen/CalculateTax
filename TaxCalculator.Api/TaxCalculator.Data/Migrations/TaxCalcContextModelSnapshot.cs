﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxCalculator.Data.Contexts;

#nullable disable

namespace TaxCalculator.Data.Migrations
{
    [DbContext(typeof(TaxCalcContext))]
    partial class TaxCalcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaxCalculator.Domain.Entities.TaxRates", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("From")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("To")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("TaxRates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5172b7ac-6a68-4cf6-b822-19d1b1b39425"),
                            From = 0L,
                            Rate = 10m,
                            To = 8350L
                        },
                        new
                        {
                            Id = new Guid("3b37b24d-ff54-4eeb-8800-bc4f656a86df"),
                            From = 8351L,
                            Rate = 15m,
                            To = 33950L
                        },
                        new
                        {
                            Id = new Guid("3a6119ff-3589-4d5f-a1a6-03f492e94196"),
                            From = 33951L,
                            Rate = 25m,
                            To = 82250L
                        },
                        new
                        {
                            Id = new Guid("d1ef54af-554d-472e-b81a-3beb257e9bcb"),
                            From = 82251L,
                            Rate = 28m,
                            To = 171550L
                        },
                        new
                        {
                            Id = new Guid("c30ce708-5802-4d64-8a9e-d5877e41b02c"),
                            From = 171551L,
                            Rate = 33m,
                            To = 372950L
                        },
                        new
                        {
                            Id = new Guid("bae588b4-14d1-4c09-83e8-9a925da0a5a5"),
                            From = 372951L,
                            Rate = 35m,
                            To = 9223372036854775807L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}