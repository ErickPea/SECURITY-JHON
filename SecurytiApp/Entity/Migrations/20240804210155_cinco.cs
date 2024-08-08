using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class cinco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vistas_rol_rol_id",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_vistas_rol_id",
                table: "vistas");

            migrationBuilder.AddColumn<int>(
                name: "rolId",
                table: "vistas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_vistas_rolId",
                table: "vistas",
                column: "rolId");

            migrationBuilder.AddForeignKey(
                name: "FK_vistas_rol_rolId",
                table: "vistas",
                column: "rolId",
                principalTable: "rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vistas_rol_rolId",
                table: "vistas");

            migrationBuilder.DropIndex(
                name: "IX_vistas_rolId",
                table: "vistas");

            migrationBuilder.DropColumn(
                name: "rolId",
                table: "vistas");

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
    }
}
