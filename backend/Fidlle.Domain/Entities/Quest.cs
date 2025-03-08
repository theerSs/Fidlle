using Fidlle.Domain.Enums;

namespace Fidlle.Domain.Entities
{
    public class Quest
    {
        public Guid Id { get; set; }
        public required Guid CharacterId { get; set; }
        public required Guid TraderQuestId { get; set; }
        public QuestStatus Status { get; set; }
        public DateTime? DateAccepted { get; set; }
        public DateTime? DateCompleted { get; set; }

        public virtual required Character Character { get; set; }
        public virtual required TraderQuest TraderQuest { get; set; }
    }
}
