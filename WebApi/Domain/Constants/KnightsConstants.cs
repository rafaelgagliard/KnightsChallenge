namespace Domain.Constants
{
    public static class KnightsConstants
    {
        public static int MinAgeToStartExperience { get => 7; }

        public static List<string> Attributes
        {
            get => new List<string>() {
                "strength", "dexterity", "constitution", "intelligence", "wisdom", "charisma"
            };
        }
    }
}
