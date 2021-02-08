using Desafio2.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Desafio2.Test.Domain.Models
{
    [TestClass]
    public class JurosViewModelTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void JurosViewMode_Valida_ValorInicial_Negativo()
        {
            new JurosViewModel(-1, 0, 0);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void JurosViewMode_Valida_Juros_Negativo()
        {
            new JurosViewModel(0, -1, 0);
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void JurosViewMode_Valida_Tempo_Negativo()
        {
            new JurosViewModel(0, 0 , -1);
            Assert.Fail();
        }
        [TestMethod]
        public void JurosViewMode_Valida_Calculo()
        {
            decimal valorInicial = 100;
            decimal juros = 0.01M;
            int tempo = 5;
            decimal esperado = 105.10M;

            JurosViewModel jurosViewModel = new JurosViewModel(valorInicial, juros, tempo);

            Assert.AreEqual(esperado, jurosViewModel.ValorTotal);
        }
        [TestMethod]
        public void JurosViewMode_Valida_Truncamento()
        {
            decimal valorInicial = 137;
            decimal juros = 0.01M;
            int tempo = 5;
            decimal esperado = 143.98M;

            JurosViewModel jurosViewModel = new JurosViewModel(valorInicial, juros, tempo);

            Assert.AreEqual(esperado, jurosViewModel.ValorTotal);
        }
    }
}
