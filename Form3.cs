using System;
using System.Globalization;
using System.Windows.Forms;

namespace estacionamento_basico
{
    public partial class Form3 : Form
    {
        public Veiculo VeiculoEditado { get; private set; }

        public Form3(Veiculo veiculo)
        {
            InitializeComponent();

            VeiculoEditado = veiculo;
            txbplaca.Text = veiculo.Placa;
            txbticket.Text = veiculo.Ticket.ToString();
            txtbentrada.Text = veiculo.Entrada.ToString("dd/MM/yyyy HH:mm:ss");
            txbsaida.Text = veiculo.SaidaFormatada;
            double valorCalculado = veiculo.CalcularCobranca();
            txbvalor.Text = valorCalculado.ToString("C");
            txbvalorpago.Text = veiculo.ValorPago ? "Pago" : "Não Pago";

            txbplaca.Enabled = false;
            txbticket.Enabled = false;
            txtbentrada.Enabled = false;
            txbsaida.Enabled = false;
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoEditado.RegistrarPagamento(); // Registra pagamento
                VeiculoEditado.Saida = DateTime.Now; // Atualiza a saída

                this.DialogResult = DialogResult.OK; // Retorna OK para indicar atualização
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbsaida_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

    

