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
            coda.Push(textBoxValore.Text);
            textBoxValore.Text = "";
            textBoxValore.Focus();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            coda.Pop();
        }
    }
}
