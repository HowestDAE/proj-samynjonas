using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HypixelSkyblock.Model;
using HypixelSkyblock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.ViewModel
{
    internal class ProfilePageVM : ObservableObject
    {
        //Profile info
        private Profile currentProfile = new Profile();
        public Profile CurrentProfile
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
                OnPropertyChanged(nameof(mojangProfile));
            }
        }


        public List<Profiles> lstProfiles { get; set; }
        public List<Member> lstMembers { get; set; }

        public RelayCommand<string> SearchCommand
        {
            get; private set;
        }

        public ProfilePageVM()
        {
            //lstProfiles = ProfileRepository.GetProfiles();
            //SearchCommand = new RelayCommand<string>(LoadProfile);
            LoadProfile("Roppos");

            //MemberStats = GetStats();
            //MemberStats = FilterStats("death"); //filters on deaths
            //MemberStats = FilterStats("kill");  //filters on kills
            //MemberStats = FilterStats("auction"); //filters on auction data
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
            MojangProfile   = await ProfileRepository.GetMojangProfile(username);
            lstProfiles     = await ProfileRepository.GetProfilesAsync(username);
            lstMembers      = await ProfileRepository.GetMembersAsync(username);

            const int currentIndex = 0;
            if(lstMembers.Count > 0)
            {
                CurrentMember = lstMembers[currentIndex];
            }
        }
    }
}
