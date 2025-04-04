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
            btnentrada = new Button();
            btncobranca = new Button();
            btnsaida = new Button();
            label1 = new Label();
            txbentrada = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlistadeveiculos).BeginInit();
            SuspendLayout();
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(696, 29);
            btnadmin.Margin = new Padding(3, 4, 3, 4);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(173, 85);
            btnadmin.TabIndex = 14;
            btnadmin.Text = "Administrativo";
            btnadmin.UseVisualStyleBackColor = true;
          //  btnadmin.Click += btnadmin_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(696, 140);
            btnsair.Margin = new Padding(3, 4, 3, 4);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(173, 85);
            btnsair.TabIndex = 15;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 252);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 17;
            label2.Text = "Lista de veiculos";
            // 
            // dgvlistadeveiculos
            // 
            dgvlistadeveiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadeveiculos.Location = new Point(14, 296);
            dgvlistadeveiculos.Margin = new Padding(3, 4, 3, 4);
            dgvlistadeveiculos.Name = "dgvlistadeveiculos";
            dgvlistadeveiculos.RowHeadersWidth = 45;
            dgvlistadeveiculos.Size = new Size(855, 300);
            dgvlistadeveiculos.TabIndex = 16;
            // 
            // btnentrada
            // 
            btnentrada.Location = new Point(295, 19);
            btnentrada.Margin = new Padding(3, 4, 3, 4);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(86, 31);
            btnentrada.TabIndex = 24;
            btnentrada.Text = "confirmar";
            btnentrada.UseVisualStyleBackColor = true;
            btnentrada.Click += button1_Click;
            // 
            // btncobranca
            // 
            btncobranca.Location = new Point(295, 71);
            btncobranca.Margin = new Padding(3, 4, 3, 4);
            btncobranca.Name = "btncobranca";
            btncobranca.Size = new Size(86, 31);
            btncobranca.TabIndex = 25;
            btncobranca.Text = "Cobrar";
            btncobranca.UseVisualStyleBackColor = true;
           // btncobranca.Click += btncobranca_Click;
            // 
            // btnsaida
            // 
            btnsaida.Location = new Point(295, 125);
            btnsaida.Margin = new Padding(3, 4, 3, 4);
            btnsaida.Name = "btnsaida";
            btnsaida.Size = new Size(86, 31);
            btnsaida.TabIndex = 26;
            btnsaida.Text = "Sair";
            btnsaida.UseVisualStyleBackColor = true;
            btnsaida.Click += btnsaida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 18;
            label1.Text = "Efetuar entrada";
            // 
            // txbentrada
            // 
            txbentrada.Location = new Point(145, 16);
            txbentrada.Margin = new Padding(3, 4, 3, 4);
            txbentrada.Name = "txbentrada";
            txbentrada.Size = new Size(114, 27);
            txbentrada.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 612);
            Controls.Add(btnsaida);
            Controls.Add(btncobranca);
            Controls.Add(btnentrada);
            Controls.Add(txbentrada);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvlistadeveiculos);
            Controls.Add(btnsair);
            Controls.Add(btnadmin);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnentrada;
        private Button btncobranca;
        private Button btnsaida;
        private Label label1;
        private TextBox txbentrada;
    }
}