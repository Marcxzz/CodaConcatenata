namespace CodaConcatenata
{
    public partial class Form1 : Form
    {
        // creo il mio oggetto di tipo Coda
        Coda coda = new Coda();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            // la listBox viene pulita
            listBoxCoda.Items.Clear();
            // alla listBox viene aggiunta la stringa restituita dal metodo Push() di coda, passandogli il valore di textBoxValore
            listBoxCoda.Items.Add(coda.Push(textBoxValore.Text));
            // textBoxValore viene pulita
            textBoxValore.Text = "";
            // textBoxValore viene messa in focus per permettere l'inserimento di un successivo valore
            textBoxValore.Focus();
            // viene chiamato il metodo per visualizzare la coda
            VisualizzaCoda();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            // la listBox viene pulita
            listBoxCoda.Items.Clear();
            // alla listBox viene aggiunta la stringa restituita dal metodo Pop() di coda
            listBoxCoda.Items.Add(coda.Pop());
            // viene chiamato il metodo per visualizzare la coda
            VisualizzaCoda();
        }

        private void VisualizzaCoda()
        {
            // inizialmente il nodo corrente è il primo nodo della coda
            Nodo nodoCorrente = coda.PrimoNodo;
            // finché il nodo corrente non è null
            while (nodoCorrente != null)
            {
                // alla listBoxCoda viene aggiunta una stringa contenente il valore del nodo corrente
                listBoxCoda.Items.Add($"Nodo \"{nodoCorrente.ValoreNodo}\"");
                // il nodo corrente diventa il successivo di sé stesso
                nodoCorrente = nodoCorrente.NodoSuccessivo;
            }
        }
    }
}
