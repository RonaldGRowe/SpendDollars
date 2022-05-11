using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpendDollars.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpentMoney",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EatOut = table.Column<decimal>(type: "TEXT", nullable: false),
                    Vacation = table.Column<decimal>(type: "TEXT", nullable: false),
                    Entertainment = table.Column<decimal>(type: "TEXT", nullable: false),
                    Education = table.Column<decimal>(type: "TEXT", nullable: false),
                    Shopping = table.Column<decimal>(type: "TEXT", nullable: false),
                    Party = table.Column<decimal>(type: "TEXT", nullable: false),
                    Donate = table.Column<decimal>(type: "TEXT", nullable: false),
                    Spa = table.Column<decimal>(type: "TEXT", nullable: false),
                    Hobby = table.Column<decimal>(type: "TEXT", nullable: false),
                    Personal = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpentMoney", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpentMoney");
        }
    }
}
