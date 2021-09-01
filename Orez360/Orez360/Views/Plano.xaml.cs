using Orez360.ViewModels;
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
    public partial class Plano : ContentPage
    {
        public Plano()
        {
            InitializeComponent();

            BindingContext = new PlanoViewModel();
        }
    }
}