using EcuacionRecta_VERM.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcuacionRecta_VERM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new home());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
