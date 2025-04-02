namespace estacionamento_basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            if (txblogin.Text == "admin" && txbsenha.Text == "admin")
            {
                MessageBox.Show("Bem vindo ao sistema");
                form.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos");
            }
        }

        public void UpdateLabel()
        {
            string loginok = txblogin.Text;
            string senhaok = txbsenha.Text;

            if (loginok == "admin" && senhaok == "admin")
            {
                lblmsg.Text = "Login efetuado com sucesso!" + " " + loginok + "\n" + "Redirecionado";
            }
            else
            {
                lblmsg.Text = "Login ou senha incorretos!";
            }
            if (loginok == "admin" && senhaok == "admin")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void lblmsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
