//using Android.Content.Res;
using Orez360.Services;
using Orez360.Views;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Orez360.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action ExibirAvisoDeLoginInvalido;

        private ClienteService clienteService;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefone"));
            }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Senha"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Xamarin.Forms.Command(OnSubmit);
            CreateUser = new Xamarin.Forms.Command(Create);
            clienteService = new ClienteService();

        }
        public async void OnSubmit()
        {
            String cliente = await clienteService.getLogin(this.telefone, this.senha);
            
            if (cliente != null)
            {
                App.Current.Properties.Add("LoginIdCliente", cliente);
                App.Current.Properties.Add("LoginTelefone", telefone);
                App.Current.Properties.Add("LoginSenha", senha);
                await App.Current.SavePropertiesAsync();

                Application.Current.MainPage = new Menu();
                App.NavegarParaPaginaInicial();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("", "Falha ao fazer login!", "OK");
            }
        }
        public ICommand CreateUser { protected set; get; }
        public void Create()
        {

            Application.Current.MainPage = new Cliente();
            //Shell.Current.GoToAsync("menu"); ;
            App.NavegarParaPaginaCadastro();
        }
    }
}
