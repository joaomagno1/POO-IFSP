using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;

namespace Aula_0309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Pessoa
        {
            public string nome;
            public int idade;

        }

        Pessoa p1 = null;
        Pessoa p2 = null;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (p1 == null)
            {
                p1 = new Pessoa();
                p1.nome = txtNome.Text;
                p1.idade = Convert.ToInt32(txtIdade.Text);
                btnImprimir.Enabled = true;
            }
            else if (p2 == null)
            {
                p2 = new Pessoa();
                p2.nome = txtNome.Text;
                p2.idade = Convert.ToInt32(txtIdade.Text);
            }
            else
            {
                MessageBox.Show("Pessoas já cadastradas!");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (p2 != null)
            {
                MessageBox.Show("Nome: " + p1.nome + " Idade: " + p1.idade + "\nNome: " + p2.nome + " Idade: " + p2.idade);
            }
            else
            {
                MessageBox.Show("Nome: " + p1.nome + " Idade: " + p1.idade);
            }
        }
    }
}
