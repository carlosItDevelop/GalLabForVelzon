using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeneralLabSolutions.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddQuadroKanbanTaskAndParticipante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "PessoaTelefone");

            migrationBuilder.CreateTable(
                name: "KanbanTask",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(80)", nullable: false),
                    Description = table.Column<string>(type: "varchar(150)", nullable: false),
                    Column = table.Column<string>(type: "varchar(20)", nullable: false),
                    Priority = table.Column<string>(type: "varchar(20)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(254)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UndoRedoAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    BeforeData = table.Column<string>(type: "varchar(100)", nullable: true),
                    AfterData = table.Column<string>(type: "varchar(100)", nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UndoRedoAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KanbanTaskParticipante",
                columns: table => new
                {
                    ParticipantesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TasksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanTaskParticipante", x => new { x.ParticipantesId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_KanbanTaskParticipante_KanbanTask_TasksId",
                        column: x => x.TasksId,
                        principalTable: "KanbanTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KanbanTaskParticipante_Participante_ParticipantesId",
                        column: x => x.ParticipantesId,
                        principalTable: "Participante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KanbanTask_Description",
                table: "KanbanTask",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KanbanTask_Title",
                table: "KanbanTask",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KanbanTaskParticipante_TasksId",
                table: "KanbanTaskParticipante",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_Email",
                table: "Participante",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participante_Name",
                table: "Participante",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KanbanTaskParticipante");

            migrationBuilder.DropTable(
                name: "UndoRedoAction");

            migrationBuilder.DropTable(
                name: "KanbanTask");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PessoaTelefone",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
