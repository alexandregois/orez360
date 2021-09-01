using Orez360.Libraries.Helpers.MVVM;
using Orez360.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Orez360.ViewModels
{
    [QueryProperty("planoSerialized", "planoSerialized")]
    public class BuyPlanoViewModel : BaseViewModel
    {
        public Plano Plano { get; set; }

        public PlanoBuy PlanoBuy { get; set; }

        public String planoSerialized
        {
            set
            {
                Plano = JsonConvert.DeserializeObject<Plano>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Plano));
            }
        }

        public BuyPlanoViewModel()
        {
        }
    }
}
