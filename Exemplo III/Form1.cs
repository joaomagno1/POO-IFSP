namespace Exemplo_III
{
    public partial class Projeto3 : Form
    {
        public Projeto3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtCopia.Text = txtOriginal.Text;
        }

        private void textBox1_Click (object sender, EventArgs e)
        {
            txtOriginal.Clear();
        }
    }
}
