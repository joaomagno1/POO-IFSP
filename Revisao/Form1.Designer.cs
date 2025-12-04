namespace Revisao
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
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            btnCad = new Button();
            txtSal = new TextBox();
            cboCargo = new ComboBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tab2 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            tab2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tab2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(410, 221);
            tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(btnCad);
            tab1.Controls.Add(txtSal);
            tab1.Controls.Add(cboCargo);
            tab1.Controls.Add(txtNome);
            tab1.Controls.Add(label3);
            tab1.Controls.Add(label2);
            tab1.Controls.Add(label1);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(402, 193);
            tab1.TabIndex = 0;
            tab1.Text = "Cadastro";
            tab1.UseVisualStyleBackColor = true;
            tab1.Click += tabPage1_Click;
            // 
            // btnCad
            // 
            btnCad.BackColor = Color.AliceBlue;
            btnCad.Location = new Point(310, 120);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(65, 50);
            btnCad.TabIndex = 7;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // txtSal
            // 
            txtSal.Location = new Point(96, 120);
            txtSal.Name = "txtSal";
            txtSal.Size = new Size(157, 23);
            txtSal.TabIndex = 6;
            // 
            // cboCargo
            // 
            cboCargo.DrawMode = DrawMode.OwnerDrawVariable;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Programador", "Designer", "Gerente" });
            cboCargo.Location = new Point(74, 65);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(179, 24);
            cboCargo.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(186, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Salário Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 73);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Cargo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tab2
            // 
            tab2.Controls.Add(button1);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(402, 193);
            tab2.TabIndex = 1;
            tab2.Text = "Impressão";
            tab2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 164);
            button1.Name = "button1";
            button1.Size = new Size(390, 23);
            button1.TabIndex = 0;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 246);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            tab2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tab2;
        private Label label2;
        private Label label1;
        private Button btnCad;
        private TextBox txtSal;
        private ComboBox cboCargo;
        private TextBox txtNome;
        private Label label3;
        private Button button1;
    }
}
