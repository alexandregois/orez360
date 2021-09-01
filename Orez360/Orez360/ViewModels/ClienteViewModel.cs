using Orez360.Libraries.Helpers.MVVM;
using Orez360.Models;
using Orez360.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Orez360.ViewModels
{
    public class ClienteViewModel : BaseViewModel
    {
        public Cliente cli { get; set; }

        private ClienteService clienteService;
        public ICommand SubmitCommand { protected set; get; }

        public ClienteViewModel()
        {
            SubmitCommand = new Xamarin.Forms.Command(OnSubmitAsync);
            clienteService = new ClienteService();
            cli = new Cliente();
        }
        public async void OnSubmitAsync()
        {
            String cliente = await clienteService.addCliente(cli);

            if (cliente.Length > 30 && cliente.Length < 50)
            {
                if (App.Current.Properties.ContainsKey("LoginIdCliente"))
                {
                    App.Current.Properties.Remove("LoginIdCliente");
                    App.Current.Properties.Remove("LoginTelefone");
                }
                App.Current.Properties.Add("LoginIdCliente", cliente);
                App.Current.Properties.Add("LoginTelefone", cli.Telefone);
                App.Current.Properties.Add("LoginSenha", cli.Senha);
                await App.Current.SavePropertiesAsync();

                await Application.Current.MainPage.DisplayAlert("", "Cadastro realizado com sucesso!", "OK");

                Application.Current.MainPage = new Menu();
                App.NavegarParaPaginaInicial();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("", "Falha ao realizar cadastro!", "OK");
            }
        }

        public IList<string> ListaTipoSanguineo
        {
            get
            {
                return new ClienteService().ListaTipoSanguineo();
            }
        }
    }
}
