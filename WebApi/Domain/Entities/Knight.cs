using Domain.Commun;

namespace Domain.Entities
{
    public class Knight : BaseEntity
    {

        public string Name { get; set; }
        public string? NickName { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public List<Weapon> Weapons { get; set; }

        public Attributes Attributes { get; set; }

        public string KeyAttribute { get; set; }
        public bool IsHero { get; set; }



        public Knight()
        {
            Weapons = new List<Weapon>();
            Attributes = new Attributes();
        }

        public override bool Equals(object? obj)
        {
            return obj is Knight knight &&
                   Id == knight.Id &&
                   Name == knight.Name &&
                   NickName == knight.NickName &&
                   Birthday.Equals(knight.Birthday) &&
                   KeyAttribute == knight.KeyAttribute;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, NickName, Birthday, KeyAttribute);
        }
    }
}
