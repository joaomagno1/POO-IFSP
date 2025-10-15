namespace ExerciciosPOO0309
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtHrsT = new TextBox();
            txtDept = new TextBox();
            txtValorH = new TextBox();
            btnMostraDados = new Button();
            btnCalcSal = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 152);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Horas Trabalhadas: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 93);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Departamento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 202);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor por hora: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(103, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 23);
            txtNome.TabIndex = 4;
            // 
            // txtHrsT
            // 
            txtHrsT.Location = new Point(155, 149);
            txtHrsT.Name = "txtHrsT";
            txtHrsT.Size = new Size(173, 23);
            txtHrsT.TabIndex = 5;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(128, 90);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(200, 23);
            txtDept.TabIndex = 6;
            // 
            // txtValorH
            // 
            txtValorH.Location = new Point(126, 199);
            txtValorH.Name = "txtValorH";
            txtValorH.Size = new Size(200, 23);
            txtValorH.TabIndex = 7;
            // 
            // btnMostraDados
            // 
            btnMostraDados.Location = new Point(33, 307);
            btnMostraDados.Name = "btnMostraDados";
            btnMostraDados.Size = new Size(136, 23);
            btnMostraDados.TabIndex = 8;
            btnMostraDados.Text = "Mostrar Dados";
            btnMostraDados.UseVisualStyleBackColor = true;
            btnMostraDados.Click += btnMostraDados_Click;
            // 
            // btnCalcSal
            // 
            btnCalcSal.Location = new Point(195, 307);
            btnCalcSal.Name = "btnCalcSal";
            btnCalcSal.Size = new Size(133, 23);
            btnCalcSal.TabIndex = 9;
            btnCalcSal.Text = "Calcular Salário";
            btnCalcSal.UseVisualStyleBackColor = true;
            btnCalcSal.Click += btnCalcSal_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(33, 255);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(293, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 382);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCalcSal);
            Controls.Add(btnMostraDados);
            Controls.Add(txtValorH);
            Controls.Add(txtDept);
            Controls.Add(txtHrsT);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ex 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtHrsT;
        private TextBox txtDept;
        private TextBox txtValorH;
        private Button btnMostraDados;
        private Button btnCalcSal;
        private Button btnCadastrar;
    }
}
