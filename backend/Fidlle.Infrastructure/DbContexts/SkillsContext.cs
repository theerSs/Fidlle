using Fidlle.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fidlle.Infrastructure.DbContexts
{
    public class SkillsContext(DbContextOptions<SkillsContext> options) : DbContext(options)
    {
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Skill>().HasData(
                    new Skill { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Strength", Description = "Increases your physical power." },
                    new Skill { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Defence", Description = "Improves your resistance to damage." },
                    new Skill { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Hitpoints", Description = "Determines your health capacity." },
                    new Skill { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Melee", Description = "Enhances close combat efficiency." },
                    new Skill { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), Name = "Ranged", Description = "Improves ranged weapon accuracy and damage." },
                    new Skill { Id = Guid.Parse("66666666-6666-6666-6666-666666666666"), Name = "Magic", Description = "Improves your spellcasting abilities." },
                    new Skill { Id = Guid.Parse("77777777-7777-7777-7777-777777777777"), Name = "Rituals", Description = "Increases proficiency in ceremonial practices." },
                    new Skill { Id = Guid.Parse("88888888-8888-8888-8888-888888888888"), Name = "Rune Carving", Description = "Enhances ability to carve mystical runes." },
                    new Skill { Id = Guid.Parse("99999999-9999-9999-9999-999999999999"), Name = "Alchemy", Description = "Improves potion-making and transmutation skills." },
                    new Skill { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), Name = "Scrolls Writing", Description = "Increases proficiency in writing magical scrolls." },
                    new Skill { Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), Name = "Summoning", Description = "Improves the ability to summon creatures or entities." },
                    new Skill { Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), Name = "Smithing", Description = "Enhances crafting of weapons and armor." },
                    new Skill { Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"), Name = "Cooking", Description = "Improves culinary skills and crafting food." },
                    new Skill { Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), Name = "Woodworking", Description = "Increases proficiency in crafting wooden items." },
                    new Skill { Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"), Name = "Tailoring", Description = "Improves crafting of fabric-based items." },
                    new Skill { Id = Guid.Parse("10101010-1010-1010-1010-101010101010"), Name = "Leatherworking", Description = "Enhances crafting of leather-based items." },
                    new Skill { Id = Guid.Parse("20202020-2020-2020-2020-202020202020"), Name = "Woodcutting", Description = "Increases efficiency in cutting trees and gathering wood." },
                    new Skill { Id = Guid.Parse("30303030-3030-3030-3030-303030303030"), Name = "Herbalism", Description = "Enhances gathering and utilization of herbs." },
                    new Skill { Id = Guid.Parse("40404040-4040-4040-4040-404040404040"), Name = "Mining", Description = "Improves proficiency in extracting ores and minerals." },
                    new Skill { Id = Guid.Parse("50505050-5050-5050-5050-505050505050"), Name = "Skinning", Description = "Allows gathering of resources from animals." }
                );

        }
    }
}

