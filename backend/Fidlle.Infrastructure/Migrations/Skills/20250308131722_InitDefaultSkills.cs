using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fidlle.Infrastructure.Migrations.Skills
{
    /// <inheritdoc />
    public partial class InitDefaultSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    MaxLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "MaxLevel", "Name" },
                values: new object[,]
                {
                    { new Guid("10101010-1010-1010-1010-101010101010"), "Enhances crafting of leather-based items.", 30, "Leatherworking" },
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Increases your physical power.", 30, "Strength" },
                    { new Guid("20202020-2020-2020-2020-202020202020"), "Increases efficiency in cutting trees and gathering wood.", 30, "Woodcutting" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Improves your resistance to damage.", 30, "Defence" },
                    { new Guid("30303030-3030-3030-3030-303030303030"), "Enhances gathering and utilization of herbs.", 30, "Herbalism" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Determines your health capacity.", 30, "Hitpoints" },
                    { new Guid("40404040-4040-4040-4040-404040404040"), "Improves proficiency in extracting ores and minerals.", 30, "Mining" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Enhances close combat efficiency.", 30, "Melee" },
                    { new Guid("50505050-5050-5050-5050-505050505050"), "Allows gathering of resources from animals.", 30, "Skinning" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Improves ranged weapon accuracy and damage.", 30, "Ranged" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Improves your spellcasting abilities.", 30, "Magic" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "Increases proficiency in ceremonial practices.", 30, "Rituals" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Enhances ability to carve mystical runes.", 30, "Rune Carving" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "Improves potion-making and transmutation skills.", 30, "Alchemy" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Increases proficiency in writing magical scrolls.", 30, "Scrolls Writing" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Improves the ability to summon creatures or entities.", 30, "Summoning" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Enhances crafting of weapons and armor.", 30, "Smithing" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Improves culinary skills and crafting food.", 30, "Cooking" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Increases proficiency in crafting wooden items.", 30, "Woodworking" },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), "Improves crafting of fabric-based items.", 30, "Tailoring" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
