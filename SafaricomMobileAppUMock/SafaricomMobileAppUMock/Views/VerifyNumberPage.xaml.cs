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
            txtPhoneNumber.FontFamily = "CenturyGothicBold";
            btnGeneratePin.FontFamily = "BwGlennSansDEMO-Bold";
           // btnGeneratePin.FontFamily = "CenturyGothicBold";
            btnGeneratePin.FontSize = 20;
            
            lblEnterEmailMessage.HorizontalTextAlignment = TextAlignment.Center;
            txtTapMessage.HorizontalTextAlignment = TextAlignment.Center;
            lblDataConsumedMessage.HorizontalTextAlignment = TextAlignment.Center;
           

        }

        private void btnGeneratePin_Clicked(object sender, EventArgs e)
        {
            try
            {
                Application.Current.MainPage = new LoginPage();
            }
            catch (Exception ex)
            {
                DisplayAlert("Oooops", "Something went wrong please try again", "OK");
            }
        }
    }
}