using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnNameTestimonialsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsFeatured",
                table: "PricingPlans",
                newName: "Featured");

            migrationBuilder.RenameColumn(
                name: "IsAdvanced",
                table: "PricingPlans",
                newName: "Advanced");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Featured",
                table: "PricingPlans",
                newName: "IsFeatured");

            migrationBuilder.RenameColumn(
                name: "Advanced",
                table: "PricingPlans",
                newName: "IsAdvanced");
        }
    }
}
