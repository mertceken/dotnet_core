using Microsoft.EntityFrameworkCore.Migrations;

namespace _20200717_book_list_razor.Migrations
{
    public partial class AddisBNToBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isBN",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isBN",
                table: "Book");
        }
    }
}
