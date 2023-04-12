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
        public Profile profile { get; private set; }

        public Profile selectedProfile { get; set; }

        public OverviewVM()
        {
            profile = ProfileRepository.GetProfile(); //Getting the user

            Console.WriteLine(profile.profiles.Count);
            Console.WriteLine(profile.profiles[0].Members.Count);
        }


    }
}
