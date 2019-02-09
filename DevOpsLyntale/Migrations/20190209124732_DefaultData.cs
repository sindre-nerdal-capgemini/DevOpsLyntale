using Microsoft.EntityFrameworkCore.Migrations;

namespace DevOpsLyntale.Migrations
{
    public partial class DefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "public.items",
                columns: new[] { "id", "value" },
                values: new object[] { 1, "Blue" });

            migrationBuilder.InsertData(
                table: "public.items",
                columns: new[] { "id", "value" },
                values: new object[] { 2, "Red" });

            migrationBuilder.InsertData(
                table: "public.items",
                columns: new[] { "id", "value" },
                values: new object[] { 3, "Green" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "public.items",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "public.items",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "public.items",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
