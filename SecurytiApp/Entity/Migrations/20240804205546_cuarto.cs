using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class cuarto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_rol_usuario_usuarioId",
                table: "usuario_rol");

            migrationBuilder.DropIndex(
                name: "IX_usuario_rol_usuarioId",
                table: "usuario_rol");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "usuario_rol");

            migrationBuilder.AddColumn<int>(
                name: "rol_id",
                table: "vistas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_vistas_rol_id",
                table: "vistas",
                column: "rol_id");

            migrationBuilder.AddForeignKey(
                name: "FK_vistas_rol_rol_id",
                table: "vistas",
                column: "rol_id",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vistas_rol_rol_id",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_vistas_rol_id",
                table: "vistas");

            migrationBuilder.DropColumn(
                name: "rol_id",
                table: "vistas");

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "usuario_rol",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_rol_usuarioId",
                table: "usuario_rol",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_rol_usuario_usuarioId",
                table: "usuario_rol",
                column: "usuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
