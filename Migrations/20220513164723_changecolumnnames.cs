using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMVC.Migrations
{
    public partial class changecolumnnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasstName",
                table: "Directors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "LasstName",
                table: "Actors",
                newName: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Directors",
                newName: "LasstName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Actors",
                newName: "LasstName");
        }
    }
}
