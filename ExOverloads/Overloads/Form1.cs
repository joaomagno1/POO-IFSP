namespace Overloads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Empresa
        {
            public string nome, endereco, cidade, estado;
            public int qntd_funcionarios;
            public double valor_patrimonial;

            public Empresa()
            {

            }
            public Empresa(string nome, string endereco, String cidade, String estado, int qntd_funcionarios, double valor_patrimonial)
            {
                this.nome = nome;
                this.endereco = endereco;
                this.cidade = cidade;
                this.estado = estado;
                this.qntd_funcionarios = qntd_funcionarios;
                this.valor_patrimonial = valor_patrimonial;
            }
            public string Print()
            {
                return "Nome da empresa: " + nome +
                    "\nEndereço: " + endereco +
                    "\nCidade: " + cidade +
                    "\nEstado: " + estado +
                    "\nQuantidade de funcionários: " + qntd_funcionarios +
                    "\nValor patrimonial da empresa: " + valor_patrimonial;
            }
        }
        
        Empresa emp1, emp2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (emp1 == null)
            {
                emp1 = new Empresa();
                emp1.nome = txtNome.Text;
                emp1.endereco = txtEndereco.Text;
                emp1.cidade = txtCidade.Text;
                emp1.estado = txtEstado.Text;
                emp1.qntd_funcionarios = Convert.ToInt32(txtQntdFuncionarios.Text);
                emp1.valor_patrimonial = Convert.ToDouble(txtValorP.Text);
            }
            else if (emp2 == null)
            {
                emp2 = new Empresa(txtNome.Text,
                                   txtEndereco.Text,
                                   txtCidade.Text,
                                   txtEstado.Text,
                                   Convert.ToInt32(txtQntdFuncionarios.Text),
                                   Convert.ToDouble(txtValorP.Text)
                                   );
            }
            else
            {
                MessageBox.Show("Empresas já cadastradas!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (emp1 == null || emp2 == null)
            {
                MessageBox.Show("É necessário cadastrar as duas empresas primeiro!");
                return; // Sai do método para não executar o resto do código
            }
            if (emp1.valor_patrimonial > emp2.valor_patrimonial)
            {
                MessageBox.Show(emp1.Print());
            }
            else if (emp2.valor_patrimonial > emp1.valor_patrimonial)
            {
                MessageBox.Show(emp2.Print());
            }
            else
            {
                MessageBox.Show(emp1.Print() + "\n\n" + emp2.Print());
            }
        }
    }
}
