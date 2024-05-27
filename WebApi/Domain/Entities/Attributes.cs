using Domain.Commun;

namespace Domain.Entities
{
    public class Attributes : BaseEntity
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Attributes attributes &&
                   Id == attributes.Id &&
                   strength == attributes.strength &&
                   dexterity == attributes.dexterity &&
                   constitution == attributes.constitution &&
                   intelligence == attributes.intelligence &&
                   wisdom == attributes.wisdom &&
                   charisma == attributes.charisma;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, strength, dexterity, constitution, intelligence, wisdom, charisma);
        }
    }
}
