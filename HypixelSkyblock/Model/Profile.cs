using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.Model
{
    public class Profile
    {
        //JSON data here
        //[JsonProperty(PropertyName = "id")]

        [JsonProperty(PropertyName = "profile_id")]
        public string id {  get; set; }

        [JsonProperty(PropertyName = "coin_purse")]
        public float coin_purse { get; set; }

        [JsonProperty(PropertyName = "cute_name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "selected")]
        public bool is_selected { get; set; }


        //public Stats stats { get; set; } //TODO FINISH THIS
        public List<Pet> pets { get; set; }
        public List<Quest> quests { get; set; }



        //lists--------------
        //Dungeon information


        //Single digit information-------------------
        //Fishing treasure caught
        //Collection


    }


    public class Dungeon
    {
        //TODO complete this
        //List of dungeons types
        //List of player classes
        
        public string Selected_Dungeon_Class { get; set; }
    }

    public class Quest
    {
        public string name { get; set; }
        public string status { get; set; }
    }

    public class Pet
    {
        [JsonProperty(PropertyName = "uuid")]
        public string uuid { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }

        [JsonProperty(PropertyName = "exp")]
        public float exp { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool active { get; set; }

        [JsonProperty(PropertyName = "tier")]
        public string tier { get; set; }

        //HeldItem
        //candyUsed
        //skin
    }

    public class Stats
    {
        public Stats_Kills kills { get; set; }
        public Stats_Deaths deaths { get; set; }
        public Stats_Auction auction { get; set; }

        [JsonProperty(PropertyName = "highest_critical_damage")]
        public float Highest_Critical_Damage { get; set; }

        [JsonProperty(PropertyName = "highest_damage")]
        public float Highest_Damage { get; set; }

        [JsonProperty(PropertyName = "items_fished")]
        public int Items_Fished { get; set; }

        [JsonProperty(PropertyName = "items_fished_treasure")]
        public int Items_Fished_Treasure { get; set; }

        [JsonProperty(PropertyName = "items_fished_large_treasure")]
        public int Items_Fished_Large_Treasure { get; set; }

    }

    public class Stats_Kills
    {
        //TODO improve this code... maybe get prefix of kills_ out of JSON and extract data that way?
        [JsonProperty(PropertyName = "kills")]
        public int Kills { get; set; }

        [JsonProperty(PropertyName = "kills_zombie_villager")]
        public int kills_zombie_villager { get; set; }

        [JsonProperty(PropertyName = "kills_zombie")]
        public int kills_zombie { get; set; }

        [JsonProperty(PropertyName = "kills_spider")]
        public int kills_spider { get; set; }

        [JsonProperty(PropertyName = "kills_skeleton")]
        public int kills_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_enderman")]
        public int kills_enderman { get; set; }

        [JsonProperty(PropertyName = "kills_witch")]
        public int kills_witch { get; set; }

        [JsonProperty(PropertyName = "kills_cow")]
        public int kills_cow { get; set; }

        [JsonProperty(PropertyName = "kills_chicken")]
        public int kills_chicken { get; set; }

        [JsonProperty(PropertyName = "kills_pig")]
        public int kills_pig { get; set; }

        [JsonProperty(PropertyName = "kills_lapis_zombie")]
        public int kills_lapis_zombie { get; set; }

        [JsonProperty(PropertyName = "kills_emerald_slime")]
        public int kills_emerald_slime { get; set; }

        [JsonProperty(PropertyName = "kills_redstone_pigman")]
        public int kills_redstone_pigman { get; set; }

        [JsonProperty(PropertyName = "kills_invisible_creeper")]
        public int kills_invisible_creeper { get; set; }

        [JsonProperty(PropertyName = "kills_pond_squid")]
        public int kills_pond_squid { get; set; }

        [JsonProperty(PropertyName = "kills_dasher_spider")]
        public int kills_dasher_spider { get; set; }

        [JsonProperty(PropertyName = "kills_splitter_spider")]
        public int kills_splitter_spider { get; set; }

        [JsonProperty(PropertyName = "kills_splitter_spider_silverfish")]
        public int kills_splitter_spider_silverfish { get; set; }

        [JsonProperty(PropertyName = "kills_jockey_skeleton")]
        public int kills_jockey_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_jockey_shot_silverfish")]
        public int kills_jockey_shot_silverfish { get; set; }

        [JsonProperty(PropertyName = "kills_weaver_spider")]
        public int kills_weaver_spider { get; set; }

        [JsonProperty(PropertyName = "kills_spider_jockey")]
        public int kills_spider_jockey { get; set; }

        [JsonProperty(PropertyName = "kills_respawning_skeleton")]
        public int kills_respawning_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_rabbit")]
        public int kills_rabbit { get; set; }

        [JsonProperty(PropertyName = "kills_sheep")]
        public int kills_sheep { get; set; }

        [JsonProperty(PropertyName = "kills_voracious_spider")]
        public int kills_voracious_spider { get; set; }

        [JsonProperty(PropertyName = "kills_wither_skeleton")]
        public int kills_wither_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_diamond_zombie")]
        public int kills_diamond_zombie { get; set; }

        [JsonProperty(PropertyName = "kills_diamond_skeleton")]
        public int kills_diamond_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_sea_guardian")]
        public int kills_sea_guardian { get; set; }

        [JsonProperty(PropertyName = "kills_cave_spider")]
        public int kills_cave_spider { get; set; }

        [JsonProperty(PropertyName = "kills_forest_island_bat")]
        public int kills_forest_island_bat { get; set; }

        [JsonProperty(PropertyName = "kills_random_slime")]
        public int kills_random_slime { get; set; }

        [JsonProperty(PropertyName = "kills_blaze")]
        public int kills_blaze { get; set; }

        [JsonProperty(PropertyName = "kills_magma_cube")]
        public int kills_magma_cube { get; set; }

        [JsonProperty(PropertyName = "kills_pigman")]
        public int kills_pigman { get; set; }

        [JsonProperty(PropertyName = "kills_unburried_zombie")]
        public int kills_unburried_zombie { get; set; }

        [JsonProperty(PropertyName = "kills_sea_walker")]
        public int kills_sea_walker { get; set; }

        [JsonProperty(PropertyName = "kills_nurse_shark")]
        public int kills_nurse_shark { get; set; }

        [JsonProperty(PropertyName = "kills_sea_archer")]
        public int kills_sea_archer { get; set; }

        [JsonProperty(PropertyName = "kills_liquid_hot_magma")]
        public int kills_liquid_hot_magma { get; set; }

        [JsonProperty(PropertyName = "kills_sea_witch")]
        public int kills_sea_witch { get; set; }

        [JsonProperty(PropertyName = "kills_zombie_deep")]
        public int kills_zombie_deep { get; set; }

        [JsonProperty(PropertyName = "kills_pack_spirit")]
        public int kills_pack_spirit { get; set; }

        [JsonProperty(PropertyName = "kills_watcher")]
        public int kills_watcher { get; set; }

        [JsonProperty(PropertyName = "kills_endermite")]
        public int kills_endermite { get; set; }

        [JsonProperty(PropertyName = "kills_obsidian_wither")]
        public int kills_obsidian_wither { get; set; }

        [JsonProperty(PropertyName = "kills_zealot_enderman")]
        public int kills_zealot_enderman { get; set; }

        [JsonProperty(PropertyName = "kills_catfish")]
        public int kills_catfish { get; set; }

        [JsonProperty(PropertyName = "kills_fireball_magma_cube")]
        public int kills_fireball_magma_cube { get; set; }

        [JsonProperty(PropertyName = "kills_bat_pinata")]
        public int kills_bat_pinata { get; set; }

        [JsonProperty(PropertyName = "kills_blue_shark")]
        public int kills_blue_shark { get; set; }

        [JsonProperty(PropertyName = "kills_frozen_steve")]
        public int kills_frozen_steve { get; set; }

        [JsonProperty(PropertyName = "kills_frosty_the_snowman")]
        public int kills_frosty_the_snowman { get; set; }

        [JsonProperty(PropertyName = "kills_minos_hunter")]
        public int kills_minos_hunter { get; set; }

        [JsonProperty(PropertyName = "kills_dungeon_respawning_skeleton")]
        public int kills_dungeon_respawning_skeleton { get; set; }

        [JsonProperty(PropertyName = "kills_creeper")]
        public int kills_creeper { get; set; }

        [JsonProperty(PropertyName = "kills_ghast")]
        public int kills_ghast { get; set; }

        [JsonProperty(PropertyName = "kills_crypt_lurker")]
        public int kills_crypt_lurker { get; set; }

        [JsonProperty(PropertyName = "kills_zombie_grunt")]
        public int kills_zombie_grunt { get; set; }

        [JsonProperty(PropertyName = "kills_watcher_summon_undead")]
        public int kills_watcher_summon_undead { get; set; }

        [JsonProperty(PropertyName = "kills_crypt_dreadlord")]
        public int kills_crypt_dreadlord { get; set; }

        [JsonProperty(PropertyName = "kills_ruin_wolf")]
        public int kills_ruin_wolf { get; set; }

        [JsonProperty(PropertyName = "kills_old_wolf")]
        public int kills_old_wolf { get; set; }

        [JsonProperty(PropertyName = "kills_howling_spirit")]
        public int kills_howling_spirit { get; set; }

        [JsonProperty(PropertyName = "kills_soul_of_the_alpha")]
        public int kills_soul_of_the_alpha { get; set; }

        [JsonProperty(PropertyName = "kills_sea_leech")]
        public int kills_sea_leech { get; set; }

        [JsonProperty(PropertyName = "kills_guardian_defender")]
        public int kills_guardian_defender { get; set; }

        [JsonProperty(PropertyName = "kills_tiger_shark")]
        public int kills_tiger_shark { get; set; }

        [JsonProperty(PropertyName = "kills_water_hydra")]
        public int kills_water_hydra { get; set; }

        [JsonProperty(PropertyName = "kills_deep_sea_protector")]
        public int kills_deep_sea_protector { get; set; }

        [JsonProperty(PropertyName = "kills_brood_mother_spider")]
        public int kills_brood_mother_spider { get; set; }

        [JsonProperty(PropertyName = "kills_brood_mother_cave_spider")]
        public int kills_brood_mother_cave_spider { get; set; }

        [JsonProperty(PropertyName = "kills_wither_gourd")]
        public int kills_wither_gourd { get; set; }

        [JsonProperty(PropertyName = "kills_wraith")]
        public int kills_wraith { get; set; }

        [JsonProperty(PropertyName = "kills_scary_jerry")]
        public int kills_scary_jerry { get; set; }

        [JsonProperty(PropertyName = "kills_trick_or_treater")]
        public int kills_trick_or_treater { get; set; }

        [JsonProperty(PropertyName = "kills_phantom_spirit")]
        public int kills_phantom_spirit { get; set; }

        [JsonProperty(PropertyName = "kills_bat_spooky")]
        public int kills_bat_spooky { get; set; }

        [JsonProperty(PropertyName = "kills_skeleton_emperor")]
        public int kills_skeleton_emperor { get; set; }

        [JsonProperty(PropertyName = "kills_scarecrow")]
        public int kills_scarecrow { get; set; }

        [JsonProperty(PropertyName = "kills_werewolf")]
        public int kills_werewolf { get; set; }

        [JsonProperty(PropertyName = "kills_nightmare")]
        public int kills_nightmare { get; set; }

        [JsonProperty(PropertyName = "kills_night_squid")]
        public int kills_night_squid { get; set; }

        [JsonProperty(PropertyName = "kills_carrot_king")]
        public int kills_carrot_king { get; set; }

        [JsonProperty(PropertyName = "kills_phantom_fisherman")]
        public int kills_phantom_fisherman { get; set; }

        [JsonProperty(PropertyName = "kills_grim_reaper")]
        public int kills_grim_reaper { get; set; }

        [JsonProperty(PropertyName = "kills_batty_witch")]
        public int kills_batty_witch { get; set; }

        [JsonProperty(PropertyName = "kills_generator_slime")]
        public int kills_generator_slime { get; set; }
    }
    
    public class Stats_Deaths
    {
        public int deaths { get; set; }
        public int deaths_zombie_villager { get; set; }
        public int deaths_zombie { get; set; }
        public int deaths_skeleton { get; set; }
        public int deaths_player { get; set; }
        public int deaths_void { get; set; }
        public int deaths_lapis_zombie { get; set; }
        public int deaths_diamond_zombie { get; set; }
        public int deaths_redstone_pigman { get; set; }
        public int deaths_voracious_spider { get; set; }
        public int deaths_wither_skeleton { get; set; }
        public int deaths_spider { get; set; }
        public int deaths_diamond_skeleton { get; set; }
        public int deaths_sea_guardian { get; set; }
        public int deaths_fire { get; set; }
        public int deaths_cave_spider { get; set; }
        public int deaths_sea_witch { get; set; }
        public int deaths_liquid_hot_magma { get; set; }
        public int deaths_sea_archer { get; set; }
        public int deaths_enderman { get; set; }
        public int deaths_zealot_enderman { get; set; }
        public int deaths_fall { get; set; }
        public int deaths_catfish { get; set; }
        public int deaths_zombie_deep { get; set; }
        public int deaths_unburried_zombie { get; set; }
        public int deaths_splitter_spider { get; set; }
        public int deaths_lost_adventurer { get; set; }
        public int deaths_crypt_undead_alexander { get; set; }
        public int deaths_scared_skeleton { get; set; }
        public int deaths_sniper_skeleton { get; set; }
        public int deaths_crypt_souleater { get; set; }
        public int deaths_watcher_summon_undead { get; set; }
        public int deaths_old_dragon { get; set; }
        public int deaths_young_dragon { get; set; }
        public int deaths_crypt_lurker { get; set; }
        public int deaths_dungeon_respawning_skeleton { get; set; }
        public int deaths_crypt_dreadlord { get; set; }
        public int deaths_skeleton_grunt { get; set; }
        public int deaths_bonzo_summon_undead { get; set; }
        public int deaths_bonzo { get; set; }
        public int deaths_zombie_grunt { get; set; }
        public int deaths_scarf_mage { get; set; }
        public int deaths_wise_dragon { get; set; }
        public int deaths_endermite { get; set; }
        public int deaths_guardian_defender { get; set; }
        public int deaths_deep_sea_protector { get; set; }
        public int deaths_diamond_guy { get; set; }
        public int deaths_skeleton_soldier { get; set; }
        public int deaths_scarf { get; set; }
        public int deaths_old_wolf { get; set; }
        public int deaths_trick_or_treater { get; set; }
        public int deaths_phantom_spirit { get; set; }
        public int deaths_scary_jerry { get; set; }
        public int deaths_tiger_shark { get; set; }
        public int deaths_wraith { get; set; }
        public int deaths_unknown { get; set; }
    }

    public class Stats_Auction
    {
        public int auctions_created { get; set; }
        public int auctions_fees { get; set; }
        public int auctions_no_bids { get; set; }
        public int auctions_completed { get; set; }
        public int auctions_sold_uncommon { get; set; }
        public int auctions_gold_earned { get; set; }
        public int auctions_bids { get; set; }
        public int auctions_highest_bid { get; set; }
        public int auctions_won { get; set; }
        public int auctions_bought_epic { get; set; }
        public int auctions_gold_spent { get; set; }
        public int auctions_bought_legendary { get; set; }
        public int auctions_bought_uncommon { get; set; }
        public int auctions_sold_epic { get; set; }
        public int auctions_bought_common { get; set; }
        public int auctions_bought_rare { get; set; }
        public int auctions_sold_rare { get; set; }
        public int auctions_sold_legendary { get; set; }
        public int auctions_sold_common { get; set; }
    }

    public class Collection
    {
        //TODO how to make this smart?
    }


    public class User
    {
        public string UUID { get; set; }
        public string userName { get; set; }
        public string texture { get; set; }

        List<string> profile_ID = new List<string>();
    }

}
