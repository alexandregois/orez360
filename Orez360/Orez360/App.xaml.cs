using Orez360.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Orez360
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "Shapes_Experimental" });

            if (App.Current.Properties.ContainsKey("LoginIdCliente"))
            {
                App.Current.MainPage = new Menu();
            }
            else
            {
                MainPage = new Orez360.Views.Login();
            }
        }

        public static void NavegarParaPaginaInicial()
        {
            App.Current.MainPage = new Menu();
        }

        public static void NavegarParaPaginaCadastro()
        {
            App.Current.MainPage = new Cliente();
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
