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
           dgvlistadeveiculos.DataSource = listaVeiculo.ToList();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnadmin_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
     

     /*   private void txbsaida_TextChanged(object sender, EventArgs e)
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
        }*/

       

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
        {
            dgvlistadeveiculos.SelectedRows[0].Cells["Placa"].Value.ToString();
            /*if (veiculo.ValorPago)
            {
                veiculo.RegistrarSaida(DateTime.Now);
            }
            else
            {
                // Captura a linha selecionada no DataGridView*/
                if (dgvlistadeveiculos.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvlistadeveiculos.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dgvlistadeveiculos.Rows[rowIndex];

                    // Captura todas as informações necessárias da linha selecionada
                    string? placaSelecionada = selectedRow.Cells["Placa"].Value?.ToString();
                    int ticket = Convert.ToInt32(selectedRow.Cells["Ticket"].Value);
                    DateTime entrada = Convert.ToDateTime(selectedRow.Cells["Entrada"].Value);
                    DateTime? saida = selectedRow.Cells["Saida"].Value as DateTime?;
                    int tempoDeEstadia = Convert.ToInt32(selectedRow.Cells["TempoDeEstadia"].Value);
                    double valor = Convert.ToDouble(selectedRow.Cells["Valor"].Value);
                    bool valorPago = Convert.ToBoolean(selectedRow.Cells["ValorPago"].Value);

                    // Atualiza o objeto veiculo com as informações capturadas
                    veiculo.Placa = placaSelecionada;
                    veiculo.Ticket = ticket;
                    veiculo.Entrada = entrada;
                    veiculo.Saida = saida;
                    veiculo.TempoDeEstadia = tempoDeEstadia;
                    veiculo.ValorPago = valorPago;

                    // Abre o Form3 e passa a placa
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Nenhuma placa selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }



