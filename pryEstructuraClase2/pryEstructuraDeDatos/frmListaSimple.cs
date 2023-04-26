using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        ListaSimple ListaDePersonas = new ListaSimple();
        Int32 Codigo;
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            ListaDePersonas.Agregar(objNodo);
            ListaDePersonas.Recorrer(dgvGrilla);
            ListaDePersonas.Recorrer(lstLista);
            ListaDePersonas.Recorrer(lstCodigo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDePersonas.Primero != null)
            {

                Codigo = Convert.ToInt32(lstCodigo.Text);
                ListaDePersonas.Eliminar(Codigo);
                ListaDePersonas.Recorrer(dgvGrilla);
                ListaDePersonas.Recorrer(lstLista);
                ListaDePersonas.Recorrer(lstCodigo);
            }
            
        }
    }
}
