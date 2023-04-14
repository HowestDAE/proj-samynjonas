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

                int index = LstProfiles.IndexOf(value);
                if(index > -1 && index < lstProfiles.Count())
                {
                    CurrentMember = lstMembers[index];
                }                
                OnPropertyChanged(nameof(CurrentProfile));
            }
        }

        //Member info
        private Member currentMember = new Member();
        public Member CurrentMember
        {
            get 
            { 
                return currentMember; 
            }
            set 
            {
                currentMember = value;

                PlayerLevel = new PlayerLevels(currentMember);

                OnPropertyChanged(nameof(currentMember));
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

        private List<Member> lstMembers = new List<Member>();
        public List<Member> LstMembers
        {
            get
            {
                return lstMembers;
            }
            set
            {
                lstMembers = value;
                OnPropertyChanged(nameof(lstMembers));
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
            LstMembers      = await ProfileRepository.GetMembersAsync(username);

            const int currentIndex = 0;
            if(lstMembers.Count > 0)
            {
                CurrentMember = lstMembers[currentIndex];
            }
        }

        public struct CalculatedLevel
        {
            public int TotalExp { get; set; }
            public int Level { get; set; }
            public int NeededExp { get; set; }
            public int RemainingExp { get; set; }

            public CalculatedLevel(int totalExp)
            {
                TotalExp = totalExp;
                Level = (int)Math.Floor(0.5 + Math.Sqrt(2 * TotalExp + 225) / 50);
                NeededExp = (Level * Level * 50) - (Level * 50) - 50;
                RemainingExp = TotalExp - ((Level - 1) * (Level - 1) * 50 + 50);
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

            public PlayerLevels(Member member)
            {
                Player       = new CalculatedLevel(member.leveling.experience);
                Taming       = new CalculatedLevel((int)member.experienceSkillTaming);
                Mining       = new CalculatedLevel((int)member.experienceSkillMining);
                Foraging     = new CalculatedLevel((int)member.experienceSkillForaging);
                Enchanting   = new CalculatedLevel((int)member.experienceSkillEnchanting);
                Carpentry    = new CalculatedLevel((int)member.experienceSkillCarpentry);
                Social       = new CalculatedLevel((int)member.experienceSkillSocial2);
                Farming      = new CalculatedLevel((int)member.experienceSkillFarming);
                Combat       = new CalculatedLevel((int)member.experienceSkillCombat);
                Fishing      = new CalculatedLevel((int)member.experienceSkillFishing);
                Alchemy      = new CalculatedLevel((int)member.experienceSkillAlchemy);
                Runecrafting = new CalculatedLevel((int)member.experienceSkillRunecrafting);
            }
        }
    }
}
