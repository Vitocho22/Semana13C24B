using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana13C24B.Migrations
{
    /// <inheritdoc />
    public partial class v2_crearbasededatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Courses");
        }
    }
}
