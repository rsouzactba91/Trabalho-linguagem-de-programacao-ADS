using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamento_basico
{
    public partial class Form3 : Form
    {
        public Form3(string placa)
        {
            InitializeComponent();
            textBox1.Text = placa; // Define a placa no TextBox automaticamente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Placa = textBox1.Text;
            veiculo.RegistrarPagamento();
            Close();
        }
    }
}