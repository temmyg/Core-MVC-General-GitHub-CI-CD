using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_MVC_General.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaunchCenter",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Commander = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchCenter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LaunchCenterID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_LaunchCenter_LaunchCenterID",
                        column: x => x.LaunchCenterID,
                        principalTable: "LaunchCenter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_LaunchCenterID",
                table: "Staff",
                column: "LaunchCenterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "LaunchCenter");
        }
    }
}
