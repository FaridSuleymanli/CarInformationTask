using Microsoft.EntityFrameworkCore.Migrations;

namespace CarInformationTask.Migrations
{
    public partial class AddedDataToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_CarMakes_CarMakeId",
                table: "CarModels");

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Audi" });

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "BMW" });

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Mercedes" });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarMakeId", "Name", "Price", "Year" },
                values: new object[,]
                {
                    { 1, 1, "Q7", "38.000 AZN", 2015 },
                    { 3, 1, "A3", "80.000 AZN", 2015 },
                    { 2, 2, "X5", "150.000 AZN", 2019 },
                    { 4, 3, "C Class", "55.400 AZN", 2013 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_CarMakes_CarMakeId",
                table: "CarModels",
                column: "CarMakeId",
                principalTable: "CarMakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_CarMakes_CarMakeId",
                table: "CarModels");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_CarMakes_CarMakeId",
                table: "CarModels",
                column: "CarMakeId",
                principalTable: "CarMakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
