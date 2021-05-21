using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Data.Migrations
{
    public partial class table2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductHistory_ProductHistoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Address_AddressId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_AddressId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductHistoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductHistoryId",
                table: "Product");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "ProductHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ProductHistory_ProductId",
                table: "ProductHistory",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_StaffId",
                table: "Address",
                column: "StaffId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Staff_StaffId",
                table: "Address",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductHistory_Product_ProductId",
                table: "ProductHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Staff_StaffId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductHistory_Product_ProductId",
                table: "ProductHistory");

            migrationBuilder.DropIndex(
                name: "IX_ProductHistory_ProductId",
                table: "ProductHistory");

            migrationBuilder.DropIndex(
                name: "IX_Address_StaffId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductHistory");

            migrationBuilder.AddColumn<long>(
                name: "ProductHistoryId",
                table: "Product",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AddressId",
                table: "Staff",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductHistoryId",
                table: "Product",
                column: "ProductHistoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductHistory_ProductHistoryId",
                table: "Product",
                column: "ProductHistoryId",
                principalTable: "ProductHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Address_AddressId",
                table: "Staff",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
