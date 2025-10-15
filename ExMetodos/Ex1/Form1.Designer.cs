namespace Ex1
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
            btnCalc = new Button();
            txtLado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(24, 118);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += button1_Click;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(24, 76);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(195, 23);
            txtLado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 2;
            label1.Text = "Insira o valor de lados do quadrado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 199);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 194);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLado);
            Controls.Add(btnCalc);
            Name = "Form1";
            Text = "Calcular Quadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private TextBox txtLado;
        private Label label1;
        private Label label2;
    }
}
