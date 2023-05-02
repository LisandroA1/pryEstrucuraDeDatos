using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class ArbolBinario
    {
        private Nodo Inicio;

        public Nodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(Nodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nuevo;

            }
            else
            {
                Nodo NodoPadre = Raiz;
                Nodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }

            }
        }

        //recorro por lista
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }

        public void InOrdenAsc(ListBox lst, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);

        }
        //Recorro por combo
        
        
        
        
        public void InOrdenAsc(ComboBox Combo, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Inicio;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        //Recorro por grilla
       

        public void InOrdenAsc(DataGridView dgvArbolBinario, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgvArbolBinario, R.Izquierdo);
            dgvArbolBinario.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(dgvArbolBinario, R.Derecho);

        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
    }
}   
        
       
       



