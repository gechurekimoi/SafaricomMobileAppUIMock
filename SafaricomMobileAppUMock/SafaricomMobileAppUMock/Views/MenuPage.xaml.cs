using SafaricomMobileAppUMock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafaricomMobileAppUMock.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public string DefaultIcon { get; set; }
        public MenuPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            SetUp();
        }

        private void SetUp()
        {
            DefaultIcon = "https://img.icons8.com/officexs/16/000000/small-lens.png";

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home" , Icon="home.png"  },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings", Icon="settings.png" },
                new HomeMenuItem {Id = MenuItemType.MyProfile, Title="My Profile"  , Icon="myProfile.png"},
                new HomeMenuItem {Id = MenuItemType.MPESA, Title="M-PESA" , Icon="mpesa.png" },
                new HomeMenuItem {Id = MenuItemType.Services, Title="Services" , Icon="services" },
                new HomeMenuItem {Id = MenuItemType.MyAccount, Title="My Account" , Icon="myAccount.png" },
                new HomeMenuItem {Id = MenuItemType.NetPerform, Title="Net Perform" , Icon="settings.png" },
                new HomeMenuItem {Id = MenuItemType.MyDataUsage, Title="My Data Usage" , Icon="dataUsage.png" },
                new HomeMenuItem {Id = MenuItemType.KnowledgeBase, Title="Knowledge Base" , Icon="knowledgeBase.png" },
                new HomeMenuItem {Id = MenuItemType.StoreLocator, Title="Store Locator" , Icon="storeLocator.png" },
                new HomeMenuItem {Id = MenuItemType.TellaFriend, Title="Tell A Friend" , Icon="tellAfriend.png" },
                new HomeMenuItem {Id = MenuItemType.FeedBackAndRating, Title="Feedback & Rating" , Icon="userFeedback.png" }

            };

            ListViewMenu.ItemsSource = menuItems;

            //ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemTapped += async (sender, e) =>
            {
                if (e.Item == null)
                    return;

                var id = (int)((HomeMenuItem)e.Item).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}