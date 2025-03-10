using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Dataitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IconBoxes",
                table: "IconBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountBoxes",
                table: "CountBoxes");

            migrationBuilder.RenameTable(
                name: "IconBoxes",
                newName: "IconBoxs");

            migrationBuilder.RenameTable(
                name: "CountBoxes",
                newName: "CountBoxs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IconBoxs",
                table: "IconBoxs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountBoxs",
                table: "CountBoxs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IconBoxs",
                table: "IconBoxs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountBoxs",
                table: "CountBoxs");

            migrationBuilder.RenameTable(
                name: "IconBoxs",
                newName: "IconBoxes");

            migrationBuilder.RenameTable(
                name: "CountBoxs",
                newName: "CountBoxes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IconBoxes",
                table: "IconBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountBoxes",
                table: "CountBoxes",
                column: "Id");
        }
    }
}
