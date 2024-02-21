using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JS_Tree2.Migrations
{
    /// <inheritdoc />
    public partial class tree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trees",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    parent = table.Column<string>(type: "text", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trees", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trees");
        }
    }
}
