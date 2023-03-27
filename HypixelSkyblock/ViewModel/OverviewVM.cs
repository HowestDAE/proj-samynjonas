using CommunityToolkit.Mvvm.ComponentModel;
using HypixelSkyblock.Model;
using HypixelSkyblock.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.ViewModel
{
    internal class OverviewVM : ObservableObject
    {
        public List<Profile> lstProfiles { get; private set; }

        public Profile selectedProfile { get; set; }

        public OverviewVM()
        {
            lstProfiles = ProfileRepository.GetProfiles();

            Console.WriteLine(lstProfiles.Count);
            Console.WriteLine(lstProfiles[0].Members.Count);
            Console.WriteLine(lstProfiles[0].Members[lstProfiles[0].Members.ElementAt(0).Key].slayerBosses.ElementAt(0).Key);


        }

    }
}
