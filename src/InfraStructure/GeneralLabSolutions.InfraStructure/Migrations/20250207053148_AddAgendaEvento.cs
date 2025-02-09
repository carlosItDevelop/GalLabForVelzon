using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAgendaEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendaEventos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 300, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Color = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    ParticipanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaEventos_Participante_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "Participante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_ParticipanteId",
                table: "AgendaEventos",
                column: "ParticipanteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaEventos");
        }
    }
}
