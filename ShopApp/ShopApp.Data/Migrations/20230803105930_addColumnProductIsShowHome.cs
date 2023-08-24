using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Data.Migrations
{
    public partial class addColumnProductIsShowHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsShowHome",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsShowHome",
                table: "Products");
        }
    }
}
