namespace Fidlle.Domain.Entities
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public required Guid CharacterId { get; set; }
        public required int Capacity { get; set; }
        public virtual required Character Character { get; set; }
        public virtual required ICollection<Item> Items { get; set; }
    }
}
