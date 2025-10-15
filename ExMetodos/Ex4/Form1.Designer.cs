namespace Ex4
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
            btnSoma = new Button();
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnSubtrair = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(23, 200);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(100, 23);
            btnSoma.TabIndex = 0;
            btnSoma.Text = "Somar";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(23, 23);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(102, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Insira o número 1:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(23, 52);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(102, 23);
            txtNum1.TabIndex = 2;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(23, 96);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(102, 15);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Insira o número 2:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(23, 133);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(102, 23);
            txtNum2.TabIndex = 4;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(25, 364);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(100, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(25, 261);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(100, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(23, 312);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(100, 23);
            btnSubtrair.TabIndex = 8;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.Window;
            txtResult.Location = new Point(174, 39);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ShortcutsEnabled = false;
            txtResult.Size = new Size(164, 348);
            txtResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 415);
            Controls.Add(txtResult);
            Controls.Add(btnSubtrair);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Controls.Add(btnSoma);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Label lblNum1;
        private TextBox txtNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnSubtrair;
        private TextBox txtResult;
    }
}
