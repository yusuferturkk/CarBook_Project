using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class brand_table_revize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Cars_CarId1",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarId1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "Cars");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BrandId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId1",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarId1",
                table: "Cars",
                column: "CarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Cars_CarId1",
                table: "Cars",
                column: "CarId1",
                principalTable: "Cars",
                principalColumn: "CarId");
        }
    }
}
