using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wba.RateAMovie.Web.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[] { 1, "Ryan", "Reynolds" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Warner Bros" });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[] { 1, "Jacques", "Vermeire" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Firstname", "Lastname", "Username" },
                values: new object[] { 1, "Jarno", "Caenepeel", "jarno.caenepeel@lotr.com" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CompanyId", "ReleaseDate", "Title" },
                values: new object[] { 1, 1, null, "Deadpool" });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "MoviesId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "RatedMovieId", "Review", "ReviewerId", "Score" },
                values: new object[] { 1, 1, null, 1, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "MoviesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
