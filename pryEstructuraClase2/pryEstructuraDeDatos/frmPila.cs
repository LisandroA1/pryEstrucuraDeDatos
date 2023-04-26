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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        Pila PilaDePersonas = new Pila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            PilaDePersonas.Agregar(objNodo);
            PilaDePersonas.Recorrer(dgvGrilla);
            PilaDePersonas.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDePersonas.Primero != null)
            {
                lblCodigoR.Text = PilaDePersonas.Primero.Codigo.ToString();
                lblNombreR.Text = PilaDePersonas.Primero.Nombre;
                lblTramiteR.Text = PilaDePersonas.Primero.Tramite;
                PilaDePersonas.Eliminar();
                PilaDePersonas.Recorrer(dgvGrilla);
                PilaDePersonas.Recorrer(lstLista);
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
