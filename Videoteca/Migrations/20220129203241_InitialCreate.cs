using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Videoteca.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atores",
                columns: table => new
                {
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDADE = table.Column<int>(type: "int", nullable: false),
                    PAIS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    APOSENTADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atores", x => x.NOME_ATOR);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
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
                    table.PrimaryKey("PK_Filmes", x => x.ID_FILME);
                });

            migrationBuilder.CreateTable(
                name: "Series",
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
                    table.PrimaryKey("PK_Series", x => x.ID_SERIE);
                });

            migrationBuilder.CreateTable(
                name: "ElencoFilmes",
                columns: table => new
                {
                    ID_ELENCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FILME = table.Column<int>(type: "int", nullable: false),
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElencoFilmes", x => x.ID_ELENCO);
                    table.ForeignKey(
                        name: "FK_ElencoFilmes_Atores_NOME_ATOR",
                        column: x => x.NOME_ATOR,
                        principalTable: "Atores",
                        principalColumn: "NOME_ATOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElencoFilmes_Filmes_ID_FILME",
                        column: x => x.ID_FILME,
                        principalTable: "Filmes",
                        principalColumn: "ID_FILME",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElencoSeries",
                columns: table => new
                {
                    ID_ELENCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SERIE = table.Column<int>(type: "int", nullable: false),
                    NOME_ATOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElencoSeries", x => x.ID_ELENCO);
                    table.ForeignKey(
                        name: "FK_ElencoSeries_Atores_NOME_ATOR",
                        column: x => x.NOME_ATOR,
                        principalTable: "Atores",
                        principalColumn: "NOME_ATOR",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElencoSeries_Series_ID_SERIE",
                        column: x => x.ID_SERIE,
                        principalTable: "Series",
                        principalColumn: "ID_SERIE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmes_ID_FILME",
                table: "ElencoFilmes",
                column: "ID_FILME");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoFilmes_NOME_ATOR",
                table: "ElencoFilmes",
                column: "NOME_ATOR");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoSeries_ID_SERIE",
                table: "ElencoSeries",
                column: "ID_SERIE");

            migrationBuilder.CreateIndex(
                name: "IX_ElencoSeries_NOME_ATOR",
                table: "ElencoSeries",
                column: "NOME_ATOR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElencoFilmes");

            migrationBuilder.DropTable(
                name: "ElencoSeries");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Atores");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
