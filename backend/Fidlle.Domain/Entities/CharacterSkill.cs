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
        public required string SkillName { get; set; }
        public required int Level { get; set; }

        public virtual required Character Character { get; set; }
    }
}
