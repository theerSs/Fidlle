namespace Fidlle.Application.DTO
{
    public class CharacterListItemDto
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Class { get; set; }
        public required int Level { get; set; }
    }
}
