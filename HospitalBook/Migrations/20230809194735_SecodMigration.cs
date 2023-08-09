using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalBook.Migrations
{
    /// <inheritdoc />
    public partial class SecodMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HospitalUrl",
                table: "Hospitalses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorUrl",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalUrl",
                table: "Hospitalses");

            migrationBuilder.DropColumn(
                name: "DoctorUrl",
                table: "Doctors");
        }
    }
}
