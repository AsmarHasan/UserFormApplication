using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestApplication.Data.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sector_id = table.Column<int>(type: "integer", nullable: false),
                    sector_parent_id = table.Column<int>(type: "integer", nullable: false),
                    sector_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sector_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    agreed_to_terms = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_sector",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    sector_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_sector_key", x => x.id);
                    table.ForeignKey(
                        name: "user_sector_sector_id_fkey",
                        column: x => x.sector_id,
                        principalTable: "sector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "user_sector_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "sector",
                columns: new[] { "Id", "sector_id", "sector_name", "sector_parent_id" },
                values: new object[,]
                {
                    { 1, 1, "Manufacturing", 0 },
                    { 2, 19, "Construction materials", 1 },
                    { 3, 18, "Electronics and Optics", 1 },
                    { 4, 6, "Food and Beverage", 1 },
                    { 5, 342, "Bakery & confectionery products", 6 },
                    { 6, 43, "Beverages", 6 },
                    { 7, 42, "Fish & fish products", 6 },
                    { 8, 40, "Meat & meat products", 6 },
                    { 9, 39, "Milk  & dairy products", 6 },
                    { 10, 378, "Sweets & snack food", 6 },
                    { 11, 437, "Other", 6 },
                    { 12, 13, "Furniture", 1 },
                    { 13, 389, "Bathroom/sauna", 13 },
                    { 14, 385, "Bedroom", 13 },
                    { 15, 390, "Children’s room", 13 },
                    { 16, 98, "Kitchen ", 13 },
                    { 17, 101, "Living room", 13 },
                    { 18, 392, "Office", 13 },
                    { 19, 341, "Outdoor", 13 },
                    { 20, 99, "Project furniture", 13 },
                    { 21, 394, "Other (Furniture)", 13 },
                    { 22, 12, "Machinery ", 1 },
                    { 23, 94, "Machinery components", 12 },
                    { 24, 91, "Machinery equipment/tools", 12 },
                    { 25, 224, "Manufacture of machinery", 12 },
                    { 26, 97, "Maritime", 12 },
                    { 27, 271, "Aluminium and steel workboats", 97 },
                    { 28, 269, "Boat/Yacht building", 97 },
                    { 29, 230, "Ship repair and conversion", 97 },
                    { 30, 93, "Metal structures", 12 },
                    { 31, 227, "Repair and maintenance service", 12 },
                    { 32, 508, "Other", 12 },
                    { 33, 11, "Metalworking", 1 },
                    { 34, 67, "Construction of metal structures", 11 },
                    { 35, 263, "Houses and buildings", 11 },
                    { 36, 267, "Metal products", 11 },
                    { 37, 542, "Metal works", 11 },
                    { 38, 75, "CNC-machining", 542 },
                    { 39, 62, "Forgings, Fasteners", 542 },
                    { 40, 69, "Gas, Plasma, Laser cutting", 542 },
                    { 41, 66, "MIG, TIG, Aluminum welding", 542 },
                    { 42, 9, "Plastic and Rubber", 1 },
                    { 43, 54, "Packaging", 9 },
                    { 44, 556, "Plastic goods", 9 },
                    { 45, 559, "Plastic processing technology", 9 },
                    { 46, 55, "Blowing", 559 },
                    { 47, 57, "Moulding", 559 },
                    { 48, 53, "Plastics welding and processing", 559 },
                    { 49, 560, "Plastic profiles", 9 },
                    { 50, 5, "Printing ", 1 },
                    { 51, 148, "Advertising ", 5 },
                    { 52, 150, "Book/Periodicals printing", 5 },
                    { 53, 145, "Labelling and packaging printing", 5 },
                    { 54, 7, "Textile and Clothing", 1 },
                    { 55, 44, "Clothing", 7 },
                    { 56, 45, "Textile", 7 },
                    { 57, 8, "Wood", 1 },
                    { 58, 51, "Wooden building materials", 8 },
                    { 59, 47, "Wooden houses", 8 },
                    { 60, 337, "Other", 8 },
                    { 61, 2, "Service", 0 },
                    { 62, 25, "Business services", 2 },
                    { 63, 35, "Engineering", 2 },
                    { 64, 28, "Information Technology and Telecommunications", 2 },
                    { 65, 581, "Data processing, Web portals, E-marketing", 28 },
                    { 66, 576, "Programming, Consultancy", 28 },
                    { 67, 121, "Software, Hardware", 28 },
                    { 68, 122, "Telecommunications", 28 },
                    { 69, 22, "Tourism", 2 },
                    { 70, 141, "Translation services", 2 },
                    { 71, 21, "Transport and Logistics", 2 },
                    { 72, 111, "Air", 21 },
                    { 73, 114, "Rail", 21 },
                    { 74, 112, "Road", 21 },
                    { 75, 113, "Water", 21 },
                    { 76, 3, "Other", 0 },
                    { 77, 37, "Creative industries", 3 },
                    { 78, 29, "Energy technology", 3 },
                    { 79, 33, "Environment", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "sector_sector_id_key",
                table: "sector",
                column: "sector_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_sector_sector_id",
                table: "user_sector",
                column: "sector_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_sector_user_id",
                table: "user_sector",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_sector");

            migrationBuilder.DropTable(
                name: "sector");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
