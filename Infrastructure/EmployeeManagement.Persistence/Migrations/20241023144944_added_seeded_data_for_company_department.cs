using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Persistence.Migrations
{
    public partial class added_seeded_data_for_company_department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8542), "Microsoft" },
                    { 2, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8548), "Amazon" },
                    { 3, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8549), "Google" },
                    { 4, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8550), "Tesla" },
                    { 5, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8551), "Nestle" },
                    { 6, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8552), "ExxonMobile" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8661), "IT" },
                    { 2, 1, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8663), "HR" },
                    { 3, 2, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8664), "Marketing" },
                    { 4, 2, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8665), "Finance" },
                    { 5, 3, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8666), "R&D" },
                    { 6, 3, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8667), "Sales" },
                    { 7, 4, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8668), "Engineering" },
                    { 8, 4, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8669), "Production" },
                    { 9, 5, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8670), "Culinary" },
                    { 10, 5, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8671), "Supply Chain" },
                    { 11, 6, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8672), "Sustainability" },
                    { 12, 6, new DateTime(2024, 10, 23, 18, 49, 44, 339, DateTimeKind.Utc).AddTicks(8673), "Business Development" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
