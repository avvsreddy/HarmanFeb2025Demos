using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemoApp.Migrations
{
    /// <inheritdoc />
    public partial class TPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersSupplierID",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "SuppliersPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersPersonId");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "People",
                newName: "PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "People",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GST",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_People_SuppliersPersonId",
                table: "ProductSupplier",
                column: "SuppliersPersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_People_SuppliersPersonId",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "SuppliersPersonId",
                table: "ProductSupplier",
                newName: "SuppliersSupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersPersonId",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersSupplierID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Suppliers",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Suppliers",
                newName: "SupplierID");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GST",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersSupplierID",
                table: "ProductSupplier",
                column: "SuppliersSupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
