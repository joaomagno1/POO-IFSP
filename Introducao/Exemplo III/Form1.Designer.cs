namespace Exemplo_III
{
    partial class Projeto3
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
            txtOriginal = new TextBox();
            txtCopia = new TextBox();
            lblOriginal = new Label();
            lblCopia = new Label();
            SuspendLayout();
            // 
            // txtOriginal
            // 
            txtOriginal.Location = new Point(288, 64);
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.ScrollBars = ScrollBars.Vertical;
            txtOriginal.Size = new Size(226, 82);
            txtOriginal.TabIndex = 0;
            txtOriginal.TextChanged += textBox1_TextChanged;
            txtOriginal.DoubleClick += textBox1_Click;
            // 
            // txtCopia
            // 
            txtCopia.Enabled = false;
            txtCopia.Location = new Point(288, 286);
            txtCopia.Multiline = true;
            txtCopia.Name = "txtCopia";
            txtCopia.ScrollBars = ScrollBars.Vertical;
            txtCopia.Size = new Size(226, 82);
            txtCopia.TabIndex = 1;
            // 
            // lblOriginal
            // 
            lblOriginal.AutoSize = true;
            lblOriginal.Location = new Point(377, 46);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(49, 15);
            lblOriginal.TabIndex = 2;
            lblOriginal.Text = "Original";
            lblOriginal.Click += label1_Click;
            // 
            // lblCopia
            // 
            lblCopia.AutoSize = true;
            lblCopia.Location = new Point(380, 268);
            lblCopia.Name = "lblCopia";
            lblCopia.Size = new Size(38, 15);
            lblCopia.TabIndex = 3;
            lblCopia.Text = "Cópia";
            // 
            // Projeto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCopia);
            Controls.Add(lblOriginal);
            Controls.Add(txtCopia);
            Controls.Add(txtOriginal);
            Name = "Projeto3";
            Text = "Projeto III";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOriginal;
        private TextBox txtCopia;
        private Label lblOriginal;
        private Label lblCopia;
    }
}
