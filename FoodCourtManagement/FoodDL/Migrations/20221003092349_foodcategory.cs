using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDL.Migrations
{
    public partial class foodcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "veg",
                table: "foodcategory",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "nonveg",
                table: "foodcategory",
                newName: "FoodName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "foodcategory",
                newName: "veg");

            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "foodcategory",
                newName: "nonveg");
        }
    }
}
