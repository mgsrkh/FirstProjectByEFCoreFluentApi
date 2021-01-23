using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdProjectEFCoreFluentApi.Migrations
{
    public partial class Final_Edit_FluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Torfeh_Tag_Torfeh_vendor_VendorId",
                table: "Torfeh_Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Torfeh_vendor",
                table: "Torfeh_vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Torfeh_Tag",
                table: "Torfeh_Tag");

            migrationBuilder.RenameTable(
                name: "Torfeh_vendor",
                newName: "Vendor_FluentApi");

            migrationBuilder.RenameTable(
                name: "Torfeh_Tag",
                newName: "Tag_FluentApi");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Vendor_FluentApi",
                newName: "VendorName");

            migrationBuilder.RenameIndex(
                name: "IX_Torfeh_Tag_VendorId",
                table: "Tag_FluentApi",
                newName: "IX_Tag_FluentApi_VendorId");

            migrationBuilder.AddPrimaryKey(
                name: "VendorId",
                table: "Vendor_FluentApi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "TagId",
                table: "Tag_FluentApi",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_FluentApi_Vendor_FluentApi_VendorId",
                table: "Tag_FluentApi",
                column: "VendorId",
                principalTable: "Vendor_FluentApi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_FluentApi_Vendor_FluentApi_VendorId",
                table: "Tag_FluentApi");

            migrationBuilder.DropPrimaryKey(
                name: "VendorId",
                table: "Vendor_FluentApi");

            migrationBuilder.DropPrimaryKey(
                name: "TagId",
                table: "Tag_FluentApi");

            migrationBuilder.RenameTable(
                name: "Vendor_FluentApi",
                newName: "Torfeh_vendor");

            migrationBuilder.RenameTable(
                name: "Tag_FluentApi",
                newName: "Torfeh_Tag");

            migrationBuilder.RenameColumn(
                name: "VendorName",
                table: "Torfeh_vendor",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_FluentApi_VendorId",
                table: "Torfeh_Tag",
                newName: "IX_Torfeh_Tag_VendorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Torfeh_vendor",
                table: "Torfeh_vendor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Torfeh_Tag",
                table: "Torfeh_Tag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Torfeh_Tag_Torfeh_vendor_VendorId",
                table: "Torfeh_Tag",
                column: "VendorId",
                principalTable: "Torfeh_vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
