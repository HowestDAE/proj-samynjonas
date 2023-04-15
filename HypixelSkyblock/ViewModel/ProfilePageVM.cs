using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HypixelSkyblock.Model;
using HypixelSkyblock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static HypixelSkyblock.Model.PlayerClasses;
using static HypixelSkyblock.ViewModel.ProfilePageVM;

namespace HypixelSkyblock.ViewModel
{
    internal class ProfilePageVM : ObservableObject
    {
        //Profile info
        private Profiles currentProfile = new Profiles();
        public Profiles CurrentProfile
        {
            get
            {
                return currentProfile;
            }
            set
            {
                currentProfile = value;

                playerLevel = new PlayerLevels(currentProfile);
                               
                OnPropertyChanged(nameof(CurrentProfile));
            }
        }

        //Mojang profile
        private MojangProfile mojangProfile = new MojangProfile()
        {
            name = "tempName",
            uuid = "cb12d6095d2b4439a92bef959983c2a1"
        };
        public MojangProfile MojangProfile
        {
            get 
            {
                return mojangProfile; 
            }
            set 
            {
                mojangProfile = value;

                SkinUrl = "https://crafthead.net/helm/" + mojangProfile.name + ".png";

                OnPropertyChanged(nameof(mojangProfile));
            }
        }

        //Player levels
        private PlayerLevels playerLevel;
        public PlayerLevels PlayerLevel
        {
            get
            {
                return playerLevel;
            }
            set
            {
                playerLevel = value;
                OnPropertyChanged(nameof(playerLevel));
            }
        }

        private List<Profiles> lstProfiles = new List<Profiles>();
        public List<Profiles> LstProfiles
        {
            get
            {
                return lstProfiles;
            }
            set
            {
                lstProfiles = value;
                OnPropertyChanged(nameof(lstProfiles));
            }
        }

        private string skinUrl = "https://crafthead.net/helm/notch.png";
        public string SkinUrl 
        { 
            get 
            { 
                return skinUrl;
            } 
            set 
            { 
                skinUrl = value;
                OnPropertyChanged(nameof(skinUrl));
            } 
        }

        public RelayCommand<string> SearchCommand
        {
            get; private set;
        }

        public ProfilePageVM()
        {
            SearchCommand = new RelayCommand<string>(LoadProfile);
        }

        public Dictionary<string, float> FilterStats(string username)
        {
            Dictionary<string, float> filteredStats = new Dictionary<string, float>();
            //foreach (var stat in memberStats) 
            //{ 
            //    if(stat.Key.Contains(filterString))
            //    {
            //        filteredStats.Add(stat.Key, stat.Value);
            //    }
            //}
            return filteredStats;
        }

        private async void LoadProfile(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;

            MojangProfile   = await ProfileRepository.GetMojangProfile(username);
            LstProfiles     = await ProfileRepository.GetProfilesAsync(username);
            //LstMembers      = await ProfileRepository.GetMembersAsync(username);

            const int currentIndex = 0;
            if(lstProfiles.Count > 0)
            {
                CurrentProfile = lstProfiles[currentIndex];
            }
        }

        public struct CalculatedLevel
        {
            static float getLevel(float exp)
            {
                return exp < 0 ? 1 : (int)Math.Floor(1 + REVERSE_PQ_PREFIX + Math.Sqrt(REVERSE_CONST + GROWTH_DIVIDES_2 * exp));
            }

            static float getExpFromLevelToNext(float level)
            {
                return level < 1 ? BASE : GROWTH * (level - 1) + BASE;
            }

            static float GetTotalExpToLevel(float level)
            {
                int lv = (int)Math.Floor((double)level);
                float x0 = getTotalExpToFullLevel(lv);
                if (level == lv) return x0;
                return (getTotalExpToFullLevel(lv + 1) - x0) * (level % 1) + x0;
            }

            static float getTotalExpToFullLevel(float level)
            {
                return (HALF_GROWTH * (level - 2) + BASE) * (level - 1);
            }

            static float GetPercentageToNextLevel(float exp)
            {
                float lv = getLevel(exp);
                float x0 = GetTotalExpToLevel((int)lv);
                return (exp - x0) / (GetTotalExpToLevel((int)lv + 1) - x0);
            }

            public float TotalExp { get; set; }
            public float Level { get; set; }
            public float NeededExp { get; set; }
            public float RemainingExp { get; set; }

            private const float BASE = 10000f;
            private const float GROWTH = 2500f;

            private const float HALF_GROWTH = 0.5f * GROWTH;

            private const float REVERSE_PQ_PREFIX = -(BASE - HALF_GROWTH) / GROWTH;
            private const float REVERSE_CONST = REVERSE_PQ_PREFIX * REVERSE_PQ_PREFIX;
            private const float GROWTH_DIVIDES_2 = 2 / GROWTH;

            public CalculatedLevel(float totalExp)
            {   
                TotalExp = totalExp;

                Level = getLevel(totalExp);

                NeededExp = getExpFromLevelToNext(totalExp);

                RemainingExp = GetTotalExpToLevel(Level + 1);
            }
        }
        
        public struct PlayerLevels
        {
            public CalculatedLevel Player { get; set; }
            public CalculatedLevel Taming { get; set; }
            public CalculatedLevel Mining { get; set; }
            public CalculatedLevel Foraging { get; set; }
            public CalculatedLevel Enchanting { get; set; }
            public CalculatedLevel Carpentry { get; set; }
            public CalculatedLevel Social { get; set; }
            public CalculatedLevel Farming { get; set; }
            public CalculatedLevel Combat { get; set; }
            public CalculatedLevel Fishing { get; set; }
            public CalculatedLevel Alchemy { get; set; }
            public CalculatedLevel Runecrafting { get; set; }

            public PlayerLevels(Profiles profile)
            {
                Player       = new CalculatedLevel(profile.raw.leveling.experience);
                Taming       = new CalculatedLevel((int)profile.raw.experienceSkillTaming);
                Mining       = new CalculatedLevel((int)profile.raw.experienceSkillMining);
                Foraging     = new CalculatedLevel((int)profile.raw.experienceSkillForaging);
                Enchanting   = new CalculatedLevel((int)profile.raw.experienceSkillEnchanting);
                Carpentry    = new CalculatedLevel((int)profile.raw.experienceSkillCarpentry);
                Social       = new CalculatedLevel((int)profile.raw.experienceSkillSocial2);
                Farming      = new CalculatedLevel((int)profile.raw.experienceSkillFarming);
                Combat       = new CalculatedLevel((int)profile.raw.experienceSkillCombat);
                Fishing      = new CalculatedLevel((int)profile.raw.experienceSkillFishing);
                Alchemy      = new CalculatedLevel((int)profile.raw.experienceSkillAlchemy);
                Runecrafting = new CalculatedLevel((int)profile.raw.experienceSkillRunecrafting);
            }
        }
    }
}
