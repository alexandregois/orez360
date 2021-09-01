using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Orez360.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogOut : ContentPage
    {
        public LogOut()
        {
            InitializeComponent();

            if (App.Current.Properties.ContainsKey("LoginIdCliente"))
            {
                App.Current.Properties.Remove("LoginIdCliente");
                App.Current.Properties.Remove("LoginTelefone");
                App.Current.Properties.Remove("LoginSenha");
            }

            App.Current.MainPage = new Login();
        }
    }
}