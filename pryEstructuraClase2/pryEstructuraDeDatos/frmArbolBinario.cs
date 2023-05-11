using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public bool asc;
        public string recorrer;
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            StreamWriter Sw = new StreamWriter("./Hola.csv", false);

            ArbolBinario.Agregar(objNodo);

            if (optInOrden.Checked)
            {
                if (optAscendente.Checked)
                {
                    ArbolBinario.Recorrer(dgvGrilla);
                    ArbolBinario.Recorrer(lstCodigo);
                    ArbolBinario.Recorrer(lstB);
                    ArbolBinario.Recorrer(tvArbolBinario);
                    ArbolBinario.RecorrerSW(Sw);


                }
                else
                {
                    ArbolBinario.RecorrerDes(dgvGrilla);
                    ArbolBinario.RecorrerDes(lstCodigo);
                    ArbolBinario.RecorrerDes(lstB);
                    ArbolBinario.RecorrerDes(tvArbolBinario);
                    ArbolBinario.RecorrerDesSW(Sw);

                }
            }
            if (optPreOrden.Checked)
            {
                ArbolBinario.RecorrerPreOrden(dgvGrilla);
                ArbolBinario.RecorrerPreOrden(lstCodigo);
                ArbolBinario.RecorrerPreOrden(lstB);
                ArbolBinario.RecorrerPreOrden(tvArbolBinario);
                ArbolBinario.RecorrerPreOrdenSW(Sw);
            }
            if (optPostOrden.Checked)
            {
                ArbolBinario.RecorrerPostOrden(dgvGrilla);
                ArbolBinario.RecorrerPostOrden(lstCodigo);
                ArbolBinario.RecorrerPostOrden(lstB);
                ArbolBinario.RecorrerPostOrden(tvArbolBinario);
                ArbolBinario.RecorrerPostOrdenSW(Sw);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            Sw.Close();
            Sw.Dispose();


        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if ((ArbolBinario.Raiz != null) && (lstCodigo.SelectedIndex != -1))
            {
                ArbolBinario.Eliminar(Convert.ToInt32(lstCodigo.SelectedItem));
                SeleccionRecorrido();
                RecorrerElementos();


                if (ArbolBinario.Raiz == null)
                {
                    dgvGrilla.Rows.Clear();
                    lstCodigo.Items.Clear();
                    lstB.Items.Clear();
                    tvArbolBinario.Nodes.Clear();
                    File.Delete("./Hola.csv");
                }

            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigo.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked == true)
            {
                mrcTipoDeOrden.Enabled = true;
                optAscendente.Enabled = true;
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked == true)
            {
                optAscendente.Checked = false;
                optDescendente.Checked = false;
                mrcListarDatos.Enabled = false;

            }

        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked == true)
            {
                optAscendente.Checked = false;
                optDescendente.Checked = false;
                mrcListarDatos.Enabled = false;
            }
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

        

        public void RecorrerElementos()
        {
            if (ArbolBinario.Raiz != null)
            {
                StreamWriter sw = new StreamWriter("./hola.csv", false);
                ArbolBinario.Recorrer(sw, asc, recorrer);
                sw.Close();
                sw.Dispose();
                ArbolBinario.Recorrer(lstB, asc, recorrer);
                ArbolBinario.Recorrer(lstCodigo, asc, recorrer);
                ArbolBinario.Recorrer(dgvGrilla, recorrer, asc);
                ArbolBinario.Recorrer(tvArbolBinario);
                tvArbolBinario.ExpandAll();


            }
        }

        public void EstadoInOrden()
        {
            if (optInOrden.Checked)
            {
                optAscendente.Enabled = true;
                optDescendente.Enabled = true;
            }
            else
            {
                optAscendente.Enabled = false;
                optDescendente.Enabled = false;
            }
        }
        public void SeleccionRecorrido()
        {
            if (optInOrden.Checked)
            {
                recorrer = "InOrden";
                if (optAscendente.Checked)
                {
                    asc = true;
                }
                else if (optDescendente.Checked)
                {
                    asc = false;
                }
            }
            else if (optPostOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (optPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            optInOrden.Checked = true;
            optAscendente.Checked = true;
            cmdAgregar.Enabled = false;
            cmdEliminar.Enabled = false;
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCodigo.SelectedText == null)
            {
                cmdEliminar.Enabled = false;
            }
            else
            {
                cmdEliminar.Enabled = true;
            }
        }
    }
}
