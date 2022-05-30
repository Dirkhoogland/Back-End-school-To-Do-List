using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End_school_To_Do_List.Migrations
{
    public partial class addmigrationtestmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lijstentable",
                columns: table => new
                {
                    IdLijst = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NaamLijst = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lijstentable", x => x.IdLijst);
                    table.UniqueConstraint("AK_Lijstentable_NaamLijst", x => x.NaamLijst);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    Lijst = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Naam = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Beschrijving = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Duur = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Lijstentable",
                        column: x => x.Lijst,
                        principalTable: "Lijstentable",
                        principalColumn: "NaamLijst",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lijstentable",
                table: "Lijstentable",
                column: "NaamLijst",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_Lijst",
                table: "Tasks",
                column: "Lijst");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Lijstentable");
        }
    }
}
