using CommunityToolkit.Mvvm.ComponentModel;
using HypixelSkyblock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.ViewModel
{
    internal class ProfilePageVM : ObservableObject
    {
        private User currentProfile = new User()
        {
            userName = string.Empty,
            UUID = string.Empty,
            texture = string.Empty
        };


        public User CurrentProfile
        {
            get
            { 
                return CurrentProfile; 
            }
            set 
            { 
                currentProfile = value;
                OnPropertyChanged(nameof(CurrentProfile));
            }
        }

    }
}
