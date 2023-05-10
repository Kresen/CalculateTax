using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaxCalculator.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<long>(type: "bigint", nullable: false),
                    To = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "From", "Rate", "To" },
                values: new object[,]
                {
                    { new Guid("070a5228-2949-4c4a-8f68-16b5a248e6fa"), 8351L, 15, 33950L },
                    { new Guid("28d25c47-02cf-4dd2-98a5-e78f3d4b9eae"), 0L, 10, 8350L },
                    { new Guid("b48e82ad-7893-427e-b10e-011edccaf36a"), 171551L, 33, 372950L },
                    { new Guid("cef4622a-f7cd-4b40-9a7f-cd224fb046bb"), 33951L, 25, 82250L },
                    { new Guid("ee02a390-afb0-401d-b8d9-7b8643920b31"), 82251L, 28, 171550L },
                    { new Guid("fc909f36-23fd-4387-90e8-3c8b97ea8c6a"), 372951L, 35, 9223372036854775807L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxRates");
        }
    }
}
