using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TryAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannedList_Parkinglots_ParkinglotId",
                table: "BannedList");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedList_Vehicles_VehicleLicensePlate",
                table: "BannedList");

            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "BannedList");

            migrationBuilder.RenameColumn(
                name: "VehicleLicensePlate",
                table: "BannedList",
                newName: "vehicleLicensePlate");

            migrationBuilder.RenameColumn(
                name: "ParkinglotId",
                table: "BannedList",
                newName: "parkinglotId");

            migrationBuilder.RenameIndex(
                name: "IX_BannedList_VehicleLicensePlate",
                table: "BannedList",
                newName: "IX_BannedList_vehicleLicensePlate");

            migrationBuilder.RenameIndex(
                name: "IX_BannedList_ParkinglotId",
                table: "BannedList",
                newName: "IX_BannedList_parkinglotId");

            migrationBuilder.AddForeignKey(
                name: "FK_BannedList_Parkinglots_parkinglotId",
                table: "BannedList",
                column: "parkinglotId",
                principalTable: "Parkinglots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BannedList_Vehicles_vehicleLicensePlate",
                table: "BannedList",
                column: "vehicleLicensePlate",
                principalTable: "Vehicles",
                principalColumn: "LicensePlate",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BannedList_Parkinglots_parkinglotId",
                table: "BannedList");

            migrationBuilder.DropForeignKey(
                name: "FK_BannedList_Vehicles_vehicleLicensePlate",
                table: "BannedList");

            migrationBuilder.RenameColumn(
                name: "vehicleLicensePlate",
                table: "BannedList",
                newName: "VehicleLicensePlate");

            migrationBuilder.RenameColumn(
                name: "parkinglotId",
                table: "BannedList",
                newName: "ParkinglotId");

            migrationBuilder.RenameIndex(
                name: "IX_BannedList_vehicleLicensePlate",
                table: "BannedList",
                newName: "IX_BannedList_VehicleLicensePlate");

            migrationBuilder.RenameIndex(
                name: "IX_BannedList_parkinglotId",
                table: "BannedList",
                newName: "IX_BannedList_ParkinglotId");

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "BannedList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BannedList_Parkinglots_ParkinglotId",
                table: "BannedList",
                column: "ParkinglotId",
                principalTable: "Parkinglots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BannedList_Vehicles_VehicleLicensePlate",
                table: "BannedList",
                column: "VehicleLicensePlate",
                principalTable: "Vehicles",
                principalColumn: "LicensePlate",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
