using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardsDbApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCardItemAHDBCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AHDBCode",
                table: "CardItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AHDBCode",
                table: "CardItems");
        }
    }
}
