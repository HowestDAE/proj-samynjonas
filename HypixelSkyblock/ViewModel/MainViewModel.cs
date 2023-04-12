using CommunityToolkit.Mvvm.ComponentModel;
using HypixelSkyblock.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HypixelSkyblock.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        string CommandText
        { 
            get
            {
                return "navigate";
            }
        }

        OverViewPage MainPage = new OverViewPage();
        public OverViewPage mainPage { get; set; }


        ProfilePage  ProfilePage = new ProfilePage();
        public ProfilePage profilePage { get; set; }


        Page CurrentPage;
        public Page currentPage{ get; set; }

        public MainViewModel() 
        {
            CurrentPage = MainPage;

            Console.WriteLine(CurrentPage.Name);
        }

    }
}
