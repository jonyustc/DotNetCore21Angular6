using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTestApp.Migrations
{
    public partial class SeedPostData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Posts VALUES('Test Title','Test Desc',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
