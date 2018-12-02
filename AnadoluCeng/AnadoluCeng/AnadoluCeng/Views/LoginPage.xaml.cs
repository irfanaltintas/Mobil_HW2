using AnadoluCeng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnadoluCeng.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
        void SignIn(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.Check())
            {
                DisplayAlert("Login", "Login Success", "Ok");
                Navigation.PushAsync(new MainContainer());
            }
            else
            {
                DisplayAlert("Login", "Login Fail", "Ok");

            }

        }
    }
}