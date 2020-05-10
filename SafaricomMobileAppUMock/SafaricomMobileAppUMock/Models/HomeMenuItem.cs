using System;
using System.Collections.Generic;
using System.Text;

namespace SafaricomMobileAppUMock.Models
{
    public enum MenuItemType
    {
        Home,
        Settings,
        MyProfile,
        MPESA,
        Services,
        MyAccount,
        NetPerform,
        MyDataUsage,
        KnowledgeBase,
        StoreLocator,
        TellaFriend,
        FeedBackAndRating
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string  Icon { get; set; }
    }
}
