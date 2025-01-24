using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_on_off.Migrations
{
    /// <inheritdoc />
    public partial class newVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raffle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raffle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_ClientId",
                table: "RaffleNumbers",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_RaffleId",
                table: "RaffleNumbers",
                column: "RaffleId");

            migrationBuilder.CreateIndex(
                name: "IX_RaffleNumbers_UserId",
                table: "RaffleNumbers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RaffleNumbers_Client_ClientId",
                table: "RaffleNumbers",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaffleNumbers_Raffle_RaffleId",
                table: "RaffleNumbers",
                column: "RaffleId",
                principalTable: "Raffle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaffleNumbers_User_UserId",
                table: "RaffleNumbers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaffleNumbers_Client_ClientId",
                table: "RaffleNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_RaffleNumbers_Raffle_RaffleId",
                table: "RaffleNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_RaffleNumbers_User_UserId",
                table: "RaffleNumbers");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Raffle");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_ClientId",
                table: "RaffleNumbers");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_RaffleId",
                table: "RaffleNumbers");

            migrationBuilder.DropIndex(
                name: "IX_RaffleNumbers_UserId",
                table: "RaffleNumbers");
        }
    }
}
