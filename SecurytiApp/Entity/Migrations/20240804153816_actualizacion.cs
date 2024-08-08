using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birthday",
                table: "personas");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "personas",
                newName: "segundo_nombre");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "personas",
                newName: "segundo_apellido");

            migrationBuilder.AddColumn<string>(
                name: "primer_apellido",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "primer_nombre",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "primer_apellido",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "primer_nombre",
                table: "personas");

            migrationBuilder.RenameColumn(
                name: "segundo_nombre",
                table: "personas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "segundo_apellido",
                table: "personas",
                newName: "apellido");

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
