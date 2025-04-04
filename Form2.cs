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
            Veiculo veiculo = new Veiculo();
            veiculo.Placa = txbentrada.Text;
            veiculo.Ticket = listaVeiculo.Count + 1;
            veiculo.RegistrarEntrada(DateTime.Now);
            listaVeiculo.Add(veiculo);
            AtualizarDataGrid();

        }
        public void desabilitarcolunadgv()
        { 
            foreach (DataGridViewColumn coluna in dgvlistadeveiculos.Columns)
            {
                coluna.ReadOnly = true; // Impede edição
                coluna.DefaultCellStyle.BackColor = Color.LightGray; // Cor de fundo cinza claro
                coluna.DefaultCellStyle.ForeColor = Color.Black;  // Cor do texto em cinza escuro (opcional)
            }
        }


        private void btnsaida_Click(object sender, EventArgs e)
        {
            if (dgvlistadeveiculos.SelectedRows.Count > 0)
            {
                int rowIndex = dgvlistadeveiculos.SelectedRows[0].Index;
                Veiculo veiculoSelecionado = listaVeiculo[rowIndex]; // Obtém referência ao objeto real

                Form3 form3 = new Form3(veiculoSelecionado);

                if (form3.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDataGrid(); // Atualiza a tabela corretamente
                    desabilitarcolunadgv(); // Desabilita as colunas após atualizar
                }
            }
            else
            {
                MessageBox.Show("Nenhuma placa selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}


