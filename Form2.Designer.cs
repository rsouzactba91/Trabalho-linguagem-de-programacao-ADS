namespace estacionamento_basico
{
    partial class Form2
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
            btnadmin = new Button();
            btnsair = new Button();
            label2 = new Label();
            dgvlistadeveiculos = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbentrada = new TextBox();
            txbcobranca = new TextBox();
            txbsaida = new TextBox();
            btnentrada = new Button();
            btncobranca = new Button();
            btnsaida = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvlistadeveiculos).BeginInit();
            SuspendLayout();
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(609, 22);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(151, 64);
            btnadmin.TabIndex = 14;
            btnadmin.Text = "Administrativo";
            btnadmin.UseVisualStyleBackColor = true;
            btnadmin.Click += btnadmin_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(609, 105);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(151, 64);
            btnsair.TabIndex = 15;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 189);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 17;
            label2.Text = "Lista de veiculos";
            // 
            // dgvlistadeveiculos
            // 
            dgvlistadeveiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadeveiculos.Location = new Point(12, 222);
            dgvlistadeveiculos.Name = "dgvlistadeveiculos";
            dgvlistadeveiculos.Size = new Size(748, 225);
            dgvlistadeveiculos.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 18;
            label1.Text = "Efetuar entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 61);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 19;
            label3.Text = "Efetuar cobrança";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 94);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 20;
            label4.Text = "Efetuar saida";
            // 
            // txbentrada
            // 
            txbentrada.Location = new Point(127, 12);
            txbentrada.Name = "txbentrada";
            txbentrada.Size = new Size(100, 23);
            txbentrada.TabIndex = 21;
            // 
            // txbcobranca
            // 
            txbcobranca.Location = new Point(127, 53);
            txbcobranca.Name = "txbcobranca";
            txbcobranca.Size = new Size(100, 23);
            txbcobranca.TabIndex = 22;
            txbcobranca.TextChanged += txbcobranca_TextChanged;
            // 
            // txbsaida
            // 
            txbsaida.Location = new Point(127, 94);
            txbsaida.Name = "txbsaida";
            txbsaida.Size = new Size(100, 23);
            txbsaida.TabIndex = 23;
            txbsaida.TextChanged += txbsaida_TextChanged;
            // 
            // btnentrada
            // 
            btnentrada.Location = new Point(258, 14);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(75, 23);
            btnentrada.TabIndex = 24;
            btnentrada.Text = "confirmar";
            btnentrada.UseVisualStyleBackColor = true;
            btnentrada.Click += button1_Click;
            // 
            // btncobranca
            // 
            btncobranca.Location = new Point(258, 53);
            btncobranca.Name = "btncobranca";
            btncobranca.Size = new Size(75, 23);
            btncobranca.TabIndex = 25;
            btncobranca.Text = "confirmar";
            btncobranca.UseVisualStyleBackColor = true;
            btncobranca.Click += btncobranca_Click;
            // 
            // btnsaida
            // 
            btnsaida.Location = new Point(258, 94);
            btnsaida.Name = "btnsaida";
            btnsaida.Size = new Size(75, 23);
            btnsaida.TabIndex = 26;
            btnsaida.Text = "confirmar";
            btnsaida.UseVisualStyleBackColor = true;
            btnsaida.Click += btnsaida_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 459);
            Controls.Add(btnsaida);
            Controls.Add(btncobranca);
            Controls.Add(btnentrada);
            Controls.Add(txbsaida);
            Controls.Add(txbcobranca);
            Controls.Add(txbentrada);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvlistadeveiculos);
            Controls.Add(btnsair);
            Controls.Add(btnadmin);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvlistadeveiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnadmin;
        private Button btnsair;
        private Label label2;
        private DataGridView dgvlistadeveiculos;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txbentrada;
        private TextBox txbcobranca;
        private TextBox txbsaida;
        private Button btnentrada;
        private Button btncobranca;
        private Button btnsaida;
    }
}