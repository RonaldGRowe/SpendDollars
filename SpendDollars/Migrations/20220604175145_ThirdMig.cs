using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpendDollars.Migrations
{
    public partial class ThirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpentMoney",
                table: "SpentMoney");

            migrationBuilder.RenameTable(
                name: "SpentMoney",
                newName: "MoneySpent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneySpent",
                table: "MoneySpent",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneySpent",
                table: "MoneySpent");

            migrationBuilder.RenameTable(
                name: "MoneySpent",
                newName: "SpentMoney");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpentMoney",
                table: "SpentMoney",
                column: "ID");
        }
    }
}
