using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento_basico
{
    public class Carro : Veiculo
    {
        private static Random random = new Random();

        public Carro(DateTime saida,string placa)
        {
            
        }

        public Carro(string placa)
        {
            Placa = placa;
            Ticket = random.Next(1000, 9999); // Gera um número aleatório entre 1000 e 9999
            ValorPago = false;
        }
       
    }
}
