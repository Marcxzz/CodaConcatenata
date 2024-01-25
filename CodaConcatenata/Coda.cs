namespace CodaConcatenata
{
    public class Coda
    {
        // primo elemento nella coda
        Nodo primo;
        // ultimo elemento nella coda
        Nodo ultimo;
        // numero di elementi attualmente presenti nella coda
        int nElementi = 0;

        /// <summary>
        /// Costruttore della classe Coda
        /// </summary>
        public Coda()
        {
            // primo e ultimo elemento saranno null
            primo = null;
            ultimo = null;
        }

        /// <summary>
        /// Metodo Push che accoda un nuovo elemento all'ultima posizione
        /// </summary>
        /// <param name="NuovoValore">Valore del nuovo nodo che si andrà a creare</param>
        public string Push(string NuovoValore)
        {
            // viene creato un nuovo nodo
            Nodo nuovoNodo = new Nodo(NuovoValore);
            // se la coda è vuota il primo elemento sarà il nodo appena creato
            if (nElementi == 0)
            {
                primo = nuovoNodo;
            }
            // sennò il nodo creato diventerà il successivo dell'ultimo nodo (attualmente)
            else
            {
                ultimo.NodoSuccessivo = nuovoNodo;
            }
            // l'ultimo nodo viene rimpiazzato dal nuovo nodo creato
            ultimo = nuovoNodo;
            // il numero di elementi viene incrementato
            nElementi++;
            // viene restituita una stringa che comunica l'esito dell'operazione
            return $"Nuovo nodo creato con valore \"{nuovoNodo.ValoreNodo}\"";
        }

        /// <summary>
        /// Metodo Pop che rimuove il primo elemento dalla coda
        /// </summary>
        public string Pop()
        {
            // se nella coda c'è più di un elemento il primo nodo sarà il successivo del primo
            if (nElementi > 1)
            {
                primo = primo.NodoSuccessivo;
                // il numero di elementi viene decrementato
                nElementi--;
                // viene restituita una stringa che comunica l'esito dell'operazione 
                return $"Primo nodo rimosso, sono rimasti {nElementi} nodi";
            }
            // sennò sia il primo che l'ultimo elemento saranno null e il numero di elementi sarà 0
            else
            {
                primo = null;
                ultimo = null;
                nElementi = 0;
                // viene restituita una stringa che comunica l'esito dell'operazione 
                return $"Ora la coda è vuota";
            }
        }

        /// <summary>
        /// Proprietà PrimoNodo in get e set
        /// </summary>
        public Nodo PrimoNodo { get { return primo; } set { primo = value; } }
        /// <summary>
        /// Proprietà UltimoNodo in get e set
        /// </summary>
        public Nodo UltimoNodo { get { return ultimo; } set { ultimo = value; } }
    }
}