using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment_5_real.Migrations
{
    public partial class assignment_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAuthorFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BAuthorMid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAuthorLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BPublisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BClassification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPrice = table.Column<double>(type: "float", nullable: false),
                    BPageNumber = table.Column<int>(type: "int", nullable: false)
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
