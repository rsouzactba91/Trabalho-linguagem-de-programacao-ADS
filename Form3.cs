using System;
using System.Globalization;
using System.Windows.Forms;

namespace estacionamento_basico
{
    public partial class Form3 : Form
    {
        // Variável para armazenar os dados do veículo
        public Veiculo VeiculoEditado { get; private set; }

        // Construtor que recebe os dados do Form2
        public Form3(Veiculo veiculo)
        {
            InitializeComponent(); // Garante que os componentes do formulário são inicializados

            // Inicializa os valores nos campos de texto com os dados do veículo
            VeiculoEditado = veiculo;
            txbplaca.Text = veiculo.Placa;
            txbticket.Text = veiculo.Ticket.ToString();
            txtbentrada.Text = veiculo.Entrada.ToString("dd/MM/yyyy HH:mm:ss");
            txbvalor.Text = veiculo.Valor.ToString("C");
            txbvalorpago.Text = veiculo.ValorPago ? "Pago" : "Não Pago";

            // Desativa edição de campos que não devem ser alterados
            txbplaca.Enabled = false;
            txbticket.Enabled = false;
            txtbentrada.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Atualiza os dados do veículo com as edições feitas no Form3
                VeiculoEditado.Saida = DateTime.ParseExact(txbsaida.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                VeiculoEditado.Valor = double.Parse(txbvalor.Text, NumberStyles.Currency);
                VeiculoEditado.ValorPago = txbvalorpago.Text == "Pago";

                this.DialogResult = DialogResult.OK; // Indica que os dados foram salvos com sucesso
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
