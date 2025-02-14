using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAgendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(600)", nullable: false, comment: "Descrição do Compromisso"),
                    DiaTodo = table.Column<bool>(type: "bit", nullable: false),
                    Localizacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    TipoEvento = table.Column<string>(type: "varchar(20)", nullable: false, defaultValue: "Info"),
                    Titulo = table.Column<string>(type: "varchar(80)", nullable: false, comment: "Título do Compromisso")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_Descricao",
                table: "Agendamento",
                column: "Descricao");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_Localizacao",
                table: "Agendamento",
                column: "Localizacao");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_Titulo",
                table: "Agendamento",
                column: "Titulo",
                unique: true);
        }
    }
}
