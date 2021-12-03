using Microsoft.EntityFrameworkCore.Migrations;

namespace Final_v1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainChara = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DnD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Background = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DnD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Bday = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VinylCollection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(nullable: true),
                    Album = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinylCollection", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Anime",
                columns: new[] { "Id", "Description", "Genre", "MainChara", "Name" },
                values: new object[] { 1, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "DnD",
                columns: new[] { "Id", "Background", "Class", "Name", "Race" },
                values: new object[] { 1, "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Name",
                columns: new[] { "Id", "Bday", "CP", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "03/17/2000", "Information Tech.", "Samuel", 2021 },
                    { 2, "07/03/1996", "Information Tech.", "Dora", 2021 },
                    { 3, "01/17/2000", "Information Tech.", "Julia", 2021 }
                });

            migrationBuilder.InsertData(
                table: "VinylCollection",
                columns: new[] { "Id", "Album", "Artist", "Year" },
                values: new object[,]
                {
                    { 1, "Blue Banisters", "Lana Del Rey", 2021 },
                    { 2, "The 1975", "The 1975", 2013 },
                    { 3, "Fine Line", "Harry Styles", 2019 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anime");

            migrationBuilder.DropTable(
                name: "DnD");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "VinylCollection");
        }
    }
}
