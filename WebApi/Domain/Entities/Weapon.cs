using Domain.Commun;

namespace Domain.Entities
{
    public class Weapon : BaseEntity
    {
        public string Name { get; set; }
        public int Mod { get; set; }
        public string Attr { get; set; }
        public bool Equipped { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Weapon weapon &&
                   Id == weapon.Id &&
                   Name == weapon.Name &&
                   Mod == weapon.Mod &&
                   Attr == weapon.Attr &&
                   Equipped == weapon.Equipped;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Mod, Attr, Equipped);
        }
    }
}
