using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDecription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Company_id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProduct",
                columns: table => new
                {
                    Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProductDescroption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValue: "Not information!"),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProduct", x => x.Product_id);
                    table.ForeignKey(
                        name: "FK_CompanyProduct_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "Company_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProduct_CompanyId",
                table: "CompanyProduct",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProduct");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
