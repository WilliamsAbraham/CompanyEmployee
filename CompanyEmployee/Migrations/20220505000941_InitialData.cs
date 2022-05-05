using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployee.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Companies",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60) CHARACTER SET utf8mb4",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Companies",
                nullable: false);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"), "My address", "My Country", "IT_Solutions ltd." });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"), "My 2nd Address", "My country", "Internal Bank ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("ca761232-ed42-11ce-bacd-00aa0057b323"), 30, new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"), "Mr.Ade", "Software dev." });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("ca761232-ed42-11ce-bacd-00aa0057b123"), 25, new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"), "Mr. Adams", "Backend Engineer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"), 35, new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"), "Kane Miller", "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ca761232-ed42-11ce-bacd-00aa0057b123"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ca761232-ed42-11ce-bacd-00aa0057b323"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ca761233-ed42-11ce-bacd-00aa0057b223"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ca761332-ed42-11ce-bacd-00aa0057b223"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Companies");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Companies",
                type: "varchar(60) CHARACTER SET utf8mb4",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);
        }
    }
}
