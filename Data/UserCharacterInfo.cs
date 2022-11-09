namespace DndApp.Data
{
    public class UserCharacterInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public string Class { get; set; }
        public string Race { get; set; }
        public int? Age { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
    }
}
