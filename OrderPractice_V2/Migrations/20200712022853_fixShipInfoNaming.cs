using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderPractice_V2.Migrations
{
    public partial class fixShipInfoNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipInfos_Orders_OrderId",
                table: "ShipInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipInfos",
                table: "ShipInfos");

            migrationBuilder.RenameTable(
                name: "ShipInfos",
                newName: "ShipInfoes");

            migrationBuilder.RenameIndex(
                name: "IX_ShipInfos_OrderId",
                table: "ShipInfoes",
                newName: "IX_ShipInfoes_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipInfoes",
                table: "ShipInfoes",
                column: "ShipInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipInfoes_Orders_OrderId",
                table: "ShipInfoes",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShipInfoes_Orders_OrderId",
                table: "ShipInfoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipInfoes",
                table: "ShipInfoes");

            migrationBuilder.RenameTable(
                name: "ShipInfoes",
                newName: "ShipInfos");

            migrationBuilder.RenameIndex(
                name: "IX_ShipInfoes_OrderId",
                table: "ShipInfos",
                newName: "IX_ShipInfos_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipInfos",
                table: "ShipInfos",
                column: "ShipInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShipInfos_Orders_OrderId",
                table: "ShipInfos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
