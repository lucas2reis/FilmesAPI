using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "adc85bf6-5637-4b91-9a8e-1c6bba7e039c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e080299a-badf-41a7-90aa-12888eb86351");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4961119d-4f12-4233-9b28-cb1a49335a38", "AQAAAAEAACcQAAAAELhwPPvd4c6gmo+bHWvhHgjgNS3d132SppSPRBUw8V9KAe0snXnvpLKQkOiDmi9v/A==", "4d1f6b7c-ea7c-41d0-8c5e-40e6b4d6413e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "6a2a34fe-5e4e-451e-9878-ec3cd32669b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9dfc1267-7d70-4e31-b910-228324d9881f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f24066-ecd2-49b9-8d94-b9e8507dfe1c", "AQAAAAEAACcQAAAAECPHv1GzFnOk97Ic75HustAUytsWux3w2vdSahisXYK5ihxP49tQ9tDpsgFY24L4cg==", "c9462b90-5e6f-488a-8b09-268b3dc92948" });
        }
    }
}
