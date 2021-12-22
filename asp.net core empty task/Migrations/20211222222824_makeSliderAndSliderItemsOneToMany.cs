using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.net_core_empty_task.Migrations
{
    public partial class makeSliderAndSliderItemsOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sliderId",
                table: "SliderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SliderItem_sliderId",
                table: "SliderItem",
                column: "sliderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SliderItem_Slider_sliderId",
                table: "SliderItem",
                column: "sliderId",
                principalTable: "Slider",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderItem_Slider_sliderId",
                table: "SliderItem");

            migrationBuilder.DropIndex(
                name: "IX_SliderItem_sliderId",
                table: "SliderItem");

            migrationBuilder.DropColumn(
                name: "sliderId",
                table: "SliderItem");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
