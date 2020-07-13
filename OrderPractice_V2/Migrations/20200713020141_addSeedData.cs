using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderPractice_V2.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderStatus", "ShipInfoId", "TotalCost", "TotalPrice", "UserId" },
                values: new object[] { "A20202026005", "Payment completed", null, 1760, 2200, 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Quantity", "UnitCost", "UnitPrice" },
                values: new object[] { "A20202026005", 1, 4, 90, 100 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Quantity", "UnitCost", "UnitPrice" },
                values: new object[] { "A20202026005", 2, 5, 100, 120 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Quantity", "UnitCost", "UnitPrice" },
                values: new object[] { "A20202026005", 3, 6, 150, 200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "A20202026005", 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "A20202026005", 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { "A20202026005", 3 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: "A20202026005");
        }
    }
}
