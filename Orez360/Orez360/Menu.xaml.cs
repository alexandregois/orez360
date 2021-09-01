using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Orez360
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Shell
    {
        public Menu()
        {
            InitializeComponent();

            Routing.RegisterRoute("plano/buy", typeof(Views.PlanoBuy));
        }
    }
}