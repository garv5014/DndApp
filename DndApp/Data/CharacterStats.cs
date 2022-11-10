namespace DndApp.Data
{
    public class CharacterStats : UserCharacterInfo
    {
        public CharacterStats(UserCharacterInfo characterInfo)
        {
            this.Name = characterInfo.Name;
            this.Age= characterInfo.Age;
            this.Intelligence= characterInfo.Intelligence;
            this.Wisdom= characterInfo.Wisdom;
            this.Dexterity= characterInfo.Dexterity;
            this.Strength= characterInfo.Strength;
            this.Charisma= characterInfo.Charisma;
            this.Constitution = characterInfo.Constitution;
            intelligence_Mod = calculateModifier(characterInfo.Intelligence);
            wisdom_Mod = calculateModifier(characterInfo.Wisdom);
            dexterity_Mod = calculateModifier(characterInfo.Dexterity);
            strength_Mod = calculateModifier(characterInfo.Strength);
            charisma_Mod = calculateModifier(characterInfo.Charisma);
            constitution_Mod = calculateModifier(characterInfo.Constitution);
            armor_Class = 10 + dexterity_Mod;
            initiative_Mod = dexterity_Mod;
        }
        public int initiative_Mod { get; set; }
        public int hp { get; set; }
        public int speed { get; set; }
        public int armor_Class { get; set; }
        public int intelligence_Mod { get; set; }
        public int strength_Mod { get; set; }
        public int dexterity_Mod { get; set; }
        public int constitution_Mod { get; set; }
        public int charisma_Mod { get; set; }
        public int wisdom_Mod { get; set; }

        private int calculateModifier(int num)
        {
            return (num - 10) * 2;
        }
    }
}
