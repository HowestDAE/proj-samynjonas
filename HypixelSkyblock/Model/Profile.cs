using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        [JsonProperty(PropertyName = "cute_name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "selected")]
        public bool is_selected { get; set; }

        [JsonProperty(PropertyName = "members")]
        public Dictionary<string, Member> Members { get; set; }
    }

    public class Member
    {
        [JsonProperty(PropertyName = "pets")]
        public List<Pet> pets { get; set; }

        [JsonProperty(PropertyName = "dungeons")]
        public Dungeon dungeon { get; set; }

        //TODO temp stats buffs

        [JsonProperty(PropertyName = "fishing_treasure_caught")]
        public int fishingTreasureCaught { get; set; }

        [JsonProperty(PropertyName = "slayer_bosses")]
        public Dictionary<string, SlayerBoss> slayerBosses { get; set; }

        [JsonProperty(PropertyName = "active_effects")]
        public List<Effects> activeEffects { get; set; }
              
        [JsonProperty(PropertyName = "nether_island_player_data")]
        public NetherIslandPlayerData netherIslandPlayerData { get; set; }

        //TODO jacob2

        [JsonProperty(PropertyName = "stats")]
        public Dictionary<string, float> stats { get; set; }

        [JsonProperty(PropertyName = "death_count")]
        public string deathCount { get; set; }

        //TODO harp quest

        //TODO experimentation

        [JsonProperty(PropertyName = "first_join_hub")]
        public int firstJoinHub { get; set; }

        [JsonProperty(PropertyName = "personal_bank_upgrade")]
        public int personalBankUpgrade { get; set; }

        [JsonProperty(PropertyName = "fairy_souls_collected")]
        public int fairySoulsCollected { get; set; }

        //[JsonProperty(PropertyName = "bestiary")]                 //TODO fix, there is 1 bool )°:
        //public Dictionary<string, int> bestiary { get; set; }

        [JsonProperty(PropertyName = "tutorial")]
        public List<string> tutorial { get; set; }

        [JsonProperty(PropertyName = "perks")]
        public Dictionary<string, int> perks { get; set; }

        [JsonProperty(PropertyName = "visited_zones")]
        public List<string> visitedZones { get; set; }

        //TODO coop_invitation

        [JsonProperty(PropertyName = "soulflow")]
        public int soulflow { get; set; }

        [JsonProperty(PropertyName = "quests")]
        public Dictionary<string, Quest> quests { get; set; }

        [JsonProperty(PropertyName = "coin_purse")]
        public float coin_purse { get; set; }

        [JsonProperty(PropertyName = "autopet")]
        public autoPet autopet { get; set; }

        //TODO inv_armor

        //TODO accessory_bag_storage

        //TODO leveling

        [JsonProperty(PropertyName = "crafted_generators")]
        public List<string> craftedGenerators { get; set; }

        [JsonProperty(PropertyName = "visited_modes")]
        public List<string> visitedModes { get; set; }

        //TODO Disabled_potion_effects

        //TODO trapper_quest

        //TODO mining_code

        //TODO trophy_fish

        //TODO forge

        [JsonProperty(PropertyName = "fairy_souls")]
        public int fairySouls { get; set; }

        [JsonProperty(PropertyName = "objectives")]
        public Dictionary<string, Objectives> objectives { get; set; }

        [JsonProperty(PropertyName = "last_death")]
        public long lastDeath { get; set; }

        [JsonProperty(PropertyName = "first_join")]
        public long firstJoin { get; set; }

        //TODO paused_effects

        [JsonProperty(PropertyName = "experience_skill_runecrafting")]
        public float experienceSkillRunecrafting { get; set; }

        [JsonProperty(PropertyName = "experience_skill_mining")]
        public float experienceSkillMining { get; set; }

        [JsonProperty(PropertyName = "equippment_contents")]
        public storageContent equippmentContents { get; set; }

        [JsonProperty(PropertyName = "unlocked_coll_tiers")]
        public List<string> unlockedCollTiers { get; set; }

        [JsonProperty(PropertyName = "backpack_contents")]
        public Dictionary<string, storageContent> backpackContents { get; set; }

        [JsonProperty(PropertyName = "experience_skill_alchemy")]
        public float experienceSkillAlchemy { get; set; }

        [JsonProperty(PropertyName = "quiver")]
        public storageContent quiver { get; set; }

        [JsonProperty(PropertyName = "experience_skill_taming")]
        public float experienceSkillTaming { get; set; }

        [JsonProperty(PropertyName = "sacks_counts")]
        public Dictionary<string, int> sacksCounts { get; set; }

        [JsonProperty(PropertyName = "essence_undead")]
        public int essenceUndead { get; set; }

        [JsonProperty(PropertyName = "talisman_bag")]
        public storageContent talismanBag { get; set; }

        //TODO backpack_icons

        [JsonProperty(PropertyName = "experience_skill_combat")]
        public float experienceSkillCombat { get; set; }

        [JsonProperty(PropertyName = "essence_diamond")]
        public int essenceDiamond { get; set; }

        [JsonProperty(PropertyName = "fishing_bag")]
        public storageContent fishingBag { get; set; }

        [JsonProperty(PropertyName = "experience_skill_farming")]
        public float experienceSkillFarming { get; set; }

        [JsonProperty(PropertyName = "wardrobe_equipped_slot")]
        public int wardrobeEquippedSlot { get; set; }

        [JsonProperty(PropertyName = "collection")]
        public Dictionary<string, int> collection { get; set; }

        [JsonProperty(PropertyName = "essence_dragon")]
        public int essenceDragon { get; set; }

        [JsonProperty(PropertyName = "experience_skill_social2")]
        public float experienceSkillSocial2 { get; set; }

        [JsonProperty(PropertyName = "essence_gold")]
        public int essenceGold { get; set; }

        [JsonProperty(PropertyName = "ender_chest_contents")]
        public storageContent enderChestContents { get; set; }

        [JsonProperty(PropertyName = "wardrobe_contents")]
        public storageContent wardrobeContents { get; set; }

        [JsonProperty(PropertyName = "potion_bag")]
        public storageContent potionBag { get; set; }

        [JsonProperty(PropertyName = "experience_skill_enchanting")]
        public float experienceSkillEnchanting { get; set; }

        [JsonProperty(PropertyName = "personal_vault_contents")]
        public storageContent personalVaultContents { get; set; }

        [JsonProperty(PropertyName = "experience_skill_fishing")]
        public float experienceSkillFishing { get; set; }

        [JsonProperty(PropertyName = "inv_contents")]
        public storageContent invContents { get; set; }

        [JsonProperty(PropertyName = "essence_ice")]
        public int essenceIce { get; set; }

        [JsonProperty(PropertyName = "essence_wither")]
        public int essenceWither { get; set; }

        [JsonProperty(PropertyName = "essence_spider")]
        public int essenceSpider { get; set; }

        [JsonProperty(PropertyName = "experience_skill_foraging")]
        public float experienceSkillForaging { get; set; }

        [JsonProperty(PropertyName = "candy_inventory_contents")]
        public storageContent candyInventoryContents { get; set; }

        [JsonProperty(PropertyName = "experience_skill_carpentry")]
        public float experienceSkillCarpentry { get; set; }
    }

    public class Dungeon
    {
        [JsonProperty(PropertyName = "dungeon_types")]
        public DungeonTypes dungeonTypes { get; set; }


        [JsonProperty(PropertyName = "player_classes")]
        public PlayerClasses playerClasses { get; set; }

        //TODO dungeon_journal -- check for info

        [JsonProperty(PropertyName = "dungeons_blah_blah")]
        public List<string> dungeonsBlahBlah { get; set; }

        public string Selected_Dungeon_Class { get; set; }

        //TODO add daily_runs
        //TODO Add treasures
    }

    public class DungeonTypes
    {
        //TODO check more json to check if more types(maybe make dictonary)
        [JsonProperty(PropertyName = "catacombs")]
        public Catacombs catacombs { get; set; }

        [JsonProperty(PropertyName = "master_catacombs")]
        public MasterCatacombs masterCatacombs { get; set; }
    }

    public class Catacombs
    {
        [JsonProperty(PropertyName = "times_played")]
        public Dictionary<string, float> timesPlayed { get; set; }

        [JsonProperty(PropertyName = "experience")]
        public float experience { get; set; }

        [JsonProperty(PropertyName = "tier_completions")]
        public Dictionary<string, float> tierCompletions { get; set; }

        [JsonProperty(PropertyName = "fastest_time")]
        public Dictionary<string, float> fastestTime { get; set; }

        [JsonProperty(PropertyName = "best_runs")]
        public Dictionary<string, List<DungeonBestRuns>> bestRuns { get; set; }

        [JsonProperty(PropertyName = "best_score")]
        public Dictionary<string, float> bestScore { get; set; }

        [JsonProperty(PropertyName = "mobs_killed")]
        public Dictionary<string, float> mobsKilled { get; set; }

        [JsonProperty(PropertyName = "most_mobs_killed")]
        public Dictionary<string, float> mostMobsKilled { get; set; }

        [JsonProperty(PropertyName = "most_damage_archer")]
        public Dictionary<string, float> mostDamageArcher { get; set; }

        [JsonProperty(PropertyName = "most_healing")]
        public Dictionary<string, float> mostHealing { get; set; }

        [JsonProperty(PropertyName = "watcher_kills")]
        public Dictionary<string, float> watcherKills { get; set; }

        [JsonProperty(PropertyName = "highest_tier_completed")]
        public int highestTierCompleted { get; set; }

        [JsonProperty(PropertyName = "most_damage_healer")]
        public Dictionary<string, float> mostDamageHealer { get; set; }

        [JsonProperty(PropertyName = "most_damage_berserk")]
        public Dictionary<string, float> mostDamageBerserk { get; set; }

        [JsonProperty(PropertyName = "fastest_time_s")]
        public Dictionary<string, float> fastestTimeS { get; set; }

        [JsonProperty(PropertyName = "fastest_time_s_plus")]
        public Dictionary<string, float> fastestTimeSPlus { get; set; }

        [JsonProperty(PropertyName = "most_damage_mage")]
        public Dictionary<string, float> mostDamageMage { get; set; }

        [JsonProperty(PropertyName = "milestone_completions")]
        public Dictionary<string, float> milestoneCompletions { get; set; }

        [JsonProperty(PropertyName = "most_damage_tank")]
        public Dictionary<string, float> mostDamageTank { get; set; }
    }

    public class MasterCatacombs
    {
        [JsonProperty(PropertyName = "tier_completions")]
        public Dictionary<string, float> tierCompletions { get; set; }

        [JsonProperty(PropertyName = "milestone_completions")]
        public Dictionary<string, float> milestoneCompletions { get; set; }

        [JsonProperty(PropertyName = "best_score")]
        public Dictionary<string, float> bestScore { get; set; }

        [JsonProperty(PropertyName = "mobs_killed")]
        public Dictionary<string, float> mobsKilled { get; set; }

        [JsonProperty(PropertyName = "most_mobs_killed")]
        public Dictionary<string, float> mostMobsKilled { get; set; }

        [JsonProperty(PropertyName = "most_damage_berserk")]
        public Dictionary<string, float> mostDamageBerserk { get; set; }

        [JsonProperty(PropertyName = "most_healing")]
        public Dictionary<string, float> mostHealing { get; set; }

        [JsonProperty(PropertyName = "fastest_time")]
        public Dictionary<string, float> fastestTime { get; set; }

        [JsonProperty(PropertyName = "highest_tier_completed")]
        public int highestTierCompleted { get; set; }

        [JsonProperty(PropertyName = "fastest_time_s")]
        public Dictionary<string, float> fastestTimeS { get; set; }

        [JsonProperty(PropertyName = "best_runs")]
        public Dictionary<string, List<DungeonBestRuns>> bestRuns { get; set; }

        [JsonProperty(PropertyName = "fastest_time_s_plus")]
        public Dictionary<string, float> fastestTimeSPlus { get; set; }
    }

    public class PlayerClasses
    {
        public struct exp
        {
            [JsonProperty(PropertyName = "experience")]
            public float experience { get; set; }
        }

        [JsonProperty(PropertyName = "healer")]
        public exp healer { get; set; }

        [JsonProperty(PropertyName = "mage")]
        public exp mage { get; set; }

        [JsonProperty(PropertyName = "berserk")]
        public exp berserk { get; set; }

        [JsonProperty(PropertyName = "archer")]
        public exp archer { get; set; }

        [JsonProperty(PropertyName = "tank")]
        public exp tank { get; set; }
    }

    public class DungeonBestRuns
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long timestamp { get; set; }

        [JsonProperty(PropertyName = "score_exploration")]
        public int scoreExploration { get; set; }

        [JsonProperty(PropertyName = "score_speed")]
        public int scoreSpeed { get; set; }

        [JsonProperty(PropertyName = "score_skill")]
        public int scoreSkill { get; set; }

        [JsonProperty(PropertyName = "score_bonus")]
        public int scoreBonus { get; set; }

        [JsonProperty(PropertyName = "dungeon_class")]
        public string dungeonClass { get; set; }

        [JsonProperty(PropertyName = "teammates")]
        public List<string> teammates { get; set; }

        [JsonProperty(PropertyName = "elapsed_time")]
        public int elapsedTime { get; set; }

        [JsonProperty(PropertyName = "damage_dealt")]
        public float damageDealt { get; set; }

        [JsonProperty(PropertyName = "deaths")]
        public int deaths { get; set; }

        [JsonProperty(PropertyName = "mobs_killed")]
        public int mobsKilled { get; set; }

        [JsonProperty(PropertyName = "secrets_found")]
        public int secretsFound { get; set; }

        [JsonProperty(PropertyName = "damage_mitigated")]
        public float damageMitigated { get; set; }

        [JsonProperty(PropertyName = "ally_healing")]
        public float allyHealing { get; set; }
    }

    public class SlayerBoss
    {
        [JsonProperty(PropertyName = "Claimed_Levels")]
        public Dictionary<string, bool> ClaimedLevels { get; set; }

        [JsonProperty(PropertyName = "boss_kills_tier_0")]
        public int bossKillsTier0 { get; set; }

        [JsonProperty(PropertyName = "xp")]
        public int xp { get; set; }

        [JsonProperty(PropertyName = "boss_kills_tier_1")]
        public int bossKillsTier1 { get; set; }

        [JsonProperty(PropertyName = "boss_kills_tier_2")]
        public int bossKillsTier2 { get; set; }

        [JsonProperty(PropertyName = "boss_kills_tier_3")]
        public int bossKillsTier3 { get; set; }
    }

    public class Effects
    {
        public struct modifers
        {
            [JsonProperty(PropertyName = "key")]
            public string key { get; set; }

            [JsonProperty(PropertyName = "amp")]
            public int amp { get; set; }
        }

        [JsonProperty(PropertyName = "effect")]
        public string effect { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int level { get; set; }

        [JsonProperty(PropertyName = "modifiers")]
        public List<modifers> modifiers { get; set; }

        [JsonProperty(PropertyName = "ticks_remaining")]
        public int ticksRemaining { get; set; }

        [JsonProperty(PropertyName = "infinite")]
        public bool infinite { get; set; }
    }

    public class NetherIslandPlayerData
    {
        public struct Dojo
        {
            [JsonProperty(PropertyName = "dojo_points_mob_kb")]
            public int dojoPointsMobKb { get; set; }

            [JsonProperty(PropertyName = "dojo_time_mob_kb")]
            public int dojoTimeMobKb { get; set; }

            [JsonProperty(PropertyName = "dojo_points_wall_jump")]
            public int dojoPointsWallJump { get; set; }

            [JsonProperty(PropertyName = "dojo_time_wall_jump")]
            public int dojoPointsTimeJump { get; set; }

            [JsonProperty(PropertyName = "dojo_time_archer")]
            public int dojoTimeArcher { get; set; }

            [JsonProperty(PropertyName = "dojo_time_snake")]
            public int dojoTimeSnake { get; set; }

            [JsonProperty(PropertyName = "dojo_points_sword_swap")]
            public int dojoPointsSwordSwap { get; set; }

            [JsonProperty(PropertyName = "dojo_time_sword_swap")]
            public int dojoTimeSwordSwap { get; set; }

            [JsonProperty(PropertyName = "dojo_points_fireball")]
            public int dojoPointsFireball { get; set; }

            [JsonProperty(PropertyName = "dojo_time_fireball")]
            public int dojoTimeFireball { get; set; }
        }

        //kuudra_completed_tiers

        [JsonProperty(PropertyName = "dojo")]
        public Dojo dojo { get; set; }

        //abiphone

        //matriarch

        [JsonProperty(PropertyName = "mages_reputation")]
        public float magesReputation { get; set; }

        [JsonProperty(PropertyName = "selected_faction")]
        public string selectedFaction { get; set; }

        [JsonProperty(PropertyName = "barbarians_reputation")]
        public float barbariansReputation { get; set; }

        [JsonProperty(PropertyName = "last_minibosses_killed")]
        public List<string> lastMinibossesKilled { get; set; }

        //kuudra_party_finder
    }

    public class Quest
    {
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "activated_at")]
        public long activatedAt { get; set; }

        [JsonProperty(PropertyName = "activated_at_sb")]
        public long activatedAtSb { get; set; }

        [JsonProperty(PropertyName = "completed_at")]
        public long completedAt { get; set; }

        [JsonProperty(PropertyName = "completed_at_sb")]
        public long completedAtSb { get; set; }
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

    public class autoPet
    {
        public struct Rule
        {
            public struct Data
            {
                [JsonProperty(PropertyName = "boss")]
                public string boss { get; set; }

                [JsonProperty(PropertyName = "category")]
                public string category { get; set; }
            }

            [JsonProperty(PropertyName = "id")]
            public string id { get; set; }

            [JsonProperty(PropertyName = "pet")]
            public string pet { get; set; }

            //Excpetions

            [JsonProperty(PropertyName = "disabled")]
            public bool disabled { get; set; }

            [JsonProperty(PropertyName = "data")]
            public Data data { get; set; }
        }

        [JsonProperty(PropertyName = "rules_limit")]
        public int rulesLimit { get; set; }

        [JsonProperty(PropertyName = "rules")]
        public List<Rule> rules { get; set; }
    }

    public class storageContent
    {
        [JsonProperty(PropertyName = "type")]
        public int type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public string data { get; set; }
    }

    public class Objectives
    {
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "progress")]
        public int progress { get; set; }

        [JsonProperty(PropertyName = "completed_at")]
        public long completedAt { get; set; }
    }
}
