using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAlunoAPI.Data.Migrations
{
    public partial class CreateTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Administrador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Administrador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Administrador_tb_Login_Id_Login",
                        column: x => x.Id_Login,
                        principalTable: "tb_Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Aluno_tb_Login_Id_login",
                        column: x => x.Id_login,
                        principalTable: "tb_Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota1 = table.Column<double>(type: "float", nullable: false),
                    Nota2 = table.Column<double>(type: "float", nullable: false),
                    Id_ALuno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Avaliacao_tb_Aluno_Id_ALuno",
                        column: x => x.Id_ALuno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Aluno_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "tb_Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Turma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTurma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Avaliacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Turma_tb_Avaliacao_Id_Avaliacao",
                        column: x => x.Id_Avaliacao,
                        principalTable: "tb_Avaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Turma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Materia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Materia_tb_Turma_Id_Turma",
                        column: x => x.Id_Turma,
                        principalTable: "tb_Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Administrador_Id_Login",
                table: "tb_Administrador",
                column: "Id_Login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Aluno_Id_login",
                table: "tb_Aluno",
                column: "Id_login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Avaliacao_Id_ALuno",
                table: "tb_Avaliacao",
                column: "Id_ALuno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Aluno",
                table: "tb_Endereco",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Materia_Id_Turma",
                table: "tb_Materia",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Turma_Id_Avaliacao",
                table: "tb_Turma",
                column: "Id_Avaliacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Administrador");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Materia");

            migrationBuilder.DropTable(
                name: "tb_Turma");

            migrationBuilder.DropTable(
                name: "tb_Avaliacao");

            migrationBuilder.DropTable(
                name: "tb_Aluno");

            migrationBuilder.DropTable(
                name: "tb_Login");
        }
    }
}
