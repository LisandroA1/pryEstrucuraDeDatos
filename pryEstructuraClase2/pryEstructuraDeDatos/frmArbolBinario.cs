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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked)
            {
                ArbolBinario.Recorrer(lstB);
                ArbolBinario.Recorrer(dgvGrilla);
                ArbolBinario.Recorrer(lstCodigo);
                

            }
            else
            {
                ArbolBinario.RecorrerDes(lstB);
                ArbolBinario.RecorrerDes(dgvGrilla);
                ArbolBinario.RecorrerDes(lstCodigo);
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPreOrden(lstCodigo);
            ArbolBinario.RecorrerPreOrden(lstB);
            ArbolBinario.RecorrerPreOrden(dgvGrilla);
            
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ArbolBinario.RecorrerPostOrden(lstCodigo);
            ArbolBinario.RecorrerPostOrden(lstB);
            ArbolBinario.RecorrerPostOrden(dgvGrilla);
        }
    }
}
