using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ONLNSTR.Migrations
{
    public partial class ONLNWatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ONLNSTRWatchItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    watchid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ONLNSTRWatchId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ONLNSTRWatchItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ONLNSTRWatchItem_Watch_watchid",
                        column: x => x.watchid,
                        principalTable: "Watch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ONLNSTRWatchItem_watchid",
                table: "ONLNSTRWatchItem",
                column: "watchid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ONLNSTRWatchItem");
        }
    }
}
