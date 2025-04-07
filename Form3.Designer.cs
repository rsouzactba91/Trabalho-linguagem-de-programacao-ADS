namespace estacionamento_basico
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnpagar = new Button();
            label1 = new Label();
            txbplaca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbticket = new TextBox();
            label4 = new Label();
            txtbentrada = new TextBox();
            label5 = new Label();
            txbsaida = new TextBox();
            label6 = new Label();
            txbtempo = new TextBox();
            label7 = new Label();
            txbvalor = new TextBox();
            label8 = new Label();
            txbvalorpago = new TextBox();
            SuspendLayout();
            // 
            // btnpagar
            // 
            btnpagar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpagar.Location = new Point(311, 97);
            btnpagar.Name = "btnpagar";
            btnpagar.Size = new Size(173, 43);
            btnpagar.TabIndex = 0;
            btnpagar.Text = "PAGAR";
            btnpagar.UseVisualStyleBackColor = true;
            btnpagar.Click += btnpagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 1;
            label1.Text = "Efetue o pagamento";
            // 
            // txbplaca
            // 
            txbplaca.Location = new Point(10, 68);
            txbplaca.Name = "txbplaca";
            txbplaca.Size = new Size(100, 23);
            txbplaca.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 50);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 50);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Ticket";
            // 
            // txbticket
            // 
            txbticket.Location = new Point(123, 68);
            txbticket.Name = "txbticket";
            txbticket.Size = new Size(100, 23);
            txbticket.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 50);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Entrada";
            // 
            // txtbentrada
            // 
            txtbentrada.Location = new Point(236, 68);
            txtbentrada.Name = "txtbentrada";
            txtbentrada.Size = new Size(100, 23);
            txtbentrada.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 50);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Saida";
            // 
            // txbsaida
            // 
            txbsaida.Location = new Point(351, 68);
            txbsaida.Name = "txbsaida";
            txbsaida.Size = new Size(100, 23);
            txbsaida.TabIndex = 11;
            txbsaida.TextChanged += txbsaida_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 50);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 14;
            label6.Text = "Tempo de estadia";
            // 
            // txbtempo
            // 
            txbtempo.Location = new Point(468, 68);
            txbtempo.Name = "txbtempo";
            txbtempo.Size = new Size(100, 23);
            txbtempo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 50);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Valor";
            // 
            // txbvalor
            // 
            txbvalor.Location = new Point(577, 68);
            txbvalor.Name = "txbvalor";
            txbvalor.Size = new Size(100, 23);
            txbvalor.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(678, 50);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 18;
            label8.Text = "Valor Pago";
            // 
            // txbvalorpago
            // 
            txbvalorpago.Location = new Point(698, 68);
            txbvalorpago.Name = "txbvalorpago";
            txbvalorpago.Size = new Size(22, 23);
            txbvalorpago.TabIndex = 17;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 152);
            Controls.Add(label8);
            Controls.Add(txbvalorpago);
            Controls.Add(label7);
            Controls.Add(txbvalor);
            Controls.Add(label6);
            Controls.Add(txbtempo);
            Controls.Add(label5);
            Controls.Add(txbsaida);
            Controls.Add(label4);
            Controls.Add(txtbentrada);
            Controls.Add(label3);
            Controls.Add(txbticket);
            Controls.Add(label2);
            Controls.Add(txbplaca);
            Controls.Add(label1);
            Controls.Add(btnpagar);
            Name = "Form3";
            Text = "-P";
          ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpagar;
        private Label label1;
        private TextBox txbplaca;
        private Label label2;
        private Label label3;
        private TextBox txbticket;
        private Label label4;
        private TextBox txtbentrada;
        private Label label5;
        private TextBox txbsaida;
        private Label label6;
        private TextBox txbtempo;
        private Label label7;
        private TextBox txbvalor;
        private Label label8;
        private TextBox txbvalorpago;
    }
}