using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTarefasKanbanOld : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarefaMembro");

            migrationBuilder.DropTable(
                name: "GerenciadorDeFluxoKanban");

            migrationBuilder.DropTable(
                name: "MembroEquipe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GerenciadorDeFluxoKanban",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Titulo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerenciadorDeFluxoKanban", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembroEquipe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembroEquipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarefaMembro",
                columns: table => new
                {
                    MembrosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TarefasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarefaMembro", x => new { x.MembrosId, x.TarefasId });
                    table.ForeignKey(
                        name: "FK_TarefaMembro_GerenciadorDeFluxoKanban_TarefasId",
                        column: x => x.TarefasId,
                        principalTable: "GerenciadorDeFluxoKanban",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TarefaMembro_MembroEquipe_MembrosId",
                        column: x => x.MembrosId,
                        principalTable: "MembroEquipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GerenciadorDeFluxoKanban_Status",
                table: "GerenciadorDeFluxoKanban",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_GerenciadorDeFluxoKanban_Titulo",
                table: "GerenciadorDeFluxoKanban",
                column: "Titulo");

            migrationBuilder.CreateIndex(
                name: "IX_MembroEquipe_Nome",
                table: "MembroEquipe",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_TarefaMembro_TarefasId",
                table: "TarefaMembro",
                column: "TarefasId");
        }
    }
}
