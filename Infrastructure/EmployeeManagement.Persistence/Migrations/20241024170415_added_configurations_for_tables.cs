using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Persistence.Migrations
{
    public partial class added_configurations_for_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 24, 21, 4, 15, 128, DateTimeKind.Utc).AddTicks(6736));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1150));
        }
    }
}
