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
        public int TempoDeEstadia { get; set; }
        public double Valor
        {
            get
            {
                double taxaPorHora = 10;
                return Math.Ceiling(TempoDeEstadia / 60.0) * taxaPorHora;
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
            if (ValorPago)
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
            return Valor;
        }

        public void RegistrarPagamento()
        {
            ValorPago = true;
            Console.WriteLine($"Pagamento registrado para o carro de placa {Placa}.");
        }
    }

}
