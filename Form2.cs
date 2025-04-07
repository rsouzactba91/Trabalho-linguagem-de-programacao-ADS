using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace estacionamento_basico
{
    public partial class Form2 : Form
    {
        private List<Veiculo> listaVeiculo = new List<Veiculo>();

        public Form2()
        {
            InitializeComponent();
            dgvlistadeveiculos.DataSource = null;
            dgvlistadeveiculos.DataSource = listaVeiculo;
            dgvlistadeveiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlistadeveiculos.MultiSelect = false; 
        }

        private void AtualizarDataGrid()
        {
            dgvlistadeveiculos.DataSource = null;
            dgvlistadeveiculos.DataSource = listaVeiculo.ToList();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placaDigitada = txbentrada.Text.Trim().ToUpper();

           bool placaEmAberto = listaVeiculo.Any(v => v.Placa == placaDigitada && v.Saida == null);

            if (placaEmAberto)
            {
                MessageBox.Show("Este veículo já está registrado no sistema e ainda não saiu.", "Entrada duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.Placa = placaDigitada;
            veiculo.Ticket = listaVeiculo.Count + 1;
            veiculo.RegistrarEntrada(DateTime.Now);

            listaVeiculo.Add(veiculo);
            AtualizarDataGrid();
            limpar();
        }

        public bool desabilitarcolunadgv()
        {
            bool algumVeiculoPago = listaVeiculo.Any(v => v.ValorPago);

            if (algumVeiculoPago)
            {
                foreach (DataGridViewColumn coluna in dgvlistadeveiculos.Columns)
                {
                    coluna.ReadOnly = true;
                    coluna.DefaultCellStyle.BackColor = Color.Red; // Cor de fundo vermelha
                    coluna.DefaultCellStyle.ForeColor = Color.White; // Cor do texto branca para contraste
                }
            }

            return algumVeiculoPago;
        }





        private void btnsaida_Click(object sender, EventArgs e)
        {
            if (dgvlistadeveiculos.SelectedRows.Count > 0)
            {
                int rowIndex = dgvlistadeveiculos.SelectedRows[0].Index;
                Veiculo veiculoSelecionado = listaVeiculo[rowIndex]; // Pega o objeto da lista

                if (!veiculoSelecionado.ValorPago)
                {
                    Form3 form3 = new Form3(veiculoSelecionado);

                    if (form3.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarDataGrid();
                        desabilitarcolunadgv();
                    }
                }
                else
                {
                    MessageBox.Show("O pagamento já foi efetuado. Redirecionando...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma placa selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void limpar()
        {
            txbentrada.Text = string.Empty;
          
        }


        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    


