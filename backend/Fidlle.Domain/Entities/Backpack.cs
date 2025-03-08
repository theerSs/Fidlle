namespace Fidlle.Domain.Entities
{
    public class Backpack
    {
        public Guid Id { get; set; }
        public required Guid CharacterId { get; set; }
        public int Capacity { get; set; } = 42;
        public virtual required Character Character { get; set; }
        public virtual required ICollection<Item> Items { get; set; }
    }
}
