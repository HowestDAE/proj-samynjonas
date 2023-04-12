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
                if(index > -1)
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

        public RelayCommand<string> SearchCommand
        {
            get; private set;
        }

        public ProfilePageVM()
        {
            //lstProfiles = ProfileRepository.GetProfiles();
            SearchCommand = new RelayCommand<string>(LoadProfile);
            //LoadProfile("Roppos");

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
    }
}
