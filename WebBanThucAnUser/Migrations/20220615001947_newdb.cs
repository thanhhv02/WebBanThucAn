using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThucAnUser.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hinh",
                table: "MonAns");

            migrationBuilder.CreateTable(
                name: "ProductPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPhoto_MonAns_ProductId",
                        column: x => x.ProductId,
                        principalTable: "MonAns",
                        principalColumn: "MonAnID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPhoto_ProductId",
                table: "ProductPhoto",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPhoto");

            migrationBuilder.AddColumn<string>(
                name: "Hinh",
                table: "MonAns",
                type: "nvarchar(250)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MonAns",
                keyColumn: "MonAnID",
                keyValue: 1,
                column: "Hinh",
                value: "f2.png");

            migrationBuilder.UpdateData(
                table: "MonAns",
                keyColumn: "MonAnID",
                keyValue: 2,
                column: "Hinh",
                value: "f3.png");

            migrationBuilder.UpdateData(
                table: "MonAns",
                keyColumn: "MonAnID",
                keyValue: 3,
                column: "Hinh",
                value: "f5.png");

            migrationBuilder.UpdateData(
                table: "MonAns",
                keyColumn: "MonAnID",
                keyValue: 4,
                column: "Hinh",
                value: "f4.png");
        }
    }
}
