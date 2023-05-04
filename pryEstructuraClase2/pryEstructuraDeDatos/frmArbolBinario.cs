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

            if (optInOrden.Checked)
            {
                if (optAscendente.Checked)
                {
                    ArbolBinario.Recorrer(dgvGrilla);
                    ArbolBinario.Recorrer(lstCodigo);
                    ArbolBinario.Recorrer(lstB);
                    ArbolBinario.Recorrer(tvArbolBinario);
                }
                else
                {
                    ArbolBinario.RecorrerDes(dgvGrilla);
                    ArbolBinario.RecorrerDes(lstCodigo);
                    ArbolBinario.RecorrerDes(lstB);
                    ArbolBinario.RecorrerDes(tvArbolBinario);
                }
            }
            if (optPreOrden.Checked)
            {
                ArbolBinario.RecorrerPreOrden(dgvGrilla);
                ArbolBinario.RecorrerPreOrden(lstCodigo);
                ArbolBinario.RecorrerPreOrden(lstB);
                ArbolBinario.RecorrerPreOrden(tvArbolBinario);
            }
            if (optPostOrden.Checked)
            {
                ArbolBinario.RecorrerPostOrden(dgvGrilla);
                ArbolBinario.RecorrerPostOrden(lstCodigo);
                ArbolBinario.RecorrerPostOrden(lstB);
                ArbolBinario.RecorrerPostOrden(tvArbolBinario);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
