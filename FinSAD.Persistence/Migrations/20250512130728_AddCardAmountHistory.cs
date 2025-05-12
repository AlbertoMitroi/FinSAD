using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinSAD.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCardAmountHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardAmountHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardAmountHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardAmountHistory_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardAmountHistory",
                columns: new[] { "Id", "Amount", "CardId", "Month", "Year" },
                values: new object[,]
                {
                    { 1, 2719m, 1, 5, 2025 },
                    { 2, 3120m, 1, 4, 2025 },
                    { 3, 1998m, 1, 3, 2025 },
                    { 4, 4400m, 1, 2, 2025 },
                    { 5, 3888m, 1, 1, 2025 },
                    { 6, 5221m, 1, 12, 2024 },
                    { 7, 3790m, 1, 11, 2024 },
                    { 8, 6100m, 1, 10, 2024 },
                    { 9, 2890m, 1, 9, 2024 },
                    { 10, 3333m, 1, 8, 2024 },
                    { 11, 4122m, 1, 7, 2024 },
                    { 12, 3911m, 1, 6, 2024 },
                    { 13, 1280m, 2, 5, 2025 },
                    { 14, 1402m, 2, 4, 2025 },
                    { 15, 1500m, 2, 3, 2025 },
                    { 16, 1421m, 2, 2, 2025 },
                    { 17, 1600m, 2, 1, 2025 },
                    { 18, 1580m, 2, 12, 2024 },
                    { 19, 1700m, 2, 11, 2024 },
                    { 20, 1900m, 2, 10, 2024 },
                    { 21, 2100m, 2, 9, 2024 },
                    { 22, 2000m, 2, 8, 2024 },
                    { 23, 1850m, 2, 7, 2024 },
                    { 24, 1755m, 2, 6, 2024 },
                    { 25, 730m, 3, 5, 2025 },
                    { 26, 820m, 3, 4, 2025 },
                    { 27, 790m, 3, 3, 2025 },
                    { 28, 880m, 3, 2, 2025 },
                    { 29, 860m, 3, 1, 2025 },
                    { 30, 840m, 3, 12, 2024 },
                    { 31, 920m, 3, 11, 2024 },
                    { 32, 1010m, 3, 10, 2024 },
                    { 33, 980m, 3, 9, 2024 },
                    { 34, 940m, 3, 8, 2024 },
                    { 35, 895m, 3, 7, 2024 },
                    { 36, 875m, 3, 6, 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardAmountHistory_CardId",
                table: "CardAmountHistory",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardAmountHistory");
        }
    }
}
