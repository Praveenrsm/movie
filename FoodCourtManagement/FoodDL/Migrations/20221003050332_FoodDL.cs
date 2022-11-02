using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDL.Migrations
{
    public partial class FoodDL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fooditems2",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fooditems2", x => x.FoodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fooditems2");
        }
    }
}
