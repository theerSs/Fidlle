namespace Fidlle.Domain.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public int MaxLevel { get; set; } = 30;
    }
}
