using ConsultaCPF.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace ConsultaCPF.Servico
{
  public class ViaCEPServico
  {
    private static string url = "http://viacep.com.br/ws/{0}/json/";

    public static Endereco BuscarEndercoViaCEP(string cep)
    {
      string urlCompleta = string.Format(url, cep);

      WebClient cliente = new WebClient();
      string retorno = cliente.DownloadString(urlCompleta);

      var enderecoRetornado = JsonConvert.DeserializeObject<Endereco>(retorno);

      return enderecoRetornado;
    }
  }
}
