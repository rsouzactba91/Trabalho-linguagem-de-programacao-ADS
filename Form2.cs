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

        private void btnsaida_Click(object sender, EventArgs e)
        {
            if (dgvlistadeveiculos.SelectedRows.Count > 0)
            {
                int rowIndex = dgvlistadeveiculos.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvlistadeveiculos.Rows[rowIndex];

                string? placaSelecionada = selectedRow.Cells["Placa"].Value?.ToString();
                int ticket = Convert.ToInt32(selectedRow.Cells["Ticket"].Value);
                DateTime entrada = Convert.ToDateTime(selectedRow.Cells["Entrada"].Value);

                Veiculo veiculoSelecionado = listaVeiculo.FirstOrDefault(v => v.Placa == placaSelecionada && v.Ticket == ticket);

                if (veiculoSelecionado != null)
                {
                    Form3 form3 = new Form3(veiculoSelecionado);
                    if (form3.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma placa selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
