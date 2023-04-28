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
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador newobj = new frmDatosProgramador();
            newobj.ShowDialog();
        }

        private void tsmLineales_Click(object sender, EventArgs e)
        {
            
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila objPila = new frmPila();
            objPila.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola newObj = new frmCola();
            newObj.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple newobj = new frmListaSimple();
            newobj.ShowDialog();
        }

        private void listaDoblementeEnlazaadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada newObj = new frmListaDoblementeEnlazada();
            newObj.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario newobj = new frmArbolBinario();
            newobj.ShowDialog();
        }
    }
}
