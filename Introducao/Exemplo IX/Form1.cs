namespace Exemplo_IX
{
    public partial class Form1 : Form
    {
        float num1, num2, num3, num4, media, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        float CalcMedia(float num1, float num2, float num3, float num4, float media)
        {
            media = (num1 + num2 + num3 + num4) / 4;

            return media;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            num3 = float.Parse(txtNum3.Text);
            num4 = float.Parse(txtNum4.Text);

            resultado = CalcMedia(num1, num2, num3, num4, media);

            txtResultado.Text = resultado.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
