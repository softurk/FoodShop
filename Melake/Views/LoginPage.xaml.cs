using System;
using Melake;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Melake.Models;

namespace Melake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {

            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;

            Lbl_Username.TextColor = Constants.MainTexColor;
            Lbl_Password.TextColor = Constants.MainTexColor;

            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedureAsync(s, e);

        }

        async void SignInProcedureAsync(object sender, EventArgs e)
        {


            User user = new User(Entry_Username.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {

                DisplayAlert("Login", "Login Success", "Oke");
                var result = await App.RestService.Login(user);
                if (result.access_token != null)
                {
                    App.UserDatabase.SaveUser(user);

                }
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct,empty username  or password.", "Oke");

            }
        }
    }
}