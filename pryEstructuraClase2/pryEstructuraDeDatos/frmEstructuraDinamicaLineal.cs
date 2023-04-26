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
    public partial class frmEstructuraDinamicaLineal : Form
    {
        public frmEstructuraDinamicaLineal()
        {
            InitializeComponent();
        }
        clsCola FilaDePersonas = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvGrilla);
            FilaDePersonas.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigoR.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombreR.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteR.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstLista);
            }
            else
            {
                lblCodigoR.Text = "";
                lblNombreR.Text = "";
                lblTramiteR.Text = "";
            }
        }
    }
}
