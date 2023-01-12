using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_Oracle.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ProductName = table.Column<string>(type: "NVARCHAR2(400)", maxLength: 400, nullable: false),
                    Manufacturer = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR2(1000)", maxLength: 1000, nullable: false),
                    Price = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
