using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppNet.Infrastructer.Persistence.Migrations
{
    public partial class dbIsItPassive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Stocks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Safes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsItPassive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Safes");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsItPassive",
                table: "Categories");
        }
    }
}
