namespace Exemplo_IV
{
    partial class Projeto4
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
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblResultado = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            btnSomar = new Button();
            btnLimpar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(153, 81);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(63, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(153, 143);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(63, 15);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Número 2:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(153, 255);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(232, 78);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(170, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(232, 140);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(170, 23);
            txtNumero2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(232, 252);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(249, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(588, 56);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(458, 328);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(588, 85);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 8;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(588, 114);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 9;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(588, 143);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 10;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(194, 328);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Projeto4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnLimpar);
            Controls.Add(btnSomar);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "Projeto4";
            Text = "Somar Dois Números Inteiros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultado;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private Button btnSomar;
        private Button btnLimpar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnSair;
    }
}
