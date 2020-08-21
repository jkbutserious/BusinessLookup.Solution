using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "PhoneNumber",
                table: "Shops",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<uint>(
                name: "PhoneNumber",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Cuisine", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ice Cream", "Tom and Mickey's", 4255550005u },
                    { 2, "Italian", "Caper Greenhouse", 4255550006u },
                    { 3, "Burgers", "Blue Bluejay", 4255550007u },
                    { 4, "Bakery", "185F", 4255550008u }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Name", "PhoneNumber", "Type" },
                values: new object[,]
                {
                    { 1, "The Crevasse", 4255550001u, "Clothing" },
                    { 2, "The Crisper Picture", 4255550002u, "Electronics" },
                    { 3, "Farmhouse and Highborn", 4255550003u, "Book" },
                    { 4, "QXNickel", 4255550004u, "Department Store" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Shops",
                nullable: true,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Restaurants",
                nullable: true,
                oldClrType: typeof(uint));
        }
    }
}
