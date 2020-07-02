using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping_app.Migrations
{
    public partial class June : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarItem_Car_carid",
                table: "ShopCarItem");

            migrationBuilder.RenameColumn(
                name: "carid",
                table: "ShopCarItem",
                newName: "CarID");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarItem_carid",
                table: "ShopCarItem",
                newName: "IX_ShopCarItem_CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarItem_Car_CarID",
                table: "ShopCarItem",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarItem_Car_CarID",
                table: "ShopCarItem");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "ShopCarItem",
                newName: "carid");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarItem_CarID",
                table: "ShopCarItem",
                newName: "IX_ShopCarItem_carid");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarItem_Car_carid",
                table: "ShopCarItem",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
