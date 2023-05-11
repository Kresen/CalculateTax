﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxCalculator.Data.Contexts;

#nullable disable

namespace TaxCalculator.Data.Migrations
{
    [DbContext(typeof(TaxCalcContext))]
    [Migration("20230511110744_SalaryTax")]
    partial class SalaryTax
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaxCalculator.Domain.Entities.SalaryTax", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("AnnualSalary")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SalaryTax");
                });

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
                            Id = new Guid("34a2f91b-b2d0-4fff-a67c-4cf12b9f3815"),
                            From = 0L,
                            Rate = 10m,
                            To = 8350L
                        },
                        new
                        {
                            Id = new Guid("23b2e008-c015-487b-a07c-b0d6ab095cde"),
                            From = 8351L,
                            Rate = 15m,
                            To = 33950L
                        },
                        new
                        {
                            Id = new Guid("5d0ea1a8-635f-4fa8-8417-f322723a9e99"),
                            From = 33951L,
                            Rate = 25m,
                            To = 82250L
                        },
                        new
                        {
                            Id = new Guid("b7115c5e-4193-4494-89a1-3e1de2768010"),
                            From = 82251L,
                            Rate = 28m,
                            To = 171550L
                        },
                        new
                        {
                            Id = new Guid("3f4a4abf-7351-4df2-9fe8-d1af8eca70dd"),
                            From = 171551L,
                            Rate = 33m,
                            To = 372950L
                        },
                        new
                        {
                            Id = new Guid("328f3f30-bb4e-4a77-a193-4b5701c9daf5"),
                            From = 372951L,
                            Rate = 35m,
                            To = 9223372036854775807L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
