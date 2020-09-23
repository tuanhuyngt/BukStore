using Microsoft.EntityFrameworkCore.Migrations;

namespace BukStore.AbpZeroTemplate.Migrations
{
    public partial class EditDemoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "DemoModels",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "DemoModels");
        }
    }
}
