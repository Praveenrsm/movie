using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDL.Migrations
{
    public partial class sales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gst",
                table: "sales");

            migrationBuilder.RenameColumn(
                name: "totalprice",
                table: "sales",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "actualprice",
                table: "sales",
                newName: "ActualPrice");

            migrationBuilder.RenameColumn(
                name: "Foodname",
                table: "sales",
                newName: "FoodName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "sales",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "sales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "sales");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "sales",
                newName: "totalprice");

            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "sales",
                newName: "Foodname");

            migrationBuilder.RenameColumn(
                name: "ActualPrice",
                table: "sales",
                newName: "actualprice");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sales",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "gst",
                table: "sales",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
