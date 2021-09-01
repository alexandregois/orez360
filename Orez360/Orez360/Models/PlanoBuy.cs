using Orez360.Libraries.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orez360.Models
{
    public class PlanoBuy
    {
        public TipoPagamento tipo { get; set; }
        public String NumeroCartao { get; set; }
        public String DataValidade { get; set; }
        public String CVV { get; set; }
        public String NomeTitular { get; set; }
        public String ChavePix { get; set; }
    }
}
