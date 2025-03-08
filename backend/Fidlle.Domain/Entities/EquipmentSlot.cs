using Fidlle.Domain.Enums;

namespace Fidlle.Domain.Entities
{
    public class EquipmentSlot
    {
        public Guid Id { get; set; }
        public required Guid CharacterId { get; set; }
        public SlotType SlotType { get; set; }
        public int? ItemId { get; set; }
        public virtual required Character Character { get; set; }
        public virtual Item? Item { get; set; }
    }
}
