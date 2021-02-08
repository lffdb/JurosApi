using System.Threading.Tasks;

namespace Desafio2.Domain.Services
{
    public interface IConsultarTaxaServices
    {
        Task<decimal> ObterJurosAsync();
    }
}
