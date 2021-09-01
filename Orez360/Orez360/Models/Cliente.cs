using System;
using System.Collections.Generic;
using System.Text;

namespace Orez360.Models
{
    public class Cliente
    {
        public string idCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string TipoSanquineo { get; set; }
        public string Altura { get; set; }
        public string Nascimento { get; set; }
        public string Peso { get; set; }
        public string MedicacoesSuplmentos { get; set; }
        public string DisturbioSaude { get; set; }
        public string Senha { get; set; }
    }
}
