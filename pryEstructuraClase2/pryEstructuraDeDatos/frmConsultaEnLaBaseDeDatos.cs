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
    public partial class frmConsultaEnLaBaseDeDatos : Form
    {
        public frmConsultaEnLaBaseDeDatos()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBase = new clsBaseDeDatos();
            String varSql = txtSql.Text;
            objBase.Listar(dgv, varSql);
        }
    }
}
