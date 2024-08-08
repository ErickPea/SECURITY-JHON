using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class segundo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_personas_personaId",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_vistas_modulo_moduloId",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_vistas_moduloId",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_usuario_personaId",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "moduloId",
                table: "vistas");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "usuario_rol");

            migrationBuilder.DropColumn(
                name: "personaId",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "rol_vista");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "rol");

            migrationBuilder.DropColumn(
                name: "birthday",
                table: "modulo");

            migrationBuilder.CreateIndex(
                name: "IX_vistas_modulo_id",
                table: "vistas",
                column: "modulo_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_persona_id",
                table: "usuario",
                column: "persona_id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_personas_persona_id",
                table: "usuario",
                column: "persona_id",
                principalTable: "personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vistas_modulo_modulo_id",
                table: "vistas",
                column: "modulo_id",
                principalTable: "modulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_personas_persona_id",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_vistas_modulo_modulo_id",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_vistas_modulo_id",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_usuario_persona_id",
                table: "usuario");

            migrationBuilder.AddColumn<int>(
                name: "moduloId",
                table: "vistas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "usuario_rol",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "personaId",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "rol_vista",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "rol",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "birthday",
                table: "modulo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_vistas_moduloId",
                table: "vistas",
                column: "moduloId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_personaId",
                table: "usuario",
                column: "personaId");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_personas_personaId",
                table: "usuario",
                column: "personaId",
                principalTable: "personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vistas_modulo_moduloId",
                table: "vistas",
                column: "moduloId",
                principalTable: "modulo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
