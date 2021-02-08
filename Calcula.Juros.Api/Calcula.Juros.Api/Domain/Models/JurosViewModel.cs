using System;

namespace Desafio2.Domain.Models
{
    public class JurosViewModel
    {
        private decimal _valorInicial { get; set; }        
        private decimal _juros { get; set; }
        private int _tempo { get; set; }
        public decimal ValorTotal { get 
            { 
                return Math.Truncate(_valorInicial * (decimal)Math.Pow((double)(1 + _juros), _tempo) * 100) / 100; 
            }
        }
        public JurosViewModel(decimal valorInicial, decimal juros, int tempo)
        {
            if (valorInicial < 0)
                throw new ArgumentException("Valor inicial invalido!");
            if (juros < 0)
                throw new ArgumentException("Juros invalido!");
            if (tempo < 0)
                throw new ArgumentException("Tempo invalido!");

            _valorInicial = valorInicial;
            _juros = juros;
            _tempo = tempo;                       
        }
    }
}
