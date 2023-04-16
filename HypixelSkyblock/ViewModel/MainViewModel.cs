using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HypixelSkyblock.Model;
using HypixelSkyblock.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HypixelSkyblock.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private string commandText = "Search";
        public string CommandText
        { 
            get
            {
                return commandText;
            }
            set
            {
                commandText = value;
                OnPropertyChanged(nameof(CommandText));
            }
        }

        private VerticalAlignment buttonAlligment = VerticalAlignment.Bottom;
        public VerticalAlignment ButtonAlligment
        {
            get 
            { 
                return buttonAlligment; 
            }
            set 
            {
                buttonAlligment = value;
                OnPropertyChanged(nameof(ButtonAlligment));
            }
        }

        public bool IsLocal { get; set; }

        private int buttonPosition = 1;
        public int ButtonPosition
        {
            get
            {
                return buttonPosition;
            }
            set
            {
                buttonPosition = value;
                OnPropertyChanged(nameof(ButtonPosition));
            }
        }

        OverViewPage mainPage = new OverViewPage();
        public OverViewPage MainPage { get; set; }

        ProfilePage profilePage = new ProfilePage();
        public ProfilePage ProfilePage { get; set; }

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

        private async void SwitchPage()
        {
            if(CurrentPage is OverViewPage)
            {
                string username = (mainPage.DataContext as OverviewVM).UsernameInput;
                if (username == null) return;

                if(IsLocal)
                {
                    (profilePage.DataContext as ProfilePageVM).LoadProfile();
                }
                else
                {
                    await (profilePage.DataContext as ProfilePageVM).LoadProfileAsync(username);
                }

                CurrentPage = profilePage;
                CommandText = "Go back";

                ButtonPosition = 0;
                ButtonAlligment = VerticalAlignment.Top;

            }
            else if(CurrentPage is ProfilePage) 
            {
                CurrentPage = mainPage;
                CommandText = "Search";

                ButtonPosition = 1;
                ButtonAlligment = VerticalAlignment.Bottom;
            }
        }


        private Button pageSwitchButton;

        public RelayCommand SwitchPageCommand 
        { 
            get; 
            private set; 
        }

        public MainViewModel() 
        {
            CurrentPage = mainPage;

            SwitchPageCommand = new RelayCommand(SwitchPage);
        }

    }
}
