namespace Exemplo_VI
{
    public partial class Form1 : Form
    {
        float dobro, triplo, resultado, entrada;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (rdbDobrar.Checked == true)
            {
                dobro = entrada * 2;
                txtResultado.Text = dobro.ToString();
            } else
            {
                triplo = entrada * 3;
                txtResultado.Text = triplo.ToString();
            }
        }

        private void rdbTriplicar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDigite_TextChanged(object sender, EventArgs e)
        {
           entrada = float.Parse(txtDigite.Text);
        }
    }
}
