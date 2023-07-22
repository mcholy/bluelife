using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueLife.Migrations
{
    public partial class FixAddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Productos_ProductoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_ProductoId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_TipoMovimientos_TipoMovimientoId",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_RepartoDetalles_Productos_ProductoId",
                table: "RepartoDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_RepartoDetalles_Repartos_RepartoId",
                table: "RepartoDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Repartos_Clientes_ClienteId",
                table: "Repartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Repartos_Usuarios_UsuarioId",
                table: "Repartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_ProductoId",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_TipoMovimientoId",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ProductoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "TipoMovimientoId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "ApMaterno",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ApPaterno",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Usuarios",
                newName: "Contrasenia");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Repartos",
                newName: "IdTrabajador");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Repartos",
                newName: "IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Repartos_UsuarioId",
                table: "Repartos",
                newName: "IX_Repartos_IdTrabajador");

            migrationBuilder.RenameIndex(
                name: "IX_Repartos_ClienteId",
                table: "Repartos",
                newName: "IX_Repartos_IdCliente");

            migrationBuilder.RenameColumn(
                name: "RepartoId",
                table: "RepartoDetalles",
                newName: "IdReparto");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "RepartoDetalles",
                newName: "IdProducto");

            migrationBuilder.RenameIndex(
                name: "IX_RepartoDetalles_RepartoId",
                table: "RepartoDetalles",
                newName: "IX_RepartoDetalles_IdReparto");

            migrationBuilder.RenameIndex(
                name: "IX_RepartoDetalles_ProductoId",
                table: "RepartoDetalles",
                newName: "IX_RepartoDetalles_IdProducto");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "Usuarios",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "Usuarios",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "IdTipoUsuario",
                table: "Usuarios",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "TipoUsuarios",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "TipoUsuarios",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "TipoMovimientos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "TipoMovimientos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "Repartos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "Repartos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "RepartoDetalles",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "RepartoDetalles",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "Productos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "Productos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "Movimientos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "Movimientos",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "IdProducto",
                table: "Movimientos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "IdTipoMovimiento",
                table: "Movimientos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserModify",
                table: "Clientes",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserEntry",
                table: "Clientes",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "IdPersona",
                table: "Clientes",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApPaterno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApMaterno = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateEntry = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModify = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdUserEntry = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdUserModify = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdTipoUsuario",
                table: "Usuarios",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_IdProducto",
                table: "Movimientos",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_IdTipoMovimiento",
                table: "Movimientos",
                column: "IdTipoMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdPersona",
                table: "Clientes",
                column: "IdPersona",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdProducto",
                table: "Clientes",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Persona_IdPersona",
                table: "Clientes",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Productos_IdProducto",
                table: "Clientes",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_TipoMovimientos_IdTipoMovimiento",
                table: "Movimientos",
                column: "IdTipoMovimiento",
                principalTable: "TipoMovimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepartoDetalles_Productos_IdProducto",
                table: "RepartoDetalles",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepartoDetalles_Repartos_IdReparto",
                table: "RepartoDetalles",
                column: "IdReparto",
                principalTable: "Repartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repartos_Clientes_IdCliente",
                table: "Repartos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repartos_Usuarios_IdTrabajador",
                table: "Repartos",
                column: "IdTrabajador",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TipoUsuarios_IdTipoUsuario",
                table: "Usuarios",
                column: "IdTipoUsuario",
                principalTable: "TipoUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Persona_IdPersona",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Productos_IdProducto",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Productos_IdProducto",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_TipoMovimientos_IdTipoMovimiento",
                table: "Movimientos");

            migrationBuilder.DropForeignKey(
                name: "FK_RepartoDetalles_Productos_IdProducto",
                table: "RepartoDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_RepartoDetalles_Repartos_IdReparto",
                table: "RepartoDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Repartos_Clientes_IdCliente",
                table: "Repartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Repartos_Usuarios_IdTrabajador",
                table: "Repartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TipoUsuarios_IdTipoUsuario",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_IdTipoUsuario",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_IdProducto",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_IdTipoMovimiento",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdPersona",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdProducto",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdTipoUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "IdTipoMovimiento",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Contrasenia",
                table: "Usuarios",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "IdTrabajador",
                table: "Repartos",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Repartos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Repartos_IdTrabajador",
                table: "Repartos",
                newName: "IX_Repartos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Repartos_IdCliente",
                table: "Repartos",
                newName: "IX_Repartos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "IdReparto",
                table: "RepartoDetalles",
                newName: "RepartoId");

            migrationBuilder.RenameColumn(
                name: "IdProducto",
                table: "RepartoDetalles",
                newName: "ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_RepartoDetalles_IdReparto",
                table: "RepartoDetalles",
                newName: "IX_RepartoDetalles_RepartoId");

            migrationBuilder.RenameIndex(
                name: "IX_RepartoDetalles_IdProducto",
                table: "RepartoDetalles",
                newName: "IX_RepartoDetalles_ProductoId");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "TipoUsuarioId",
                table: "Usuarios",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "TipoUsuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "TipoUsuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "TipoMovimientos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "TipoMovimientos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "Repartos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "Repartos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "RepartoDetalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "RepartoDetalles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "Movimientos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "Movimientos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "Movimientos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "TipoMovimientoId",
                table: "Movimientos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserModify",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "IdUserEntry",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "ApMaterno",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ApPaterno",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "Clientes",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_ProductoId",
                table: "Movimientos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_TipoMovimientoId",
                table: "Movimientos",
                column: "TipoMovimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProductoId",
                table: "Clientes",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Productos_ProductoId",
                table: "Clientes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Productos_ProductoId",
                table: "Movimientos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_TipoMovimientos_TipoMovimientoId",
                table: "Movimientos",
                column: "TipoMovimientoId",
                principalTable: "TipoMovimientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RepartoDetalles_Productos_ProductoId",
                table: "RepartoDetalles",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepartoDetalles_Repartos_RepartoId",
                table: "RepartoDetalles",
                column: "RepartoId",
                principalTable: "Repartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repartos_Clientes_ClienteId",
                table: "Repartos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repartos_Usuarios_UsuarioId",
                table: "Repartos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId",
                principalTable: "TipoUsuarios",
                principalColumn: "Id");
        }
    }
}
