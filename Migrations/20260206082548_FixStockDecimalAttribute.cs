using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stock_finance_api.Migrations
{
    /// <inheritdoc />
    public partial class FixStockDecimalAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dividend",
                table: "Stock");

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Stock");

            migrationBuilder.AddColumn<decimal>(
                name: "Dividend",
                table: "Stock",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
