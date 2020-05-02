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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                DisplayAlert("Oooops!", "Soemthing went wrong", "OK");
            }
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

            }
        }
    }
}