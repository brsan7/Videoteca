using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Videoteca.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AtorBLL",
                columns: table => new
                {
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    PAIS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    APOSENTADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtorBLL", x => x.NOME_ATOR);
                });

            migrationBuilder.CreateTable(
                name: "FilmeBLL",
                columns: table => new
                {
                    ID_FILME = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO_FILME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    GENERO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PAIS = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ANO = table.Column<int>(type: "int", nullable: false),
                    DURACAO = table.Column<int>(type: "int", nullable: false),
                    AVALIACAO = table.Column<int>(type: "int", nullable: false),
                    ASSISTIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmeBLL", x => x.ID_FILME);
                });

            migrationBuilder.CreateTable(
                name: "SerieBLL",
                columns: table => new
                {
                    ID_SERIE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO_SERIE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CAPITULO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TEMPORADA = table.Column<int>(type: "int", nullable: false),
                    EPISODIO = table.Column<int>(type: "int", nullable: false),
                    GENERO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PAIS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ANO = table.Column<int>(type: "int", nullable: false),
                    DURACAO = table.Column<int>(type: "int", nullable: false),
                    AVALIACAO = table.Column<int>(type: "int", nullable: false),
                    ASSISTIDO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieBLL", x => x.ID_SERIE);
                });

            migrationBuilder.CreateTable(
                name: "ElencoFilmeBLL",
                columns: table => new
                {
                    ID_ELENCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FILME = table.Column<int>(type: "int", nullable: false),
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElencoFilmeBLL", x => x.ID_ELENCO);
                    table.ForeignKey(
                        name: "FK_ElencoFilmeBLL_AtorBLL_NOME_ATOR",
                        column: x => x.NOME_ATOR,
                        principalTable: "AtorBLL",
                        principalColumn: "NOME_ATOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElencoFilmeBLL_FilmeBLL_ID_FILME",
                        column: x => x.ID_FILME,
                        principalTable: "FilmeBLL",
                        principalColumn: "ID_FILME",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElencoSerieBLL",
                columns: table => new
                {
                    ID_ELENCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SERIE = table.Column<int>(type: "int", nullable: false),
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElencoSerieBLL", x => x.ID_ELENCO);
                    table.ForeignKey(
                        name: "FK_ElencoSerieBLL_AtorBLL_NOME_ATOR",
                        column: x => x.NOME_ATOR,
                        principalTable: "AtorBLL",
                        principalColumn: "NOME_ATOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElencoSerieBLL_SerieBLL_ID_SERIE",
                        column: x => x.ID_SERIE,
                        principalTable: "SerieBLL",
                        principalColumn: "ID_SERIE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmeBLL_ID_FILME",
                table: "ElencoFilmeBLL",
                column: "ID_FILME");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmeBLL_NOME_ATOR",
                table: "ElencoFilmeBLL",
                column: "NOME_ATOR");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoSerieBLL_ID_SERIE",
                table: "ElencoSerieBLL",
                column: "ID_SERIE");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoSerieBLL_NOME_ATOR",
                table: "ElencoSerieBLL",
                column: "NOME_ATOR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElencoFilmeBLL");

            migrationBuilder.DropTable(
                name: "ElencoSerieBLL");

            migrationBuilder.DropTable(
                name: "FilmeBLL");

            migrationBuilder.DropTable(
                name: "AtorBLL");

            migrationBuilder.DropTable(
                name: "SerieBLL");
        }
    }
}
