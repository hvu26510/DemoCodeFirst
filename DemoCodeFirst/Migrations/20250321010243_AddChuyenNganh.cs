using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddChuyenNganh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idChuyenNganh",
                table: "sinhViens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "chuyenNganhs",
                columns: table => new
                {
                    idChuyenNganh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNganh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuyenNganhs", x => x.idChuyenNganh);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sinhViens_idChuyenNganh",
                table: "sinhViens",
                column: "idChuyenNganh");

            migrationBuilder.AddForeignKey(
                name: "FK_sinhViens_chuyenNganhs_idChuyenNganh",
                table: "sinhViens",
                column: "idChuyenNganh",
                principalTable: "chuyenNganhs",
                principalColumn: "idChuyenNganh",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sinhViens_chuyenNganhs_idChuyenNganh",
                table: "sinhViens");

            migrationBuilder.DropTable(
                name: "chuyenNganhs");

            migrationBuilder.DropIndex(
                name: "IX_sinhViens_idChuyenNganh",
                table: "sinhViens");

            migrationBuilder.DropColumn(
                name: "idChuyenNganh",
                table: "sinhViens");
        }
    }
}
