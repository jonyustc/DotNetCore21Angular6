using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTestApp.Migrations
{
    public partial class SeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Books VALUES('Himo Series',200,'2018-09-10',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
