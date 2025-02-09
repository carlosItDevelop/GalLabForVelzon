using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIsUniqueInTitleAgendaEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaEventos_Title",
                table: "AgendaEventos",
                column: "Title",
                unique: true);
        }
    }
}
