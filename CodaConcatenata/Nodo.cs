namespace CodaConcatenata
{
    public class Nodo
    {
        string valore;
        Nodo successivo;

        public Nodo(string Valore)
        {
            valore = Valore;
        }

        public string ValoreNodo { get { return valore; } set { valore = value; } }
        public Nodo NodoSuccessivo { get { return successivo; } set { successivo = value; } }
    }
}
