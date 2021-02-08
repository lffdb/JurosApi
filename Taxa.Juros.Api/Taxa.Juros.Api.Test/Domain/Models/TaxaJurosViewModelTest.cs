using Desafio1.Application.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Desafio1.Test.Domain.Models
{
    [TestClass]
    public class TaxaJurosViewModelTest
    {
        [TestMethod]
        public void TaxaJurosViewModel_Juros_Valida_Valor_Fixo()
        {
            decimal esperado = 0.01M;

            Assert.AreEqual(esperado, TaxaJurosViewModel.Juros);
        }
    }
}
