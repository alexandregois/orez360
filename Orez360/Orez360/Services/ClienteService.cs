using Orez360.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Orez360.Services
{
    public class ClienteService : Service
    {
        public IList<string> ListaTipoSanguineo()
        {
            return new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };


        }

        public async Task<string> getLogin(string telefone, string senha)
        {
            String cliente = null;
            HttpContent content = null;

            HttpResponseMessage reponse = await _client.PostAsync($"{BaseApiUrl}/api/Login/Login?Telefone={telefone}&Senha={senha}", content);

            if (reponse.IsSuccessStatusCode)
            {
                cliente = await reponse.Content.ReadAsStringAsync();
            }

            return cliente;
        }

        public async Task<string> addCliente(Cliente cliente)
        {
            HttpContent content = null;
            string retorno = null;

            String url = this.BaseApiUrl;

            Console.WriteLine(cliente.Nome);

            if (!cliente.Nome.Equals(null))
            {
                url = url + "/api/Cliente/CadastraCliente?nome=" + cliente.Nome;
            }
            if (cliente.Telefone != null)
            {
                url = url + "&celular=" + cliente.Telefone;
            }
            if (cliente.Nascimento != null)
            {
                url = url + "&dataNascimento=" + cliente.Nascimento.Replace("/", "%2F");
            }
            if (cliente.Altura != null)
            {
                url = url + "&altura=" + cliente.Altura;
            }
            if (cliente.Peso != null)
            {
                url = url + "&peso=" + cliente.Peso;
            }
            if (cliente.MedicacoesSuplmentos != null)
            {
                url = url + "&medicacao=" + cliente.MedicacoesSuplmentos;
            }
            if (cliente.DisturbioSaude != null)
            {
                url = url + "&disturbios=" + cliente.DisturbioSaude;
            }
            if (cliente.Email != null)
            {
                url = url + "&email=" + cliente.Email.Replace("@", "%40");
            }
            if (cliente.Senha != null)
            {
                url = url + "&senha=" + cliente.Email;
            }

            url = url + "&idTipoSangue=1&idSexo=1";
            Console.WriteLine(url);
            HttpResponseMessage reponse = await _client.PostAsync($"{url}", content);

            if (reponse.IsSuccessStatusCode)
            {
                retorno = await reponse.Content.ReadAsStringAsync();
                Console.WriteLine(retorno);
            }

            return retorno;
        }
    }
}
