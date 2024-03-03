using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Sigla = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodIBGE = table.Column<int>(type: "int", nullable: false),
                    UfId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Uf_UfId",
                        column: x => x.UfId,
                        principalTable: "Uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Cep = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MunicipioId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cep_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("08b05eb3-0984-41d4-b727-605b6b2584c2"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6173), "Goiás", "GO", null },
                    { new Guid("1b5900b7-44ff-4a01-a1d8-c6eb4f5ab2aa"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6179), "Mato Grosso do Sul", "MS", null },
                    { new Guid("22df83df-8233-44ac-8f60-2bfa9d0dcd1c"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6202), "Santa Catarina", "SC", null },
                    { new Guid("2347ae36-8725-4644-a5db-9c16f3dd90b5"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6170), "Distrito Federal", "DF", null },
                    { new Guid("3b1219b4-4887-40ed-87a3-59b1b9c02e09"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6206), "Sergipe", "SE", null },
                    { new Guid("3c0ff789-0d2a-43cc-b067-44c2b4b1f30a"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6177), "Mato Grosso", "MT", null },
                    { new Guid("41a45a39-6175-4a63-8f99-d796e1d03e97"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6147), "Acre", "AC", null },
                    { new Guid("43f98b8b-3aa2-4f91-8fb6-16c98fd41a14"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6190), "Piauí", "PI", null },
                    { new Guid("4ad9b3bc-8260-4e2a-a14e-b59e16909a77"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6175), "Maranhão", "MA", null },
                    { new Guid("4fb7709a-d3b7-4e43-8104-e34b22fa2a2e"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6204), "São Paulo", "SP", null },
                    { new Guid("5747e649-9a39-476e-88d3-2295d9e59e6d"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6159), "Alagoas", "AL", null },
                    { new Guid("6dd67a6c-2f0d-4b32-b535-9c4075745f81"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6182), "Pará", "PA", null },
                    { new Guid("7a824d07-25ec-49b7-b891-1a9f5f3e6b10"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6188), "Pernambuco", "PE", null },
                    { new Guid("7c3cf2b8-6e61-4c29-aa75-107d7d3bde56"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6161), "Amapá", "AP", null },
                    { new Guid("8fc1401b-7b83-4eac-bd40-87f8264c245e"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6172), "Espírito Santo", "ES", null },
                    { new Guid("8fd3c5ae-88b2-4e5c-b07b-009fb86bb6c2"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6197), "Rondônia", "RO", null },
                    { new Guid("8fd4f242-8fb1-4499-97b0-2c7f33b12212"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6186), "Paraná", "PR", null },
                    { new Guid("97df85b3-cd25-4632-a356-aa9bde9cb593"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6195), "Rio Grande do Sul", "RS", null },
                    { new Guid("ab48a0b4-2179-4a15-8a5c-6e54a2d37bfc"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6184), "Paraíba", "PB", null },
                    { new Guid("b821b87b-0408-4665-8421-73d45a09dd54"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6193), "Rio Grande do Norte", "RN", null },
                    { new Guid("b84760c3-efdb-4815-826e-50d529a4254c"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6181), "Minas Gerais", "MG", null },
                    { new Guid("ba138af0-22a5-4b58-97d1-835b2566dcb3"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6207), "Tocantins", "TO", null },
                    { new Guid("bc60d57e-87ad-4ab0-a37e-29c0f2f3f1e2"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6164), "Amazonas", "AM", null },
                    { new Guid("d0f11c90-23e8-4388-98b0-99c02fdd1963"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6166), "Bahia", "BA", null },
                    { new Guid("d9613a3a-1d62-4491-950f-d29cd1f89d5d"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6200), "Roraima", "RR", null },
                    { new Guid("e0a6a60f-1b53-4c19-836f-7a071d1e91b1"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6191), "Rio de Janeiro", "RJ", null },
                    { new Guid("f0058a0a-1594-484a-9b23-02cb85d3bd1e"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(6168), "Ceará", "CE", null }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("8437e6f6-e9e3-4848-b5c4-6bf3424f1fa9"), new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(5925), "admin@admin.com", "Administrador", new DateTime(2024, 3, 2, 21, 39, 28, 464, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cep",
                table: "Cep",
                column: "Cep");

            migrationBuilder.CreateIndex(
                name: "IX_Cep_MunicipioId",
                table: "Cep",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_CodIBGE",
                table: "Municipio",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_UfId",
                table: "Municipio",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Uf_Sigla",
                table: "Uf",
                column: "Sigla",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cep");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Uf");
        }
    }
}
