namespace CodaConcatenata
{
    public class Nodo
    {
        // valore del nodo
        string valore;
        // nodo successivo
        Nodo successivo;

        /// <summary>
        /// Costruttore della classe Nodo
        /// </summary>
        /// <param name="Valore">Valore del nuovo nodo</param>
        public Nodo(string Valore)
        {
            valore = Valore;
        }

        /// <summary>
        /// Proprietà ValoreNodo in get e set
        /// </summary>
        public string ValoreNodo { get { return valore; } set { valore = value; } }
        /// <summary>
        /// Proprietà NodoSuccessivo in get e set
        /// </summary>
        public Nodo NodoSuccessivo { get { return successivo; } set { successivo = value; } }
    }
}
