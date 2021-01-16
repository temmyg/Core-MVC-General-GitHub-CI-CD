using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_MVC_General.Migrations
{
    public partial class StaffProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffProfile_SerialNo",
                table: "Staff");

            migrationBuilder.CreateTable(
                name: "StaffProfile",
                columns: table => new
                {
                    BelongToStaffID = table.Column<int>(nullable: false),
                    SerialNo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffProfile", x => x.BelongToStaffID);
                    table.ForeignKey(
                        name: "FK_StaffProfile_Staff_BelongToStaffID",
                        column: x => x.BelongToStaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffProfile");

            migrationBuilder.AddColumn<string>(
                name: "StaffProfile_SerialNo",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
