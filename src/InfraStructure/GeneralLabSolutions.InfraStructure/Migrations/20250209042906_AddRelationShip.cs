using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaEventos_Participante_ParticipanteId",
                table: "AgendaEventos");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaEventos_Participante_ParticipanteId",
                table: "AgendaEventos",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaEventos_Participante_ParticipanteId",
                table: "AgendaEventos");

            migrationBuilder.DropIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaEventos_Participante_ParticipanteId",
                table: "AgendaEventos",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
