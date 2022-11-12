using System.Text.Json.Serialization;
namespace DndApp.Data
{


    public class ApiClasses
    {

        public class Rootobject
        {
            [JsonIgnore]
            public int count { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }

    public class Spell
    {

        public class Rootobject
        {
            public string _id { get; set; }
            public string index { get; set; }
            public string name { get; set; }
            public string[] desc { get; set; }
            public string[] higher_level { get; set; }
            public string range { get; set; }
            public string[] components { get; set; }
            public string material { get; set; }
            public bool ritual { get; set; }
            public string duration { get; set; }
            public bool concentration { get; set; }
            public string casting_time { get; set; }
            public int level { get; set; }
            public string? attack_type { get; set; }
            public Damage? damage { get; set; }
            public School school { get; set; }
            public Class1[] classes { get; set; }
            public Subclass[] subclasses { get; set; }
            public string url { get; set; }
        }

        public class Damage
        {
            public Damage_Type damage_type { get; set; }
            public Damage_At_Slot_Level? damage_at_slot_level { get; set; }

            public Damage_At_Character_Level? damage_at_character_level { get; set; }
        }

        public class Damage_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
        public class Damage_At_Character_Level
        {
            public string _1 { get; set; }
            public string _5 { get; set; }
            public string _11 { get; set; }
            public string _17 { get; set; }
        }


        public class Damage_At_Slot_Level
        {
            public string _2 { get; set; }
            public string _3 { get; set; }
            public string _4 { get; set; }
            public string _5 { get; set; }
            public string _6 { get; set; }
            public string _7 { get; set; }
            public string _8 { get; set; }
            public string _9 { get; set; }
        }

        public class School
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Class1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Subclass
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }

    public class CharacterClass
    {

        public class Rootobject
        {
            public string index { get; set; }
            public string name { get; set; }
            public int hit_die { get; set; }
            public Proficiency_Choices[] proficiency_choices { get; set; }
            public Proficiency1[] proficiencies { get; set; }
            public Saving_Throws[] saving_throws { get; set; }
            public Starting_Equipment[] starting_equipment { get; set; }
            public Starting_Equipment_Options[] starting_equipment_options { get; set; }
            public string class_levels { get; set; }
            public Multi_Classing multi_classing { get; set; }
            public Subclass[] subclasses { get; set; }
            public Spellcasting spellcasting { get; set; }
            public string spells { get; set; }
            public string url { get; set; }
        }

        public class Multi_Classing
        {
            public Prerequisite[] prerequisites { get; set; }
            public Proficiency[] proficiencies { get; set; }
        }

        public class Prerequisite
        {
            public Ability_Score ability_score { get; set; }
            public int minimum_score { get; set; }
        }

        public class Ability_Score
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Proficiency
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Spellcasting
        {
            public int level { get; set; }
            public Spellcasting_Ability spellcasting_ability { get; set; }
            public Info[] info { get; set; }
        }

        public class Spellcasting_Ability
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Info
        {
            public string name { get; set; }
            public string[] desc { get; set; }
        }

        public class Proficiency_Choices
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class From
        {
            public string option_set_type { get; set; }
            public Option[] options { get; set; }
        }

        public class Option
        {
            public string option_type { get; set; }
            public Item item { get; set; }
        }

        public class Item
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Proficiency1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Saving_Throws
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Starting_Equipment
        {
            public Equipment equipment { get; set; }
            public int quantity { get; set; }
        }

        public class Equipment
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Starting_Equipment_Options
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From1 from { get; set; }
        }

        public class From1
        {
            public string option_set_type { get; set; }
            public Option1[] options { get; set; }
            public Equipment_Category equipment_category { get; set; }
        }

        public class Equipment_Category
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Option1
        {
            public string option_type { get; set; }
            public Item1[] items { get; set; }
            public Choice choice { get; set; }
            public int count { get; set; }
            public Of of { get; set; }
        }

        public class Choice
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From2 from { get; set; }
        }

        public class From2
        {
            public string option_set_type { get; set; }
            public Equipment_Category1 equipment_category { get; set; }
        }

        public class Equipment_Category1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Of
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Item1
        {
            public string option_type { get; set; }
            public Choice1 choice { get; set; }
            public int count { get; set; }
            public Of1 of { get; set; }
        }

        public class Choice1
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From3 from { get; set; }
        }

        public class From3
        {
            public string option_set_type { get; set; }
            public Equipment_Category2 equipment_category { get; set; }
        }

        public class Equipment_Category2
        {
            public string name { get; set; }
            public string index { get; set; }
            public string url { get; set; }
        }

        public class Of1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Subclass
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }

    public class Races
    {

        public class Rootobject
        {
            public string index { get; set; }
            public string name { get; set; }
            public int speed { get; set; }
            public Ability_Bonuses[] ability_bonuses { get; set; }
            public string alignment { get; set; }
            public string age { get; set; }
            public string size { get; set; }
            public string size_description { get; set; }
            public Starting_Proficiencies[] starting_proficiencies { get; set; }
            public Starting_Proficiency_Options starting_proficiency_options { get; set; }
            public Language[] languages { get; set; }
            public string language_desc { get; set; }
            public Trait[] traits { get; set; }
            public Subrace[] subraces { get; set; }
            public string url { get; set; }
        }

        public class Starting_Proficiency_Options
        {
            public string desc { get; set; }
            public int choose { get; set; }
            public string type { get; set; }
            public From from { get; set; }
        }

        public class From
        {
            public string option_set_type { get; set; }
            public Option[] options { get; set; }
        }

        public class Option
        {
            public string option_type { get; set; }
            public Item item { get; set; }
        }

        public class Item
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Ability_Bonuses
        {
            public Ability_Score ability_score { get; set; }
            public int bonus { get; set; }
        }

        public class Ability_Score
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Starting_Proficiencies
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Language
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Trait
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Subrace
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }

}
