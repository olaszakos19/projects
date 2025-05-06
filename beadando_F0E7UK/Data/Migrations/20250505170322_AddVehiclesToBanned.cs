using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVehiclesToBanned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BannedId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "BannedList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BannedId",
                table: "Vehicles",
                column: "BannedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_BannedList_BannedId",
                table: "Vehicles",
                column: "BannedId",
                principalTable: "BannedList",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_BannedList_BannedId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BannedId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BannedId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "BannedList");
        }
    }
}
