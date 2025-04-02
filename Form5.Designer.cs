namespace estacionamento_basico
{
    partial class Form5
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
            btnsaida = new Button();
            btncobranca = new Button();
            btnentrada = new Button();
            btnadmin = new Button();
            SuspendLayout();
            // 
            // btnsair
            // 
            btnsair.Location = new Point(370, 161);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(151, 64);
            btnsair.TabIndex = 21;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            // 
            // btnsaida
            // 
            btnsaida.Location = new Point(44, 189);
            btnsaida.Name = "btnsaida";
            btnsaida.Size = new Size(151, 64);
            btnsaida.TabIndex = 18;
            btnsaida.Text = "Testar tabela";
            btnsaida.UseVisualStyleBackColor = true;
            // 
            // btncobranca
            // 
            btncobranca.Location = new Point(44, 119);
            btncobranca.Name = "btncobranca";
            btncobranca.Size = new Size(151, 64);
            btncobranca.TabIndex = 17;
            btncobranca.Text = "definir tolerancia";
            btncobranca.UseVisualStyleBackColor = true;
            // 
            // btnentrada
            // 
            btnentrada.Location = new Point(44, 49);
            btnentrada.Name = "btnentrada";
            btnentrada.Size = new Size(151, 64);
            btnentrada.TabIndex = 16;
            btnentrada.Text = "Gerenciar tabelas";
            btnentrada.UseVisualStyleBackColor = true;
            // 
            // btnadmin
            // 
            btnadmin.Location = new Point(370, 77);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(151, 64);
            btnadmin.TabIndex = 20;
            btnadmin.Text = "Voltar";
            btnadmin.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 321);
            Controls.Add(btnsair);
            Controls.Add(btnadmin);
            Controls.Add(btnsaida);
            Controls.Add(btncobranca);
            Controls.Add(btnentrada);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnsair;
        private Button btnsaida;
        private Button btncobranca;
        private Button btnentrada;
        private Button btnadmin;
    }
}