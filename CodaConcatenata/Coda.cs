﻿namespace CodaConcatenata
{
    public class Coda
    {
        Nodo primo;
        Nodo ultimo;
        int nElementi = 0;

        public Coda()
        {
            primo = null;
            ultimo = null;
        }

        public void Push(string NuovoValore)
        {
            Nodo nuovoNodo = new Nodo(NuovoValore);
            if (nElementi == 0)
            {
                primo = nuovoNodo;
            }
            else
            {
                ultimo.NodoSuccessivo = nuovoNodo;
            }
            ultimo = nuovoNodo;
            nElementi++;
        }

        public void Pop()
        {
            if (nElementi > 1)
            {
                primo = primo.NodoSuccessivo;
                nElementi--;
            }
            else
            {
                primo = null;
                ultimo = null;
                nElementi = 0;
            }
        }

        public Nodo PrimoNodo { get { return primo; } set { primo = value; } }
        public Nodo UltimoNodo { get { return ultimo; } set { ultimo = value; } }
    }
}