namespace Aula_II
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
            btnMensagem = new Button();
            btnCopiar = new Button();
            btnSair = new Button();
            lblEntrada = new Label();
            lblSaida = new Label();
            txtEntrada = new TextBox();
            txtSaída = new TextBox();
            SuspendLayout();
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(461, 46);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(88, 23);
            btnMensagem.TabIndex = 0;
            btnMensagem.Text = "Mensagem";
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(461, 101);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(88, 23);
            btnCopiar.TabIndex = 1;
            btnCopiar.Text = "CopiarTexto";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnTexto_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(461, 155);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(88, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(100, 46);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(50, 15);
            lblEntrada.TabIndex = 3;
            lblEntrada.Text = "Entrada:";
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(100, 101);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(38, 15);
            lblSaida.TabIndex = 4;
            lblSaida.Text = "Saída:";
            lblSaida.Click += lblSaida_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(153, 43);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(161, 23);
            txtEntrada.TabIndex = 5;
            // 
            // txtSaída
            // 
            txtSaída.Location = new Point(153, 98);
            txtSaída.Name = "txtSaída";
            txtSaída.Size = new Size(161, 23);
            txtSaída.TabIndex = 6;
            txtSaída.TextChanged += txtSaída_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSaída);
            Controls.Add(txtEntrada);
            Controls.Add(lblSaida);
            Controls.Add(lblEntrada);
            Controls.Add(btnSair);
            Controls.Add(btnCopiar);
            Controls.Add(btnMensagem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMensagem;
        private Button btnCopiar;
        private Button btnSair;
        private Label lblEntrada;
        private Label lblSaida;
        private TextBox txtEntrada;
        private TextBox txtSaída;
    }
}
