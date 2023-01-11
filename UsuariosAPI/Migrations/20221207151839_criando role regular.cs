using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9dfc1267-7d70-4e31-b910-228324d9881f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "6a2a34fe-5e4e-451e-9878-ec3cd32669b1", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f24066-ecd2-49b9-8d94-b9e8507dfe1c", "AQAAAAEAACcQAAAAECPHv1GzFnOk97Ic75HustAUytsWux3w2vdSahisXYK5ihxP49tQ9tDpsgFY24L4cg==", "c9462b90-5e6f-488a-8b09-268b3dc92948" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d6ce225b-c13b-490b-8588-62204eaab6a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e608699-a5b7-41c4-a91f-94eb6ffb0826", "AQAAAAEAACcQAAAAELRZ5jAK+e3/MfTbsCqLujD7B0nhVqSQWAGKPSHN7xVojt5+6gjhsMGmCBfWaTD/mQ==", "4eb94eee-6ded-4c09-bc5a-434aca9c5a39" });
        }
    }
}
