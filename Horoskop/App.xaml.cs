using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horoskop
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Horoskop_Page());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

