using Desafio1.Application.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioApi1.Application.Controllers
{
    /// <summary>
    /// API 1
    /// </summary>
    [Route("")]
    [ApiController]
    public class DesafioController : ControllerBase
    {
        /// <summary>
        /// Taxa de juros
        /// </summary>
        /// <returns></returns>        
        [HttpGet()]
        [Route("taxaJuros")]        
        public IActionResult TaxaJuros()
        {            
            return Created(string.Empty, TaxaJurosViewModel.Juros.ToString("N2"));
        }
    }
}
