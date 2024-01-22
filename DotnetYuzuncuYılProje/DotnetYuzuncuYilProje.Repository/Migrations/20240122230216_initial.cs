using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYilProje.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MovieType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Audiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audiences_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    AudienceId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalTable: "Audiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDateTime", "MovieReleasedDate", "MovieTitle", "MovieType", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 23, 2, 2, 16, 722, DateTimeKind.Local).AddTicks(6680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Before Sunrise", "Romance", null },
                    { 2, new DateTime(2024, 1, 23, 2, 2, 16, 722, DateTimeKind.Local).AddTicks(6689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Before Sunset", "Romance", null },
                    { 3, new DateTime(2024, 1, 23, 2, 2, 16, 722, DateTimeKind.Local).AddTicks(6690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Before Midnight", "Romance", null },
                    { 4, new DateTime(2024, 1, 23, 2, 2, 16, 722, DateTimeKind.Local).AddTicks(6690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", "Science-Fiction", null }
                });

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "Age", "CreatedDateTime", "Email", "FirstName", "LastName", "MovieId", "UpdatedDateTime" },
                values: new object[] { 1, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sevvalozdemir.tech@gmail.com", "Şevval", "Özdemir", 1, null });

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "Age", "CreatedDateTime", "Email", "FirstName", "LastName", "MovieId", "UpdatedDateTime" },
                values: new object[] { 2, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "beyzakuru@gmail.com", "Beyza", "Kuru", 4, null });

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_MovieId",
                table: "Audiences",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AudienceId",
                table: "Tickets",
                column: "AudienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Audiences");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
