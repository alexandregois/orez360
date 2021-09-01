using Orez360.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orez360.Services
{
    public class PlanoService
    {
        public List<Plano> GetPlanos()
        {
            var planos = new List<Plano>()
            {
                new Plano()
                {
                    IdPlano="1",
                    Nome="PLANO GRATUITO",
                    Descricao="Disponível Durante 14 dias",
                    Valor = 0,
                    CodigoPix = "Pix plano Gratuito",
                    Cor = "Padrao"
                },
                new Plano()
                {
                    IdPlano="2",
                    Nome="PLANO VIP",
                    Descricao="Tenha acesso a benefícios exclusivos",
                    Valor = 19.90,
                    CodigoPix = "Pix plano Vip",
                    Cor = "Roxo"
                },
                new Plano()
                {
                    IdPlano="3",
                    Nome="PLANO PREMIUM",
                    Descricao="Desfrute de um acompanhamento especializado",
                    Valor = 44.90,
                    CodigoPix = "Pix plano premium",
                    Cor = "Laranja"
                }
            };
            return planos;
        }
    }
}
