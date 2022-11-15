using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: false),
                    SocialStanding = table.Column<string>(name: "Social_Standing", type: "TEXT", nullable: false),
                    Homeland = table.Column<string>(type: "TEXT", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Reflexes = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Body = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Emphaty = table.Column<int>(type: "INTEGER", nullable: false),
                    Craft = table.Column<int>(type: "INTEGER", nullable: false),
                    Will = table.Column<int>(type: "INTEGER", nullable: false),
                    Luck = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "ID", "Age", "Body", "Craft", "CreatedDate", "Dexterity", "Emphaty", "Homeland", "Intelligence", "Luck", "Name", "Race", "Reflexes", "Sex", "Social_Standing", "Speed", "Will" },
                values: new object[,]
                {
                    { 1, 112, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "", 0, 0, "Geralt", "Witcher", 0, "Male", "", 0, 0 },
                    { 2, 85, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "", 0, 0, "Yennefer", "Human", 0, "Female", "", 0, 0 },
                    { 3, 62, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "", 0, 0, "Zoltan Chivay", "Dwarf", 0, "Male", "", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
