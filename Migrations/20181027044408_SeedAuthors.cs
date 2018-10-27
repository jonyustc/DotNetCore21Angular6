using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTestApp.Migrations
{
    public partial class SeedAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Authors VALUES('Humayun Ahmed')");
            migrationBuilder.Sql("INSERT INTO Authors VALUES('Anisul Haq')");
            migrationBuilder.Sql("INSERT INTO Authors VALUES('Imdadul Haq Milon')");
            migrationBuilder.Sql("INSERT INTO Authors VALUES('Mahbubul Alam')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
