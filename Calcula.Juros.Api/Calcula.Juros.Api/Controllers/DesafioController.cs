using Desafio2.Domain.Models;
using Desafio2.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Desafio2.Controllers
{
    /// <summary>
    /// API 2
    /// </summary>
    [Route("")]
    [ApiController]
    public class DesafioController : ControllerBase
    {        
        private readonly IConsultarTaxaServices _consultarTaxaServices;
        private readonly IConfiguration _configuration;
        public DesafioController(IConsultarTaxaServices consultarJurosServices, 
                                 IConfiguration configuration)
        {            
            _consultarTaxaServices = consultarJurosServices;
            _configuration = configuration;
        }

        /// <summary>
        /// Calcular Juros 
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("calcularJuros")]                
        public async Task<IActionResult> CalcularJurosAsync(decimal valorInicial, int tempo)
        {
            var juros = await _consultarTaxaServices.ObterJurosAsync();
            var taxas = new JurosViewModel(valorInicial, juros, tempo);

            return Created(string.Empty, taxas.ValorTotal.ToString("N2"));
        }
        /// <summary>
        /// Exibir url dos fontes no git
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [Route("showmethecode")]
        public IActionResult ShowMeTheCode()
        {
            return Created(string.Empty, _configuration.GetSection("Git").Value);
        }
    }
}
