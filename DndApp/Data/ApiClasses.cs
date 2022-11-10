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

    public class Monster
    {

        public class Rootobject
        {
            public string index { get; set; }
            public string name { get; set; }
            public string size { get; set; }
            public string type { get; set; }
            public string alignment { get; set; }
            public int armor_class { get; set; }
            public int hit_points { get; set; }
            public string hit_dice { get; set; }
            public string hit_points_roll { get; set; }
            public Speed speed { get; set; }
            public int strength { get; set; }
            public int dexterity { get; set; }
            public int constitution { get; set; }
            public int intelligence { get; set; }
            public int wisdom { get; set; }
            public int charisma { get; set; }
            public Proficiency[] proficiencies { get; set; }
            public object[] damage_vulnerabilities { get; set; }
            public object[] damage_resistances { get; set; }
            public object[] damage_immunities { get; set; }
            public object[] condition_immunities { get; set; }
            public Senses senses { get; set; }
            public string languages { get; set; }
            public int challenge_rating { get; set; }
            public int xp { get; set; }
            public Special_Abilities[] special_abilities { get; set; }
            public Action[] actions { get; set; }
            public Legendary_Actions[] legendary_actions { get; set; }
            public string url { get; set; }
        }

        public class Speed
        {
            public string walk { get; set; }
            public string swim { get; set; }
        }

        public class Senses
        {
            public string darkvision { get; set; }
            public int passive_perception { get; set; }
        }

        public class Proficiency
        {
            public int value { get; set; }
            public Proficiency1 proficiency { get; set; }
        }

        public class Proficiency1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Special_Abilities
        {
            public string name { get; set; }
            public string desc { get; set; }
            public Dc dc { get; set; }
        }

        public class Dc
        {
            public Dc_Type dc_type { get; set; }
            public int dc_value { get; set; }
            public string success_type { get; set; }
        }

        public class Dc_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Action
        {
            public string name { get; set; }
            public string multiattack_type { get; set; }
            public string desc { get; set; }
            public Action1[] actions { get; set; }
            public int attack_bonus { get; set; }
            public Dc1 dc { get; set; }
            public Damage[] damage { get; set; }
            public Usage usage { get; set; }
        }

        public class Dc1
        {
            public Dc_Type1 dc_type { get; set; }
            public int dc_value { get; set; }
            public string success_type { get; set; }
        }

        public class Dc_Type1
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Usage
        {
            public string type { get; set; }
            public int times { get; set; }
        }

        public class Action1
        {
            public string action_name { get; set; }
            public int count { get; set; }
            public string type { get; set; }
        }

        public class Damage
        {
            public Damage_Type damage_type { get; set; }
            public string damage_dice { get; set; }
        }

        public class Damage_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Legendary_Actions
        {
            public string name { get; set; }
            public string desc { get; set; }
            public int attack_bonus { get; set; }
            public Damage1[] damage { get; set; }
        }

        public class Damage1
        {
            public Damage_Type1 damage_type { get; set; }
            public string damage_dice { get; set; }
        }

        public class Damage_Type1
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
            public Damage_At_Slot_Level damage_at_slot_level { get; set; }
        }

        public class Damage_Type
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
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

}
