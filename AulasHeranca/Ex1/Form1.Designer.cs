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
            txtDesc = new TextBox();
            txtCap = new TextBox();
            txtKm = new TextBox();
            txtHoras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCarro = new Button();
            btnAviao = new Button();
            SuspendLayout();
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(52, 60);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(170, 29);
            txtDesc.TabIndex = 0;
            // 
            // txtCap
            // 
            txtCap.Location = new Point(52, 177);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(170, 29);
            txtCap.TabIndex = 1;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(52, 281);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(170, 29);
            txtKm.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(52, 383);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(170, 29);
            txtHoras.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 4;
            label1.Text = "Descrição: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 5;
            label2.Text = "Capacidade: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 243);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 6;
            label3.Text = "Quilometragem: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 7;
            label4.Text = "Horas: ";
            // 
            // btnCarro
            // 
            btnCarro.Location = new Point(343, 174);
            btnCarro.Name = "btnCarro";
            btnCarro.Size = new Size(93, 35);
            btnCarro.TabIndex = 8;
            btnCarro.Text = "Carro";
            btnCarro.UseVisualStyleBackColor = true;
            btnCarro.Click += btnCarro_Click;
            // 
            // btnAviao
            // 
            btnAviao.Location = new Point(343, 278);
            btnAviao.Name = "btnAviao";
            btnAviao.Size = new Size(93, 35);
            btnAviao.TabIndex = 9;
            btnAviao.Text = "Avião";
            btnAviao.UseVisualStyleBackColor = true;
            btnAviao.Click += btnAviao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 660);
            Controls.Add(btnAviao);
            Controls.Add(btnCarro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoras);
            Controls.Add(txtKm);
            Controls.Add(txtCap);
            Controls.Add(txtDesc);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDesc;
        private TextBox txtCap;
        private TextBox txtKm;
        private TextBox txtHoras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCarro;
        private Button btnAviao;
    }
}
