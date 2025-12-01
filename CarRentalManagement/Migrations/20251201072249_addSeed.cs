using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Namex",
                table: "Colour",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1388), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1399), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1402), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1402), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1703), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1704), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1707), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1612), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1613), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1615), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1616), "x5", "System" },
                    { 3, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1618), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 12, 1, 15, 22, 48, 666, DateTimeKind.Local).AddTicks(1620), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Colour",
                newName: "Namex");
        }
    }
}
