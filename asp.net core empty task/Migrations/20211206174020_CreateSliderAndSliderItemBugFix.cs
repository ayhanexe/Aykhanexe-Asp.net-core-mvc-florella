using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.net_core_empty_task.Migrations
{
    public partial class CreateSliderAndSliderItemBugFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderItem_Slider_Sliderid",
                table: "SliderItem");

            migrationBuilder.DropIndex(
                name: "IX_SliderItem_Sliderid",
                table: "SliderItem");

            migrationBuilder.DropColumn(
                name: "Sliderid",
                table: "SliderItem");

            migrationBuilder.DropColumn(
                name: "desc",
                table: "SliderItem");

            migrationBuilder.DropColumn(
                name: "logo",
                table: "SliderItem");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "SliderItem",
                newName: "image");

            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "logo",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "logo",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Slider");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "SliderItem",
                newName: "title");

            migrationBuilder.AddColumn<int>(
                name: "Sliderid",
                table: "SliderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "SliderItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "logo",
                table: "SliderItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SliderItem_Sliderid",
                table: "SliderItem",
                column: "Sliderid");

            migrationBuilder.AddForeignKey(
                name: "FK_SliderItem_Slider_Sliderid",
                table: "SliderItem",
                column: "Sliderid",
                principalTable: "Slider",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
