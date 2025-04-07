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

            if (tempoDeEstadia <= 15)
                return 0;
            else if (tempoDeEstadia >= 16)
                return 13;
            else if (tempoDeEstadia >=31)
                return 19;
            else
                return 26;
        }

        public void RegistrarPagamento()
        {
            ValorPago = true;
            
        }
        public string SaidaFormatada
        {
            get
            {
                return Saida.HasValue ? Saida.Value.ToString("dd/MM/yyyy HH:mm:ss") : "";
            }
        }
    }

}
