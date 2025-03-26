using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddSvDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sinhVienDetails",
                columns: table => new
                {
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhVienDetails", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_sinhVienDetails_sinhViens_MaSV",
                        column: x => x.MaSV,
                        principalTable: "sinhViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhVienDetails");
        }
    }
}
