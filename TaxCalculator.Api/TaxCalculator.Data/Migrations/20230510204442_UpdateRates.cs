using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaxCalculator.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("070a5228-2949-4c4a-8f68-16b5a248e6fa"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("28d25c47-02cf-4dd2-98a5-e78f3d4b9eae"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("b48e82ad-7893-427e-b10e-011edccaf36a"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("cef4622a-f7cd-4b40-9a7f-cd224fb046bb"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("ee02a390-afb0-401d-b8d9-7b8643920b31"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("fc909f36-23fd-4387-90e8-3c8b97ea8c6a"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "TaxRates",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "TaxRates",
                columns: new[] { "Id", "From", "Rate", "To" },
                values: new object[,]
                {
                    { new Guid("3a6119ff-3589-4d5f-a1a6-03f492e94196"), 33951L, 25m, 82250L },
                    { new Guid("3b37b24d-ff54-4eeb-8800-bc4f656a86df"), 8351L, 15m, 33950L },
                    { new Guid("5172b7ac-6a68-4cf6-b822-19d1b1b39425"), 0L, 10m, 8350L },
                    { new Guid("bae588b4-14d1-4c09-83e8-9a925da0a5a5"), 372951L, 35m, 9223372036854775807L },
                    { new Guid("c30ce708-5802-4d64-8a9e-d5877e41b02c"), 171551L, 33m, 372950L },
                    { new Guid("d1ef54af-554d-472e-b81a-3beb257e9bcb"), 82251L, 28m, 171550L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("3a6119ff-3589-4d5f-a1a6-03f492e94196"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("3b37b24d-ff54-4eeb-8800-bc4f656a86df"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("5172b7ac-6a68-4cf6-b822-19d1b1b39425"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("bae588b4-14d1-4c09-83e8-9a925da0a5a5"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("c30ce708-5802-4d64-8a9e-d5877e41b02c"));

            migrationBuilder.DeleteData(
                table: "TaxRates",
                keyColumn: "Id",
                keyValue: new Guid("d1ef54af-554d-472e-b81a-3beb257e9bcb"));

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "TaxRates",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
