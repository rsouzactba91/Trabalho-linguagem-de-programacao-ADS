using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamento_basico
{
    public partial class Form3 : Form
    {
        private Veiculo veiculoretorno = new Veiculo(); // Inicializa o campo veiculoretorno

        public Form3()
        {
            Veiculo atualizaveiculo = new Veiculo(); // Adiciona a declaração do campo veiculo
            InitializeComponent();
            txbplaca.Text = atualizaveiculo.Placa; // Define a placa no TextBox automaticamente


            txbplaca.Enabled = false; // Desabilita o TextBox da placa para edição

            txbticket.Text = atualizaveiculo.Ticket.ToString(); // Define o ticket no TextBox automaticamente
            txbticket.Enabled = false; // Desabilita o TextBox do ticket para edição

            txtbentrada.Text = atualizaveiculo.Entrada.ToString("dd/MM/yyyy HH:mm:ss"); // Define a entrada no TextBox automaticamente
            txtbentrada.Enabled = false; // Desabilita o TextBox da entrada para edição
            txbtempo.Text = atualizaveiculo.TempoDeEstadia.ToString(); // Define a cobrança no TextBox automaticamente
            txbtempo.Enabled = false; // Desabilita o TextBox da cobrança para edição
            txbvalor.Text = atualizaveiculo.Valor.ToString("C"); // Define o valor no TextBox automaticamente
            txbvalor.Enabled = false; // Desabilita o TextBox do valor para edição
            txbvalorpago.Text = atualizaveiculo.ValorPago ? "Pago" : "nao pago";
            txbvalorpago.Enabled = false; // Desabilita o TextBox do valor pago para edição
        }

        private bool button1_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculoatualizado = new Veiculo();
                veiculoatualizado.Placa = txbplaca.Text;
                veiculoatualizado.Ticket = int.Parse(txbticket.Text);
                veiculoatualizado.Entrada = DateTime.ParseExact(txtbentrada.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                veiculoatualizado.Saida = DateTime.Parse(txbsaida.Text);
                veiculoatualizado.TempoDeEstadia = int.Parse(txbtempo.Text);
                veiculoatualizado.Valor = double.Parse(txbvalor.Text);
                veiculoatualizado.ValorPago = txbvalorpago.Text == "Pago";


                // Perform any additional logic needed with veiculoatualizado here  
                this.veiculoretorno = veiculoatualizado;
                this.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      
    }
}