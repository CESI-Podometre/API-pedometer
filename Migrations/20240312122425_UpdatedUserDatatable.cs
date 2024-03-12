using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarFitApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserDatatable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Users",
                newName: "identifier");

            migrationBuilder.CreateIndex(
                name: "IX_Users_identifier",
                table: "Users",
                column: "identifier",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_identifier",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "identifier",
                table: "Users",
                newName: "last_name");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Users",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_email",
                table: "Users",
                column: "email",
                unique: true);
        }
    }
}
