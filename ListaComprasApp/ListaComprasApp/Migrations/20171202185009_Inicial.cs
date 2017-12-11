using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaComprasApp.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListasCompras",
                columns: table => new
                {
                    ListaId = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Finalizado = table.Column<bool>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListasCompras", x => x.ListaId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<string>(nullable: false),
                    Concluido = table.Column<bool>(nullable: false),
                    ListaComprasListaId = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_ListasCompras_ListaComprasListaId",
                        column: x => x.ListaComprasListaId,
                        principalTable: "ListasCompras",
                        principalColumn: "ListaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ListaComprasListaId",
                table: "Items",
                column: "ListaComprasListaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ListasCompras");
        }
    }
}
