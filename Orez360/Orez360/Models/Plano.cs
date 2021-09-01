using System;
using System.Collections.Generic;
using System.Text;

namespace Orez360.Models
{
    public class Plano
    {
        public string IdPlano { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string CodigoPix { get; set; }
        public string Cor { get; set; }

        public string FomatedValor
        {
            get
            {

                String deci = "";
                var preco = Valor.ToString().Replace(".", ",");

                int position = preco.IndexOf(",");

                if (position > 0)
                {
                    deci = preco.Substring(position + 1);

                    if (deci.Length < 2)
                    {
                        preco = preco + "0";
                    }
                }
                else
                {
                    preco = preco + ",00";
                }


                return preco;

            }
        }
    }
}
