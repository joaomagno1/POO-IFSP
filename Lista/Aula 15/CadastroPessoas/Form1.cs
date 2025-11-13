namespace CadastroPessoas
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoaList = new List<Pessoa>();
        Pessoa p = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Idade = Convert.ToInt32(txtIdade.Text);
            pessoaList.Add(p);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvPessoa.AutoGenerateColumns = true;
            dgvPessoa.DataSource = null;
            dgvPessoa.DataSource = pessoaList;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            string nomeBusca = txtPesquisar.Text.ToLower();
            Pessoa pessoaEncontrada = null;

            foreach (Pessoa obj in pessoaList)
            {
                if (obj.Nome.ToLower().Contains(nomeBusca))
                {
                    pessoaEncontrada = obj;
                    break;
                }
            }

            if (pessoaEncontrada == null)
            {
                lblResultado.Text = "Pessoa não encontrada!";
            }
            else
            {
                lblResultado.Text = $"Nome: {pessoaEncontrada.Nome}\n Idade: {pessoaEncontrada.Idade}";
            }
        }
    }
}
