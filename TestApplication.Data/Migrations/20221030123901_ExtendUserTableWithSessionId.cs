using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApplication.Data.Migrations
{
    public partial class ExtendUserTableWithSessionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "session_id",
                table: "user",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "session_id",
                table: "user");
        }
    }
}
