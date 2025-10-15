namespace Overloads
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
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtCidade = new TextBox();
            txtQntdFuncionarios = new TextBox();
            txtValorP = new TextBox();
            txtEstado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCadastrar = new Button();
            btnPrint = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(257, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(257, 92);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(150, 23);
            txtEndereco.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(257, 138);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(150, 23);
            txtCidade.TabIndex = 2;
            // 
            // txtQntdFuncionarios
            // 
            txtQntdFuncionarios.Location = new Point(257, 288);
            txtQntdFuncionarios.Name = "txtQntdFuncionarios";
            txtQntdFuncionarios.Size = new Size(150, 23);
            txtQntdFuncionarios.TabIndex = 5;
            txtQntdFuncionarios.TextChanged += textBox4_TextChanged;
            // 
            // txtValorP
            // 
            txtValorP.Location = new Point(257, 234);
            txtValorP.Name = "txtValorP";
            txtValorP.Size = new Size(150, 23);
            txtValorP.TabIndex = 4;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(257, 186);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(150, 23);
            txtEstado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 194);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 100);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 296);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 9;
            label5.Text = "Qntd Funcionários:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 242);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor Patrimonial:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(148, 367);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(332, 367);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEstado);
            Controls.Add(txtValorP);
            Controls.Add(txtQntdFuncionarios);
            Controls.Add(txtCidade);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Empresas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private TextBox txtQntdFuncionarios;
        private TextBox txtValorP;
        private TextBox txtEstado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCadastrar;
        private Button btnPrint;
    }
}
