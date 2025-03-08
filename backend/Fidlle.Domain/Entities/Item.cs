using Fidlle.Domain.Enums;

namespace Fidlle.Domain.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required ItemType ItemType { get; set; }
        public required int StrengthModifier { get; set; }
        public required int DexterityModifier { get; set; }
        public required int IntelligenceModifier { get; set; }
        public required int ManaModifier { get; set; }
        public required int HealthModifier { get; set; }
        public required int DamageModifier { get; set; }
    }
}
