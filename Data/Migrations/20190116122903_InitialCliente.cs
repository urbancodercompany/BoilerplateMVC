using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerplateMVC.Migrations
{
    public partial class InitialCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    phone = table.Column<string>(nullable: true),
                    numeroExterior = table.Column<string>(nullable: true),
                    numeroInterior = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
