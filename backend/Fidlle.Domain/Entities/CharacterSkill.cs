using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fidlle.Domain.Entities
{
    public class CharacterSkill
    {
        public Guid Id { get; set; }
        public required Guid CharacterId { get; set; }
        public required Guid SkillId { get; set; }
        public required int Level { get; set; } = 1;

        public virtual required Character Character { get; set; }
        public virtual required Skill Skill { get; set; }
    }
}
