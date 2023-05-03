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
        ArbolBinario ArbolBinario = new ArbolBinario();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            ArbolBinario.Agregar(objNodo);

            ArbolBinario.Recorrer(dgvGrilla);
            ArbolBinario.Recorrer(lstCodigo);
            ArbolBinario.Recorrer(lstB);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";



        }
    }
}
