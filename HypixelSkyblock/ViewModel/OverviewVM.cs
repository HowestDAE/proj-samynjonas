using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HypixelSkyblock.Model;
using HypixelSkyblock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HypixelSkyblock.ViewModel.ProfilePageVM;

namespace HypixelSkyblock.ViewModel
{
    internal class OverviewVM : ObservableObject
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

        public async void LoadProfileAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return;

            MojangProfile   = await ProfileRepository.GetMojangProfileAsync(username);
            LstProfiles     = await ProfileRepository.GetProfilesAsync(username);

            const int currentIndex = 0;
            if (lstProfiles.Count > 0)
            {
                CurrentProfile = lstProfiles[currentIndex];
            }
        }

        public void LoadProfile()
        {
            MojangProfile = ProfileRepository.GetMojangProfile();
            LstProfiles = ProfileRepository.GetProfiles();

            const int currentIndex = 0;
            if (lstProfiles.Count > 0)
            {
                CurrentProfile = lstProfiles[currentIndex];
            }
        }

        public string UsernameInput { get; set; }

        public OverviewVM()
        {

        }


    }
}
