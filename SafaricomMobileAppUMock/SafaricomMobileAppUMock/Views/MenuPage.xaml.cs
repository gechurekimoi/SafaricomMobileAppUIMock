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
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings" },
                new HomeMenuItem {Id = MenuItemType.MyProfile, Title="My Profile" },
                new HomeMenuItem {Id = MenuItemType.MPESA, Title="M-PESA" },
                new HomeMenuItem {Id = MenuItemType.Services, Title="Services" },
                new HomeMenuItem {Id = MenuItemType.MyAccount, Title="My Account" },
                new HomeMenuItem {Id = MenuItemType.NetPerform, Title="Net Perform" },
                new HomeMenuItem {Id = MenuItemType.MyDataUsage, Title="My Data Usage" },
                new HomeMenuItem {Id = MenuItemType.KnowledgeBase, Title="Knowledge Base" },
                new HomeMenuItem {Id = MenuItemType.StoreLocator, Title="Store Locator" },
                new HomeMenuItem {Id = MenuItemType.TellaFriend, Title="Tell A Friend" },
                new HomeMenuItem {Id = MenuItemType.FeedBackAndRating, Title="Feedback &amp; Rating" }

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