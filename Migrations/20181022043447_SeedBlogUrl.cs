using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTestApp.Migrations
{
    public partial class SeedBlogUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Blogs VALUES('http://www.itech.com')");
            migrationBuilder.Sql("INSERT INTO Blogs VALUES('http://www.techb.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
