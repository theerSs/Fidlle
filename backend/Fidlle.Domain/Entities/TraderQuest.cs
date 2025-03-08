using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fidlle.Domain.Entities
{
    public class TraderQuest
    {
        public Guid Id { get; set; }
        public required Guid TraderId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required float ReputationReward { get; set; }

        public virtual required Trader Trader { get; set; }
        public virtual required ICollection<Quest> Quests { get; set; }
    }
}
