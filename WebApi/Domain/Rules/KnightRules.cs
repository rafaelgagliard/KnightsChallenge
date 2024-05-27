using Domain.Entities;

namespace Domain.Rules
{
    public static class KnightRules
    {
        public static int Atack(this Knight knight) =>
            10 + GetKnightAttribute(knight) + knight.Weapons.Where(c => c.Equipped).Sum(s => s.Mod.AdjustMod());


        public static double Experience(this Knight knight) =>
            knight.Age() >= 7 ? Math.Floor((knight.Age() - 7) * Math.Pow(22, 1.45)) : 0;

        public static int Age(this Knight knight) =>
            DateTimeOffset.Now.Year - knight.Birthday.Year;

        private static int GetKnightAttribute(Knight knight)
        {
            switch (knight.KeyAttribute)
            {
                case "strength":
                    return knight.Attributes.strength;
                case "dexterity":
                    return knight.Attributes.dexterity;
                case "constitution":
                    return knight.Attributes.constitution;
                case "intelligence":
                    return knight.Attributes.intelligence;
                case "wisdom":
                    return knight.Attributes.wisdom;
                case "charisma":
                    return knight.Attributes.charisma;
                default:
                    return 0;
            }
        }


        private static int AdjustMod(this int originalMod)
        {
            if (originalMod.Between(0, 8)) return -2;
            else if (originalMod.Between(9, 10)) return -1;
            else if (originalMod.Between(11, 12)) return 0;
            else if (originalMod.Between(13, 15)) return 1;
            else if (originalMod.Between(16, 18)) return 2;
            else if (originalMod.Between(19, 20)) return 3;
            else return 0;
        }


        private static bool Between(this int number, int startNumber, int endNumber) =>
            number >= startNumber && number <= endNumber;
    }
}