using Microsoft.EntityFrameworkCore.Migrations;

namespace KodelabAssessment1122API.Migrations
{
    public partial class RecordingUserQuizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelId = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreatorId = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<string>(nullable: true),
                    UserGuid = table.Column<string>(nullable: true),
                    QuestionId = table.Column<string>(nullable: true),
                    AnswerId = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnswers");
        }
    }
}
