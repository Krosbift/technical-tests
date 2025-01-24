using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_on_off.Migrations
{
    /// <inheritdoc />
    public partial class NewReferent3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_ClientId",
                table: "RaffleNumbers");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_Number",
                table: "RaffleNumbers");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_RaffleId",
                table: "RaffleNumbers");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_UserId",
                table: "RaffleNumbers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_ClientId",
                table: "RaffleNumbers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_Number",
                table: "RaffleNumbers",
                column: "Number");

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_RaffleId",
                table: "RaffleNumbers",
                column: "RaffleId");

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_UserId",
                table: "RaffleNumbers",
                column: "UserId");
        }
    }
}
