using System.ComponentModel.DataAnnotations;

namespace DndApp.Data
{
    public class UserCharacterInfo
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Race { get; set; }
        [Range(0,9999)]
        public int? Age { get; set; }
        [Required, Range(3,18)]
        public int Charisma { get; set; }
        [Required, Range(3,18)]
        public int Intelligence { get; set; }
        [Required, Range(3,18)]
        public int Strength { get; set; }
        [Required, Range(3, 18)]
        public int Dexterity { get; set; }
        [Required, Range(3, 18)]
        public int Constitution { get; set; }
        [Required, Range(3, 18)]
        public int Wisdom { get; set; }
    }
}
