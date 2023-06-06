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
    public partial class frmRepasoDeOperacionesDeBaseDeDatos : Form
    {
        public frmRepasoDeOperacionesDeBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            String varSql = "";
            switch (lstOperacion.SelectedIndex)
            {
                case 0: lblEnunciado.Text = lstOperacion.Text + " " + "Paises que no tienen libros";
                    varSql = "select * from pais where " + "idpais not in " + "(select idpais from libro)";

                    break;

                case 1: lblEnunciado.Text = lstOperacion.Text + " " + "Idiomas que si tienen libros";
                    varSql = "Select * from idioma where " + "ididioma in " + "(select ididioma from libro)";

                    break;

                case 2: lblEnunciado.Text = lstOperacion.Text + " " + "Todos los Libros con sus respectivos idiomas";
                    varSql = "select titulo, nombre " + "from libro inner join idioma " + "on Libro.ididioma = idioma.ididioma ";

                    break;
                
                case 3: lblEnunciado.Text = lstOperacion.Text + " " + "Todos los autores de los libros";
                    varSql = "select nombre from autor";

                    break;
                
                case 4: lblEnunciado.Text = lstOperacion.Text + " " + "Proyecta Titulo, cantidad y pais";
                    varSql = "Select titulo, cantidad, idpais from libro ";

                    break;

                case 5: lblEnunciado.Text = lstOperacion.Text + " " + "Todos los libros que el precio sea mayor a 423 y la cantidad sea mayor a 8";
                    varSql = "select * from libro where precio > 423 and cantidad > 8 ";

                    break;

                case 6: lblEnunciado.Text = lstOperacion.Text + " " + "Todos los libros que el idioma sea Ingles o Español";
                    varSql = "select titulo, ididioma from libro where ididioma = 1 or ididioma = 6";

                    break;

                case 7: lblEnunciado.Text = lstOperacion.Text + " " + "Muestra los libros que tengan una cantidad menor a 5 y el idioma sea portugues";
                    varSql = "select titulo, cantidad, ididioma " + "from (select * from libro where cantidad < 5) as x " + "where ididioma = 14 "  ;

                    break;

                case 8: lblEnunciado.Text = lstOperacion.Text + " " + "Muestra el titulo, año y cantidad de libros de la autora virginia";
                    varSql = "select titulo, año, cantidad from libro where idautor = 3 ";

                    break;

                case 9: lblEnunciado.Text = lstOperacion.Text + " " + "Muestra todos los libros que esten en idioma Hebreo o Sueco ";
                    varSql = "select * from libro where ididioma = 18 " + "union " + "select * from libro where ididioma = 21 ";

                    break;

               
            }
            objBaseDeDatos.Listar(dgv, varSql);
        }
    }
}
