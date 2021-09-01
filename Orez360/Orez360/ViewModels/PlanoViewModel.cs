using Orez360.Models;
using Orez360.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Orez360.ViewModels
{
    public class PlanoViewModel
    {
        public List<Plano> planos
        {
            get
            {
                return new PlanoService().GetPlanos();
            }
        }

        public ICommand BuyCommand { get; set; }
        public PlanoViewModel()
        {
            BuyCommand = new Command<Plano>(Detail);
        }

        private void Detail(Plano plano)
        {
            String planoSerialized = JsonConvert.SerializeObject(plano);
            Shell.Current.GoToAsync($"plano/buy?planoSerialized={Uri.EscapeDataString(planoSerialized)}");
        }
    }
}
