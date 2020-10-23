using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Payroll.Infrastructure.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    IDNumber = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    SSSNumber = table.Column<string>(nullable: true),
                    PhilHealthNumber = table.Column<string>(nullable: true),
                    HDMFNumber = table.Column<string>(nullable: true),
                    PositionId = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    EndHireDate = table.Column<DateTime>(nullable: false),
                    ReHireDate = table.Column<DateTime>(nullable: false),
                    BasicRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
