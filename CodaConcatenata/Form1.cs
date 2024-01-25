namespace CodaConcatenata
{
    public partial class Form1 : Form
    {
        Coda coda = new Coda();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            // la listBox viene pulita
            listBox1.Items.Clear();
            // alla listBox viene aggiunta la stringa restituita dal metodo Push() di coda, passandogli il valore di textBoxValore
            listBox1.Items.Add(coda.Push(textBoxValore.Text));
            // textBoxValore viene pulita
            textBoxValore.Text = "";
            // textBoxValore viene messa in focus, pronta per un nuovo inserimento
            textBoxValore.Focus();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            // la listBox viene pulita
            listBox1.Items.Clear();
            // alla listBox viene aggiunta la stringa restituita dal metodo Pop() di coda
            listBox1.Items.Add(coda.Pop());
        }
    }
}
