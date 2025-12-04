namespace Revisao
{
    public partial class Form1 : Form
    {
        List<Funcionario> lista = new List<Funcionario>();
        Programador prog = null;
        Gerente ger = null;
        Designer des = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (cboCargo.SelectedIndex == 0)
            {
                prog = new Programador();
                prog.Nome = txtNome.Text;
                prog.Cargo = cboCargo.Text;
                prog.SalarioBase = Convert.ToDouble(txtSal.Text);
                lista.Add(prog);
            }
            else if (cboCargo.SelectedIndex == 1)
            {
                des = new Designer();
                des.Nome = txtNome.Text;
                des.Cargo = cboCargo.Text;
                des.SalarioBase = Convert.ToDouble(txtSal.Text);
                lista.Add(des);
            }
            else
            {
                ger = new Gerente();
                ger.Nome = txtNome.Text;
                ger.Cargo = cboCargo.Text;
                ger.SalarioBase = Convert.ToDouble(txtSal.Text);
                lista.Add(ger);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dados = "";
            foreach (Funcionario f in lista)
            {
                dados = $"\n Nome: {f.Nome} " +
                    $"\n Cargo: {f.Cargo}" +
                    $"\n Salário: {f.CalcularSalario()}";

                MessageBox.Show(dados);
            }
        }
    }
}
