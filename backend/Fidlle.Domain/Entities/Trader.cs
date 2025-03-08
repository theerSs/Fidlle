namespace Fidlle.Domain.Entities
{
    public class Trader
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public virtual required ICollection<TraderQuest> Quests { get; set; }
    }
}
