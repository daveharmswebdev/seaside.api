using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace seaside.api.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToTodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10000,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3470), null, new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10001,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510), null, new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10002,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510), null, new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10003,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510), null, new DateTime(2023, 11, 12, 13, 51, 18, 129, DateTimeKind.Local).AddTicks(3510) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10000,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10001,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10002,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 10003,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 5, 9, 0, 10, 700, DateTimeKind.Local).AddTicks(3270) });
        }
    }
}
