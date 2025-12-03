using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class addseedanduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d39277c7-9d7c-49e1-aced-e7f96b19c012", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOWqmtmNbnaE0beRDxih2kxHKKkpoPjGLbhFYS/Y5SqRl/eQBlah825T/238N6h61w==", null, false, "ee210a39-6031-4776-a98c-0019e34c8d7f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 765, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 12, 3, 11, 50, 46, 765, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 765, DateTimeKind.Local).AddTicks(9627), new DateTime(2025, 12, 3, 11, 50, 46, 765, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(295), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(299), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(18), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(21), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(121), new DateTime(2025, 12, 3, 11, 50, 46, 766, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3009), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3022), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3368), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3371), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3259), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3263), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3265), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3267), new DateTime(2025, 12, 3, 11, 17, 18, 512, DateTimeKind.Local).AddTicks(3268) });
        }
    }
}
