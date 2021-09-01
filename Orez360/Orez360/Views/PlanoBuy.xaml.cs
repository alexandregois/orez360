using Orez360.ViewModels;
using Orez360.Views.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Orez360.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanoBuy : ContentPage
    {
        public PlanoBuy()
        {
            InitializeComponent();
        }

        PagamentoCartao pagCartao = new PagamentoCartao();

        PagamentoPix pagPix = new PagamentoPix();

        private void PagamentoBoleto(object sender, EventArgs e)
        {
            if (this.StackChangeId.Children.Contains(pagCartao) || this.StackChangeId.Children.Contains(pagPix))
            {
                try
                {
                    this.StackChangeId.Children.Remove(pagCartao);
                    this.StackChangeId.Children.Remove(pagPix);
                }
                catch
                {
                    Console.WriteLine("Não há");
                }

                this.ImgBoleto.Source = "boleto_ativo";
                this.ImgCartao.Source = "cartao";
                this.ImgPix.Source = "pix";

                this.FrameBoleto.BackgroundColor = Color.FromHex("#5CBCC4");
                this.FrameCartao.BackgroundColor = Color.FromHex("#FFFFFF");
                this.FramePix.BackgroundColor = Color.FromHex("#FFFFFF");

                this.LabelBoleto.TextColor = Color.White;
                this.LabelCartao.TextColor = Color.LightGray;
                this.LabelPix.TextColor = Color.LightGray;
            }
        }
        private void PagamentoComCartao(object sender, EventArgs e)
        {
            if (!this.StackChangeId.Children.Contains(pagCartao))
            {
                try
                {
                    this.StackChangeId.Children.Remove(pagPix);
                }
                catch
                {
                    Console.WriteLine("Não há");
                }
                this.StackChangeId.Children.Add(pagCartao);

                this.ImgBoleto.Source = "boleto";
                this.ImgCartao.Source = "cartao_ativo";
                this.ImgPix.Source = "pix";

                this.FrameBoleto.BackgroundColor = Color.FromHex("#FFFFFF");
                this.FrameCartao.BackgroundColor = Color.FromHex("#5CBCC4");
                this.FramePix.BackgroundColor = Color.FromHex("#FFFFFF");

                this.LabelBoleto.TextColor = Color.LightGray;
                this.LabelCartao.TextColor = Color.White;
                this.LabelPix.TextColor = Color.LightGray;
            }
        }
        private void PagamentoComPix(object sender, EventArgs e)
        {
            if (!this.StackChangeId.Children.Contains(pagPix))
            {
                try
                {
                    this.StackChangeId.Children.Remove(pagCartao);
                }
                catch
                {
                    Console.WriteLine("Não há");
                }
                this.StackChangeId.Children.Add(pagPix);

                this.ImgBoleto.Source = "boleto";
                this.ImgCartao.Source = "cartao";
                this.ImgPix.Source = "pix_ativo";

                this.FrameBoleto.BackgroundColor = Color.FromHex("#FFFFFF");
                this.FrameCartao.BackgroundColor = Color.FromHex("#FFFFFF");
                this.FramePix.BackgroundColor = Color.FromHex("#5CBCC4");

                this.LabelBoleto.TextColor = Color.LightGray;
                this.LabelCartao.TextColor = Color.LightGray;
                this.LabelPix.TextColor = Color.White;
            }
        }
    }
}