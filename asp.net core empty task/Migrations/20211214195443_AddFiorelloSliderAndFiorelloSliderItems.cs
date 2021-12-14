using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.net_core_empty_task.Migrations
{
    public partial class AddFiorelloSliderAndFiorelloSliderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FiorelloSlider",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiorelloSlider", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FiorelloSliderItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiorelloSliderItems", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FiorelloSlider");

            migrationBuilder.DropTable(
                name: "FiorelloSliderItems");
        }
    }
}
