namespace Fidlle.Domain.Entities
{
    public class Character
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required Guid UserId { get; set; }
        public virtual required User User { get; set; }
        public virtual required ICollection<CharacterSkill> Skills { get; set; } 
        public virtual required Inventory Inventory { get; set; }
        public virtual required Backpack Backpack { get; set; }
        public virtual required ICollection<EquipmentSlot> EquipmentSlots { get; set; }
        public virtual required ICollection<Quest> Quest { get; set; }

        public int Level => Skills.Sum(s => s.Level);
    }
}
