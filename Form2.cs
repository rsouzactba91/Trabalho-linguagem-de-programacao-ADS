using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace estacionamento_basico
{
    public partial class Form2 : Form
    {
        private Veiculo veiculo; // Adiciona a declaração do campo veiculo

        public Form2()
        {
            InitializeComponent();
            veiculo = new Veiculo(); // Inicializa o campo veiculo
            dgvlistadeveiculos.DataSource = listaVeiculo;
        }
        private List<Veiculo> listaVeiculo = new List<Veiculo>();

       
        
            

        private void AtualizarDataGrid()
        {
            dgvlistadeveiculos.DataSource = null;
            dgvlistadeveiculos.DataSource = listaVeiculo;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnadmin_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
        private void txbentrada_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txbsaida_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txbsaida.Text, out DateTime saida))
            {
                veiculo.RegistrarSaida(saida);
                MessageBox.Show($"Saída registrada: {saida}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza automaticamente o campo de cobrança
                txbcobranca.Text = veiculo.CalcularCobranca().ToString("C");
            }
            else
            {
                MessageBox.Show("Digite uma data e hora válidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbsaida.Clear();
            }
        }
        private void txbcobranca_TextChanged(object sender, EventArgs e)
        {
            // Apenas exibe o valor atualizado
            txbcobranca.Text = veiculo.CalcularCobranca().ToString("C");
        }
        // Método para registrar o pagamento (chamado por um botão, por exemplo)
        private void btnRegistrarPagamento_Click(object sender, EventArgs e)
        {
            veiculo.RegistrarPagamento();
            MessageBox.Show("Pagamento registrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo(); // Passa a placa como argumento para o construtor
            veiculo.Placa = txbentrada.Text; // Atribui a placa ao veículo
            veiculo.Ticket = listaVeiculo.Count + 1; // Atribui o ticket ao veículo
            veiculo.RegistrarEntrada(DateTime.Now); // Registra a entrada do veículo
            listaVeiculo.Add(veiculo); // Adiciona a instância de Carro à lista
            AtualizarDataGrid(); // Atualiza o DataGridView
        }



        private void btncobranca_Click(object sender, EventArgs e)
        {

        }

        private void btnsaida_Click(object sender, EventArgs e)
        {veiculo.Placa = txbsaida.Text;
            if (veiculo.ValorPago)
            {
                veiculo.RegistrarSaida(DateTime.Now);
            }
            else
            {
                // Captura a placa selecionada no DataGridView
                string? placaSelecionada = dgvlistadeveiculos.SelectedRows[0].Cells["Placa"].Value.ToString();

                // Abre o Form3 e passa a placa
                Form3 form3 = new Form3(placaSelecionada);
                form3.Show();
            }
        }

    }
}


