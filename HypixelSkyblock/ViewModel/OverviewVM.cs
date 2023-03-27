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
            Console.WriteLine(lstProfiles[0].Members["cb12d6095d2b4439a92bef959983c2a1"].slayerBosses["enderman"].bossKillsTier0);


        }

    }
}
