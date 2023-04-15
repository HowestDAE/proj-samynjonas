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

        OverViewPage mainPage = new OverViewPage();
        public OverViewPage MainPage { get; set; }


        ProfilePage  ProfilePage = new ProfilePage();
        public ProfilePage profilePage { get; set; }


        Page currentPage;
        public Page CurrentPage
        { 
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(currentPage));
            }
        }

        private string switchPageButtonText = "Search Person";
        public string SwitchPageButtonText
        {
            get { return switchPageButtonText; }
            set
            {
                switchPageButtonText = value;
                OnPropertyChanged(nameof(switchPageButtonText));
            }
        }

        private void SwitchPage()
        {
            
        }


        public MainViewModel() 
        {
            CurrentPage = MainPage;

            Console.WriteLine(CurrentPage.Name);
        }

    }
}
