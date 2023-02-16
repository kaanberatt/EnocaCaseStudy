using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnocaCaseStudy.Persistance.Migrations
{
    public partial class Mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Orders");
        }
    }
}
