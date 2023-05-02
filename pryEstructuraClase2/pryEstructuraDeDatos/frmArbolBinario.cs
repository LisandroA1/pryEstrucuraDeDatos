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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        ArbolBinario ListaDePersonas = new ArbolBinario();
        

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

        
    }
}
