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
	public partial class People : ContentPage
	{
        string num;
        public People()
        {
            InitializeComponent();
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            num = PhoneNumber.Text;
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + num,
                "Yes",
                "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    await dialer.DialAsync(num);
            }
        }
        async void OnCall1(object sender, System.EventArgs e)
        {
            num = PhoneNumber2.Text;
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + num,
                "Yes",
                "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    await dialer.DialAsync(num);
            }
        }
    }
}