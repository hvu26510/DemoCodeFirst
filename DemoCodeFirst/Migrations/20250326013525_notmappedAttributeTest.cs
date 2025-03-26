using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class notmappedAttributeTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                schema: "Guest",
                table: "Student",
                newName: "YearOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearOfBirth",
                schema: "Guest",
                table: "Student",
                newName: "Age");
        }
    }
}
