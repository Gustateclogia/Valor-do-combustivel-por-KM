namespace Valor_do_combustivel_por_KM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valor.Text = (float.Parse(Combustivel.Text)/float.Parse(Carro.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}