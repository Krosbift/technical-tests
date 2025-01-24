using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_on_off.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAtToRaffleNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_Number",
                table: "RaffleNumbers",
                column: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_Number",
                table: "RaffleNumbers");
        }
    }
}
