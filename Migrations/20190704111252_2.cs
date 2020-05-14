using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuDescriptionText",
                table: "Menus",
                newName: "userId");

            migrationBuilder.AddColumn<int>(
                name: "MenuID",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuID",
                table: "Products",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_userId",
                table: "Menus",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_AspNetUsers_userId",
                table: "Menus",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Menus_MenuID",
                table: "Products",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_AspNetUsers_userId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Menus_MenuID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MenuID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Menus_userId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "MenuID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Menus",
                newName: "MenuDescriptionText");

            migrationBuilder.AlterColumn<string>(
                name: "MenuDescriptionText",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
