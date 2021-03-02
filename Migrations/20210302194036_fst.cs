using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment_5_real.Migrations
{
    public partial class fst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<string>(nullable: false),
                    BTitle = table.Column<string>(nullable: false),
                    BAuthorFirst = table.Column<string>(nullable: false),
                    BAuthorMid = table.Column<string>(nullable: true),
                    BAuthorLast = table.Column<string>(nullable: false),
                    BPublisher = table.Column<string>(nullable: false),
                    BClassification = table.Column<string>(nullable: false),
                    BCategory = table.Column<string>(nullable: true),
                    BPrice = table.Column<double>(nullable: false),
                    BPageNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");
        }
    }
}
