using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAgendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(80)", nullable: false, comment: "Título do Compromisso"),
                    Descricao = table.Column<string>(type: "varchar(600)", nullable: false, comment: "Descrição do Compromisso"),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoEvento = table.Column<string>(type: "varchar(20)", nullable: false, defaultValue: "Info"),
                    DataFim = table.Column<DateTime>(type: "datetime", nullable: true),
                    Localizacao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DiaTodo = table.Column<bool>(type: "bit", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");
        }
    }
}
