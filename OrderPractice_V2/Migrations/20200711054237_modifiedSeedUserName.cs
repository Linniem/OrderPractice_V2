using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderPractice_V2.Migrations
{
    public partial class modifiedSeedUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserName",
                value: "UserA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserName",
                value: "User A");
        }
    }
}
