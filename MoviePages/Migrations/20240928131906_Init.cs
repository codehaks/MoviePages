using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviePages.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Titanic", 1997 },
                    { 2, "The Shawshank Redemption", 1994 },
                    { 3, "The Godfather", 1972 },
                    { 4, "The Dark Knight", 2008 },
                    { 5, "Pulp Fiction", 1994 },
                    { 6, "Forrest Gump", 1994 },
                    { 7, "Inception", 2010 },
                    { 8, "Fight Club", 1999 },
                    { 9, "The Matrix", 1999 },
                    { 10, "The Lord of the Rings: The Return of the King", 2003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
