using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Persistence.Migrations
{
    public partial class added_seeded_data_for_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(994), "Pasha Bank" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1002), "Socar" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1002), "Azerenergy" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1003), "AzerGold" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1004), "Azersun Holding" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1004), "Azercell" });

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
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1113), "Customer Service" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DepartmentId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1127), 1, "Anar", "Hüseynov" },
                    { 2, new DateTime(1990, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1130), 2, "Aysel", "Quliyeva" },
                    { 3, new DateTime(2000, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1131), 3, "Murad", "Əliyev" },
                    { 4, new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1132), 1, "Nigar", "Səfərova" },
                    { 5, new DateTime(1992, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1133), 8, "Elvin", "İsmayılov" },
                    { 6, new DateTime(1996, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1133), 2, "Leyla", "Əliyeva" },
                    { 7, new DateTime(1987, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1134), 3, "Rəşad", "Əhmədov" },
                    { 8, new DateTime(1993, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1135), 4, "Günel", "Əliyeva" },
                    { 9, new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1135), 5, "Vüsal", "Əkbərov" },
                    { 10, new DateTime(1989, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1137), 6, "İlqar", "Məmmədov" },
                    { 11, new DateTime(1991, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1138), 7, "Sevinc", "Rzayeva" },
                    { 12, new DateTime(1983, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1138), 3, "Taleh", "Qasımov" },
                    { 13, new DateTime(1994, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1139), 11, "Zaur", "Abdullayev" },
                    { 14, new DateTime(1986, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1140), 4, "Kamran", "Nəsibov" },
                    { 15, new DateTime(1992, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1140), 12, "Elçin", "Nəzərov" },
                    { 16, new DateTime(1989, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1141), 2, "Aynur", "Həsənova" },
                    { 17, new DateTime(1985, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1142), 3, "Fuad", "Babayev" },
                    { 18, new DateTime(1982, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1142), 5, "Namiq", "Əliyev" },
                    { 19, new DateTime(1993, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1143), 4, "Orxan", "Hüseynov" },
                    { 20, new DateTime(1995, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1144), 1, "Rəna", "Mustafayeva" },
                    { 22, new DateTime(1984, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1144), 10, "Şəhriyar", "Həsənov" },
                    { 23, new DateTime(1988, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1145), 4, "Ülviyyə", "İsmayılova" },
                    { 24, new DateTime(1994, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1146), 5, "Toğrul", "Hüseynov" },
                    { 25, new DateTime(1986, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1146), 1, "Rəşad", "Bayramov" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DepartmentId", "Name", "Surname" },
                values: new object[,]
                {
                    { 26, new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1147), 2, "Kənan", "Cəfərov" },
                    { 27, new DateTime(1987, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1148), 3, "Zəka", "Mustafayev" },
                    { 28, new DateTime(1993, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1149), 4, "Fərid", "Xəlilov" },
                    { 29, new DateTime(1985, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1149), 9, "Eldar", "Salmanov" },
                    { 30, new DateTime(1992, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 20, 33, 50, 47, DateTimeKind.Utc).AddTicks(1150), 1, "Sabir", "Babayev" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8257), "Microsoft" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8265), "Amazon" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8265), "Google" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8266), "Tesla" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8266), "Nestle" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8267), "ExxonMobile" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8361), "Sustainability" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 23, 20, 16, 37, 858, DateTimeKind.Utc).AddTicks(8362));
        }
    }
}
