using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web_Watch_Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserProfileTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "106c1f64-fc71-49c6-a629-9826e0e4dae5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9c049f-33ab-4341-8c41-ac1d3c9532e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01099144-d9ea-4f2b-853e-48e3261d66e0", null, "customer", "customer" },
                    { "71ca8ca8-4ba1-4271-8488-8858c17fa491", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01099144-d9ea-4f2b-853e-48e3261d66e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71ca8ca8-4ba1-4271-8488-8858c17fa491");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "106c1f64-fc71-49c6-a629-9826e0e4dae5", null, "admin", "admin" },
                    { "ce9c049f-33ab-4341-8c41-ac1d3c9532e8", null, "customer", "customer" }
                });
        }
    }
}
