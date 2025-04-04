using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento_basico
{
    public class Veiculo
    {
        public string? Placa { get; set; }
        public int Ticket { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
       /* public double TempoDeEstadia
        {
            get
            {
                DateTime horaAtual = DateTime.Now;
                TimeSpan? duracao = Saida.HasValue ? Saida.Value - Entrada : horaAtual - Entrada;
                return duracao.Value.TotalMinutes;
            }
        }
       */

        public double Valor
        {
            get
            {
                return CalcularCobranca();
            }
            set
            {
                // This setter is not needed and can be removed
            }
        }

        public bool ValorPago { get; set; }
        public void RegistrarEntrada(DateTime Dataentrada)
        {
            Entrada = Dataentrada;
            Console.WriteLine($"Carro com placa {Placa} entrou às {Entrada}.");
        }

        public void RegistrarSaida(DateTime dataHoraSaida)
        {
            if (ValorPago == true)
            {
                Saida = dataHoraSaida;
            }
            else
            {
                // Ação a ser tomada se o valor não foi pago, por exemplo, lançar uma exceção ou registrar um log
                MessageBox.Show("O pagamento não foi realizado. Saída não registrada.");
            }
        }

        public double CalcularCobranca()
        {
            double tempoDeEstadia = (DateTime.Now - Entrada).TotalMinutes;

            if (tempoDeEstadia <= 60)
                return 5;
            else if (tempoDeEstadia <= 120)
                return 10;
            else
                return 15;
        }

        public void RegistrarPagamento()
        {
            ValorPago = true;
            
        }
    }

}
