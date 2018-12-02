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
	public partial class Infrastructure : ContentPage
	{
        int tapCount = 0;
        public System.Collections.ObjectModel.ObservableCollection<Classrooms> PersonList { get; set; }
        public Infrastructure()
        {
            InitializeComponent();
            LoadData();
            MylistView.ItemsSource = PersonList;
            
        }

        private void LoadData()
        {
            PersonList = new System.Collections.ObjectModel.ObservableCollection<Classrooms>()
            {
                new Classrooms(){Name= "Derslik-B1", Capacity="Capacity:36", Source="b1.jpg"},
                new Classrooms(){Name= "Derslik-B2", Capacity="Capacity:15", Source="b2.jpg"},
                new Classrooms(){Name= "Derslik-B3", Capacity="Capacity:18", Source="b3.jpg"},
                new Classrooms(){Name= "Derslik-B4", Capacity="Capacity:24", Source="b4.jpg"},
                new Classrooms(){Name= "Derslik-B5", Capacity="Capacity:15", Source="b5.jpg"},
                new Classrooms(){Name= "Derslik-B6", Capacity="Capacity:24", Source="b6.jpg"},
                new Classrooms(){Name= "Derslik-B7", Capacity="Capacity:54", Source="b7.jpg"},
                new Classrooms(){Name= "Lab-01", Capacity="Capacity:61 PC",  Source="lab1.jpg"},
                new Classrooms(){Name= "Lab-02", Capacity="Capacity:24 iMAC",Source="lab2.jpg"},

            };
        }

        void OnTap(object sender, EventArgs e)
        {
            tapCount++;
            var imageSender = (Image)sender;
           
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "b1.jpg";
                imageSender.HeightRequest = 50;
                imageSender.WidthRequest = 50;

            }
            else
            {
                imageSender.Source = "b1.jpg";
                imageSender.HeightRequest = 500;
                imageSender.WidthRequest = 500;
            }
        }
    }
}