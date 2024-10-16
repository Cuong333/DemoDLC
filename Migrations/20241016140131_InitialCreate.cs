using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoDLC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "photo",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerId1",
                table: "Customer",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Customer_CustomerId1",
                table: "Customer",
                column: "CustomerId1",
                principalTable: "Customer",
                principalColumn: "customerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Customer_CustomerId1",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CustomerId1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Customer");

            migrationBuilder.AlterColumn<byte[]>(
                name: "photo",
                table: "Product",
                type: "varbinary(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
