using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission10_API_LGordon.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: false),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerZip = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");
        }
    }
}
