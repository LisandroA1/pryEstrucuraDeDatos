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
    public partial class frmBaseDeDatos : Form
    {
        clsBaseDeDatos objBaseDatos;
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

       

        private void cmdProyeccionSimple_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSQL = "Select Titulo FROM Libro ";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdProyeccionMulti_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSQL = "Select Titulo, Año, IdIdioma FROM Libro";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdSeleccionSimple_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSQL = "SELECT TITULO FROM Libro WHERE IdIdioma = 2";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdSeleccionMulti_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSQL = "SELECT * FROM Libro WHERE IdLibro = 2 AND IdAutor > 1";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdUnion_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSQL = " SELECT * FROM Libro WHERE IdIdioma = 2 " +
                " union " +
                " SELECT * FROM Libro where IdIdioma = 3 ";
            objBaseDatos.Listar(dgv, varSQL);
        }

        private void cmdInterseccion_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSql = " Select * From libro " +
                " where IdAutor = 5 and exists " +
                " (Select * from libro where IdIdioma = 3) ";
            objBaseDatos.Listar(dgv, varSql);
        }

        private void cmdDiferencia_Click_1(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDeDatos();
            String varSql = "Select * from libro " +
                " where IdIdioma=3 and IdLibro not in " +
                " (Select IdLibro from libro where IdPais =2 )" +
                " order by 1 asc ";
            objBaseDatos.Listar(dgv, varSql);
        }
    }
}
