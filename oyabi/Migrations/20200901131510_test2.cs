using Microsoft.EntityFrameworkCore.Migrations;

namespace oyabi.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmalars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmalars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelad = table.Column<string>(nullable: true),
                    personelsoyad = table.Column<string>(nullable: true),
                    personelsehir = table.Column<string>(nullable: true),
                    DepartmalarID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_personels_departmalars_DepartmalarID",
                        column: x => x.DepartmalarID,
                        principalTable: "departmalars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personels_DepartmalarID",
                table: "personels",
                column: "DepartmalarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "departmalars");
        }
    }
}
