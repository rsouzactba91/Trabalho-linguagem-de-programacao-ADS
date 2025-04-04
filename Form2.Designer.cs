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
            btnsair = new Button();
            label2 = new Label();
            dgvlistadeveiculos = new DataGridView();
            btnentrada = new Button();
            btnsaida = new Button();
            label1 = new Label();
            txbentrada = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvlistadeveiculos).BeginInit();
            SuspendLayout();
            // 
            // btnsair
            // 
            btnsair.Location = new Point(415, 16);
            btnsair.Margin = new Padding(3, 4, 3, 4);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(324, 140);
            btnsair.TabIndex = 15;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 182);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 17;
            label2.Text = "Lista de veiculos";
            // 
            // dgvlistadeveiculos
            // 
            dgvlistadeveiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadeveiculos.Location = new Point(12, 237);
            dgvlistadeveiculos.Margin = new Padding(3, 4, 3, 4);
            dgvlistadeveiculos.Name = "dgvlistadeveiculos";
            dgvlistadeveiculos.RowHeadersWidth = 45;
            dgvlistadeveiculos.Size = new Size(727, 300);
            dgvlistadeveiculos.TabIndex = 16;
            // 
            // btnentrada
            // 
            btnentrada.Location = new Point(295, 19);
            btnentrada.Margin = new Padding(3, 4, 3, 4);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(86, 60);
            btnentrada.TabIndex = 24;
            btnentrada.Text = "confirmar";
            btnentrada.UseVisualStyleBackColor = true;
            btnentrada.Click += button1_Click;
            // 
            // btnsaida
            // 
            btnsaida.Location = new Point(295, 87);
            btnsaida.Margin = new Padding(3, 4, 3, 4);
            btnsaida.Name = "btnsaida";
            btnsaida.Size = new Size(86, 69);
            btnsaida.TabIndex = 26;
            btnsaida.Text = "Pagar";
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
            txbentrada.Location = new Point(139, 22);
            txbentrada.Margin = new Padding(3, 4, 3, 4);
            txbentrada.Name = "txbentrada";
            txbentrada.Size = new Size(114, 27);
            txbentrada.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 552);
            Controls.Add(btnsaida);
            Controls.Add(btnentrada);
            Controls.Add(txbentrada);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvlistadeveiculos);
            Controls.Add(btnsair);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvlistadeveiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnsair;
        private Label label2;
        private DataGridView dgvlistadeveiculos;
        private Button btnentrada;
        private Button btnsaida;
        private Label label1;
        private TextBox txbentrada;
    }
}