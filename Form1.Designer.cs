namespace estacionamento_basico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllogin = new Label();
            label2 = new Label();
            txblogin = new TextBox();
            txbsenha = new TextBox();
            Lbltitulo = new Label();
            lblmsg = new Label();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(101, 70);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(37, 15);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 119);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "senha";
            // 
            // txblogin
            // 
            txblogin.Location = new Point(167, 65);
            txblogin.Name = "txblogin";
            txblogin.Size = new Size(100, 23);
            txblogin.TabIndex = 2;
            txblogin.TextChanged += textBox1_TextChanged;
            // 
            // txbsenha
            // 
            txbsenha.Location = new Point(167, 111);
            txbsenha.Name = "txbsenha";
            txbsenha.Size = new Size(100, 23);
            txbsenha.TabIndex = 3;
            txbsenha.TextChanged += textBox2_TextChanged;
            // 
            // Lbltitulo
            // 
            Lbltitulo.AutoSize = true;
            Lbltitulo.Location = new Point(115, 21);
            Lbltitulo.Name = "Lbltitulo";
            Lbltitulo.Size = new Size(152, 15);
            Lbltitulo.TabIndex = 4;
            Lbltitulo.Text = "Sistema de estacionamento";
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Location = new Point(167, 161);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(0, 15);
            lblmsg.TabIndex = 6;
            lblmsg.TextAlign = ContentAlignment.MiddleCenter;
            lblmsg.Click += lblmsg_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 207);
            Controls.Add(lblmsg);
            Controls.Add(Lbltitulo);
            Controls.Add(txbsenha);
            Controls.Add(txblogin);
            Controls.Add(label2);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label label2;
        private TextBox txblogin;
        private TextBox txbsenha;
        private Label Lbltitulo;
        private Label lblmsg;
    }
}
