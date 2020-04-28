using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafaricomMobileAppUMock.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerifyNumberPage : ContentPage
    {
        public VerifyNumberPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            lblVerifyMessage.HorizontalTextAlignment = TextAlignment.Center;
            txtPhoneNumber.HorizontalTextAlignment = TextAlignment.Center;
            txtPhoneNumber.VerticalTextAlignment = TextAlignment.Center;
            txtPhoneNumber.FontAttributes = FontAttributes.Bold;
            txtPhoneNumber.TextColor = Application.Current.Resources["Primary"]!=null? (Color)Application.Current.Resources["Primary"] : Color.DarkCyan;
            lblEnterEmailMessage.HorizontalTextAlignment = TextAlignment.Center;
            txtTapMessage.HorizontalTextAlignment = TextAlignment.Center;
            lblDataConsumedMessage.HorizontalTextAlignment = TextAlignment.Center;
           

        }

    }
}