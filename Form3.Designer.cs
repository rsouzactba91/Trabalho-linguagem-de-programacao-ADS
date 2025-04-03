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
            btnpagar.Location = new Point(483, 152);
            btnpagar.Margin = new Padding(3, 4, 3, 4);
            btnpagar.Name = "btnpagar";
            btnpagar.Size = new Size(86, 31);
            btnpagar.TabIndex = 0;
            btnpagar.Text = "Pagar";
            btnpagar.UseVisualStyleBackColor = true;
            //btnpagar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite a placa para pagamento";
            // 
            // txbplaca
            // 
            txbplaca.Location = new Point(12, 90);
            txbplaca.Margin = new Padding(3, 4, 3, 4);
            txbplaca.Name = "txbplaca";
            txbplaca.Size = new Size(114, 27);
            txbplaca.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 66);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Ticket";
            // 
            // txbticket
            // 
            txbticket.Location = new Point(141, 90);
            txbticket.Margin = new Padding(3, 4, 3, 4);
            txbticket.Name = "txbticket";
            txbticket.Size = new Size(114, 27);
            txbticket.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 66);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 10;
            label4.Text = "Entrada";
            // 
            // txtbentrada
            // 
            txtbentrada.Location = new Point(270, 90);
            txtbentrada.Margin = new Padding(3, 4, 3, 4);
            txtbentrada.Name = "txtbentrada";
            txtbentrada.Size = new Size(114, 27);
            txtbentrada.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 66);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Saida";
            // 
            // txbsaida
            // 
            txbsaida.Location = new Point(401, 90);
            txbsaida.Margin = new Padding(3, 4, 3, 4);
            txbsaida.Name = "txbsaida";
            txbsaida.Size = new Size(114, 27);
            txbsaida.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 66);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 14;
            label6.Text = "Tempo de estadia";
            // 
            // txbtempo
            // 
            txbtempo.Location = new Point(535, 90);
            txbtempo.Margin = new Padding(3, 4, 3, 4);
            txbtempo.Name = "txbtempo";
            txbtempo.Size = new Size(114, 27);
            txbtempo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(688, 66);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 16;
            label7.Text = "Valor";
            // 
            // txbvalor
            // 
            txbvalor.Location = new Point(659, 90);
            txbvalor.Margin = new Padding(3, 4, 3, 4);
            txbvalor.Name = "txbvalor";
            txbvalor.Size = new Size(114, 27);
            txbvalor.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(775, 66);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 18;
            label8.Text = "Valor Pago";
            // 
            // txbvalorpago
            // 
            txbvalorpago.Location = new Point(798, 90);
            txbvalorpago.Margin = new Padding(3, 4, 3, 4);
            txbvalorpago.Name = "txbvalorpago";
            txbvalorpago.Size = new Size(25, 27);
            txbvalorpago.TabIndex = 17;
     
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 203);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
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