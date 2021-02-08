using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Testar_APIs
{
    public class TestarApis
    {
        public static void Main()
        {

            Console.WriteLine($"Response API 1 Endpoint '/taxaJuros' {TestarAPI11Async()}");
            Console.WriteLine($"Response API 2 Endpoint '/calcularJuros' {TestarAPI21Async()}");
            Console.WriteLine($"Response API 2 Endpoint '/showmethecode' {TestarAPI22Async()}");
        }
        public static string TestarAPI11Async()
        {
            var requisicao = WebRequest.CreateHttp(string.Format("http://localhost:60593/taxaJuros"));
            requisicao.Method = HttpMethod.Get.Method;

            using (var resposta = requisicao.GetResponse())
            {
                var dados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(dados);
                object response = reader.ReadToEnd();

                return response.ToString();
            }
        }
        public static string TestarAPI21Async()
        {
            var requisicao = WebRequest.CreateHttp(string.Format("http://localhost:52072/calcularJuros"));
            requisicao.Method = HttpMethod.Get.Method;            
            requisicao.Headers.Add("valorInicial","100");
            requisicao.Headers.Add("tempo", "5");

            using (var resposta = requisicao.GetResponse())
            {
                var dados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(dados);
                object response = reader.ReadToEnd();

                return response.ToString();
            }
        }
        public static string TestarAPI22Async()
        {
            var requisicao = WebRequest.CreateHttp(string.Format("http://localhost:52072/showmethecode"));
            requisicao.Method = HttpMethod.Get.Method;

            using (var resposta = requisicao.GetResponse())
            {
                var dados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(dados);
                object response = reader.ReadToEnd();

                return response.ToString();
            }
        }

    }
}
