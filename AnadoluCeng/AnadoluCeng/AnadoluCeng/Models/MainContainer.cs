using AnadoluCeng.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AnadoluCeng.Models
{
    public class MainContainer : TabbedPage
    {
        public MainContainer()
        {
            Children.Add(new About());
            Children.Add(new People());
            Children.Add(new Courses());
            Children.Add(new Infrastructure());
        }
    }
}
