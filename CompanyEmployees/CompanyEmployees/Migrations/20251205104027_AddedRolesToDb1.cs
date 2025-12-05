using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0059c6f8-d9be-40f7-b2a2-5cb1096c4e8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c2117f-1497-4d00-a71c-1ff9d144d30e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f6f3c89-4e7e-4f63-9b1d-4c5658c1a001", "c4a8e6a5-2b1d-4e7c-9b32-1f0b7a2f1001", "Manager", "MANAGER" },
                    { "c3a2c4d1-9b5a-4a96-8b8c-985fa3a2b002", "e2b4a7c3-8d2f-4f61-8c1e-7a9db5f21002", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f6f3c89-4e7e-4f63-9b1d-4c5658c1a001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3a2c4d1-9b5a-4a96-8b8c-985fa3a2b002");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0059c6f8-d9be-40f7-b2a2-5cb1096c4e8e", "c035feb3-a956-43d4-a1f7-f0fdecb57fc2", "Administrator", "ADMINISTRATOR" },
                    { "00c2117f-1497-4d00-a71c-1ff9d144d30e", "0c78290a-3a06-4f57-a283-335334e2ee75", "Manager", "MANAGER" }
                });
        }
    }
}
