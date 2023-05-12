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
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
        }
        ListaDoblementeEnlazada ListaDePersonas = new ListaDoblementeEnlazada();
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

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDePersonas.Recorrer(dgvGrilla);
            ListaDePersonas.Recorrer(lstLista);
            ListaDePersonas.Recorrer(lstCodigo);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDePersonas.RecorrerDes(dgvGrilla);
            ListaDePersonas.RecorrerDes(lstLista);
            ListaDePersonas.RecorrerDes(lstCodigo);
        }

        private void Validaciones()
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtTramite.Text != string.Empty)
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstCodigo.SelectedIndex != -1)
            //{
            //    cmdEliminar.Enabled = true;
            //}
            //if (lstCodigo.SelectedIndex == -1)
            //{
            //    cmdEliminar.Enabled = false;
            //}
            
                
            
        }
    }
}
