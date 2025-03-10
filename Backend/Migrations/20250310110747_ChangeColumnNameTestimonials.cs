using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnNameTestimonials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Testimonials",
                newName: "Quote");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Testimonials",
                newName: "Position");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quote",
                table: "Testimonials",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Testimonials",
                newName: "Role");
        }
    }
}
