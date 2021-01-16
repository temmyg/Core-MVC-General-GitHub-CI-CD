using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_MVC_General.Migrations
{
    public partial class launchmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LaunchModel",
                table: "LaunchCenter",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaunchModel",
                table: "LaunchCenter");
        }
    }
}
