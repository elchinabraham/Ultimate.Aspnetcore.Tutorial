using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0059c6f8-d9be-40f7-b2a2-5cb1096c4e8e", "c035feb3-a956-43d4-a1f7-f0fdecb57fc2", "Administrator", "ADMINISTRATOR" },
                    { "00c2117f-1497-4d00-a71c-1ff9d144d30e", "0c78290a-3a06-4f57-a283-335334e2ee75", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0059c6f8-d9be-40f7-b2a2-5cb1096c4e8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c2117f-1497-4d00-a71c-1ff9d144d30e");
        }
    }
}
