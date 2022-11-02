using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDL.Migrations
{
    public partial class FoodItemDL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "foodcategory",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    veg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nonveg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodcategory", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foodname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actualprice = table.Column<int>(type: "int", nullable: false),
                    gst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalprice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "foodcategory");

            migrationBuilder.DropTable(
                name: "sales");
        }
    }
}
