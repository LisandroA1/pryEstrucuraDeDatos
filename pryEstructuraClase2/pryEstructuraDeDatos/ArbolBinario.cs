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

        //PROCEDIMIENTOS RECORRER INORDENASC
        public void InOrdenAsc(ListBox Lista, Nodo R) //POR LISTA
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }



        public void InOrdenAsc(ComboBox Combo, Nodo R) //POR COMBO
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(DataGridView Grilla, Nodo R) //POR GRILLA 
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);

        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        //PROCEDIMIENTOS RECORRER INORDEN DESCENDENTE

        public void InOrdenDes(ListBox Lista, Nodo R) //POR LISTA
        {
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
        }

        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }

        public void InOrdenDes(ComboBox Combo, Nodo R) //POR COMBO
        {
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
        }

        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void InOrdenDes(DataGridView Grilla, Nodo R) //POR GRILLA
        {
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
        }

        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        //PROCEDIMIENTOS RECORRER PREORDEN

        public void PreOrden(ListBox Lista, Nodo R) //POR LISTA
        {
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }
        public void RecorrerPreOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }

        public void PreOrden(ComboBox Combo, Nodo R) //POR COMBO
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
        }

        public void RecorrerPreOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void PreOrden(DataGridView Grilla, Nodo R) //POR GRILLA
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        //PROCEDIMIENTOS RECORRER POSTORDEN

        public void PostOrden(ListBox Lista, Nodo R) //POR LISTA
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }

        public void RecorrerPostOrden(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);
        }

        public void PostOrden(ComboBox Combo, Nodo R) //POR COMBO
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }

        public void RecorrerPostOrden(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }

        public void PostOrden(DataGridView Grilla, Nodo R) //POR GRILLA
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }



    }
}
