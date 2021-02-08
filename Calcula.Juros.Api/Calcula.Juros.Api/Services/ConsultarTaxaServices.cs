using Desafio2.Domain.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Desafio2.Services
{
    public class ConsultarTaxaServices : IConsultarTaxaServices
    {
        static readonly HttpClient _client = new HttpClient();
        private readonly IConfiguration _configuration;

        public ConsultarTaxaServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<decimal> ObterJurosAsync()
        {
            var taxaJuros = string.Empty;
            var urlBase = _configuration.GetSection("HostApis:TaxaJuros").Value;
            HttpResponseMessage response = await _client.GetAsync($"{urlBase}taxaJuros");
            if (response.IsSuccessStatusCode)
            {
                taxaJuros = await response.Content.ReadAsStringAsync();
            }
            return Convert.ToDecimal(taxaJuros);
        }
    }
}
