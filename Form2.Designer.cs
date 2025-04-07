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
            btnsair.Location = new Point(363, 12);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(284, 105);
            btnsair.TabIndex = 15;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 136);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 17;
            label2.Text = "Lista de veiculos";
            // 
            // dgvlistadeveiculos
            // 
            dgvlistadeveiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadeveiculos.Location = new Point(10, 178);
            dgvlistadeveiculos.Name = "dgvlistadeveiculos";
            dgvlistadeveiculos.RowHeadersWidth = 45;
            dgvlistadeveiculos.Size = new Size(636, 225);
            dgvlistadeveiculos.TabIndex = 16;
            // 
            // btnentrada
            // 
            btnentrada.Location = new Point(258, 14);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(75, 45);
            btnentrada.TabIndex = 24;
            btnentrada.Text = "confirmar";
            btnentrada.UseVisualStyleBackColor = true;
            btnentrada.Click += button1_Click;
            // 
            // btnsaida
            // 
            btnsaida.Location = new Point(258, 65);
            btnsaida.Name = "btnsaida";
            btnsaida.Size = new Size(75, 52);
            btnsaida.TabIndex = 26;
            btnsaida.Text = "Pagar";
            btnsaida.UseVisualStyleBackColor = true;
            btnsaida.Click += btnsaida_Click;
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
            // txbentrada
            // 
            txbentrada.Location = new Point(122, 16);
            txbentrada.Name = "txbentrada";
            txbentrada.Size = new Size(100, 23);
            txbentrada.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 414);
            Controls.Add(btnsaida);
            Controls.Add(btnentrada);
            Controls.Add(txbentrada);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvlistadeveiculos);
            Controls.Add(btnsair);
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