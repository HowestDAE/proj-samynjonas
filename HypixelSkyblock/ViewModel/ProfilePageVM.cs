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

        public ProfilePageVM()
        {

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

        public async Task LoadProfile(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;

            MojangProfile   = await ProfileRepository.GetMojangProfile(username);
            LstProfiles     = await ProfileRepository.GetProfilesAsync(username);

            const int currentIndex = 0;
            if(lstProfiles.Count > 0)
            {
                CurrentProfile = lstProfiles[currentIndex];
            }
        }
    }
}
