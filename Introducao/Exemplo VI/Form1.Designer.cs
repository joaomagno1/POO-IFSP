namespace Exemplo_VI
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
            groupBox1 = new GroupBox();
            rdbTriplicar = new RadioButton();
            rdbDobrar = new RadioButton();
            txtDigite = new TextBox();
            txtResultado = new TextBox();
            lblEntrada = new Label();
            lblResultado = new Label();
            btnAplicar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbTriplicar);
            groupBox1.Controls.Add(rdbDobrar);
            groupBox1.Location = new Point(31, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdbTriplicar
            // 
            rdbTriplicar.AutoSize = true;
            rdbTriplicar.Location = new Point(27, 47);
            rdbTriplicar.Name = "rdbTriplicar";
            rdbTriplicar.Size = new Size(66, 19);
            rdbTriplicar.TabIndex = 1;
            rdbTriplicar.TabStop = true;
            rdbTriplicar.Text = "Triplicar";
            rdbTriplicar.UseVisualStyleBackColor = true;
            rdbTriplicar.CheckedChanged += rdbTriplicar_CheckedChanged;
            // 
            // rdbDobrar
            // 
            rdbDobrar.AutoSize = true;
            rdbDobrar.Location = new Point(27, 22);
            rdbDobrar.Name = "rdbDobrar";
            rdbDobrar.Size = new Size(61, 19);
            rdbDobrar.TabIndex = 0;
            rdbDobrar.TabStop = true;
            rdbDobrar.Text = "Dobrar";
            rdbDobrar.UseVisualStyleBackColor = true;
            rdbDobrar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtDigite
            // 
            txtDigite.Location = new Point(58, 189);
            txtDigite.Name = "txtDigite";
            txtDigite.Size = new Size(173, 23);
            txtDigite.TabIndex = 1;
            txtDigite.TextChanged += txtDigite_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(58, 280);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(119, 23);
            txtResultado.TabIndex = 2;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(57, 167);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(107, 15);
            lblEntrada.TabIndex = 3;
            lblEntrada.Text = "Digite um número:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(58, 262);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += label2_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(265, 179);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(148, 41);
            btnAplicar.TabIndex = 5;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 373);
            Controls.Add(btnAplicar);
            Controls.Add(lblResultado);
            Controls.Add(lblEntrada);
            Controls.Add(txtResultado);
            Controls.Add(txtDigite);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Exercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbTriplicar;
        private RadioButton rdbDobrar;
        private TextBox txtDigite;
        private TextBox txtResultado;
        private Label lblEntrada;
        private Label lblResultado;
        private Button btnAplicar;
    }
}
