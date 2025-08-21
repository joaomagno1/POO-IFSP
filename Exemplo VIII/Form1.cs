namespace Exemplo_VIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void rdbEsconder_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
