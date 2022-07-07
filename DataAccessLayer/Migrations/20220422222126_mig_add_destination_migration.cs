using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_destination_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature2s",
                table: "Feature2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_About2s",
                table: "About2s");

            migrationBuilder.RenameTable(
                name: "Feature2s",
                newName: "Feature2S");

            migrationBuilder.RenameTable(
                name: "About2s",
                newName: "About2S");

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature2S",
                table: "Feature2S",
                column: "Feature2Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About2S",
                table: "About2S",
                column: "About2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Feature2S",
                table: "Feature2S");

            migrationBuilder.DropPrimaryKey(
                name: "PK_About2S",
                table: "About2S");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Details1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Details2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Destinations");

            migrationBuilder.RenameTable(
                name: "Feature2S",
                newName: "Feature2s");

            migrationBuilder.RenameTable(
                name: "About2S",
                newName: "About2s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feature2s",
                table: "Feature2s",
                column: "Feature2Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_About2s",
                table: "About2s",
                column: "About2Id");
        }
    }
}
