namespace Fidlle.Domain.Entities
{
    public class Character
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Class { get; set; }
        public int Level { get; set; } = 1;
        public Guid UserId { get; set; }
        public required User User { get; set; }
    }
}
