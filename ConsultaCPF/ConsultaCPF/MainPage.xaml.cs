using System;
using Xamarin.Forms;
using ConsultaCPF.Servico;
using ConsultaCPF.Servico.Modelo;


namespace ConsultaCPF
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      BTNBUSCAR.Clicked += Buscar;

    }

    private void Buscar(object sender, EventArgs args)
    {
      var cepDigitado = CEP.Text;
      var end = ViaCEPServico.BuscarEndercoViaCEP(cepDigitado);

      RETORNO.Text = $"Endereço: {end.Logradouro} de {end.Bairro} {end.Localidade} {end.Uf}";
    }
  }
}
