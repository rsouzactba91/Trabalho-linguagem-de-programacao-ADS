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
        public DateTime? Saida { get; set; } // Alterado para nullable para evitar valores inválidos
        public double TempoDeEstadia
        {
            get
            {
                Entrada = DateTime.Now;

                    return TempoDeEstadia;
            }
            set {
                DateTime horaAtual = DateTime.Now;

                Saida.HasValue ? (Saida.Value - Entrada).TotalMinutes : (horaAtual - Entrada).TotalMinutes;
            }
        }

        public double Valor
        {
            get
            {
                CalcularCobranca(); return Valor;
                
            }
            set { }
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
            double tempoDeEstadia = TempoDeEstadia;

            if (tempoDeEstadia <= 60)
                Valor = 5;
            else if (tempoDeEstadia <= 120)
                Valor = 10;
            else
                Valor = 15;

            ValorPago = false;

            return Valor;
        }

        public void RegistrarPagamento()
        {
            ValorPago = true;
            
        }
    }

}
