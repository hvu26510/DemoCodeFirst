using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class TableNameTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sinhVienDetails_sinhViens_MaSV",
                table: "sinhVienDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_sinhViens_chuyenNganhs_idChuyenNganh",
                table: "sinhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sinhViens",
                table: "sinhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sinhVienDetails",
                table: "sinhVienDetails");

            migrationBuilder.EnsureSchema(
                name: "Guest");

            migrationBuilder.RenameTable(
                name: "sinhViens",
                newName: "Student",
                newSchema: "Guest");

            migrationBuilder.RenameTable(
                name: "sinhVienDetails",
                newName: "StudentDetails",
                newSchema: "Guest");

            migrationBuilder.RenameIndex(
                name: "IX_sinhViens_idChuyenNganh",
                schema: "Guest",
                table: "Student",
                newName: "IX_Student_idChuyenNganh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                schema: "Guest",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDetails",
                schema: "Guest",
                table: "StudentDetails",
                column: "MaSV");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_chuyenNganhs_idChuyenNganh",
                schema: "Guest",
                table: "Student",
                column: "idChuyenNganh",
                principalTable: "chuyenNganhs",
                principalColumn: "idChuyenNganh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentDetails_Student_MaSV",
                schema: "Guest",
                table: "StudentDetails",
                column: "MaSV",
                principalSchema: "Guest",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_chuyenNganhs_idChuyenNganh",
                schema: "Guest",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentDetails_Student_MaSV",
                schema: "Guest",
                table: "StudentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDetails",
                schema: "Guest",
                table: "StudentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                schema: "Guest",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "StudentDetails",
                schema: "Guest",
                newName: "sinhVienDetails");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "Guest",
                newName: "sinhViens");

            migrationBuilder.RenameIndex(
                name: "IX_Student_idChuyenNganh",
                table: "sinhViens",
                newName: "IX_sinhViens_idChuyenNganh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sinhVienDetails",
                table: "sinhVienDetails",
                column: "MaSV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sinhViens",
                table: "sinhViens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sinhVienDetails_sinhViens_MaSV",
                table: "sinhVienDetails",
                column: "MaSV",
                principalTable: "sinhViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sinhViens_chuyenNganhs_idChuyenNganh",
                table: "sinhViens",
                column: "idChuyenNganh",
                principalTable: "chuyenNganhs",
                principalColumn: "idChuyenNganh",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
