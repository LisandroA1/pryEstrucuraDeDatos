namespace pryEstructuraDeDatos
{
    partial class frmEstructuraDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraDeDatos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasEnlazadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDoblementeEnlazaadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNoLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEnLaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.BackgroundImage = global::pryEstructuraDeDatos.Properties.Resources.Fondo_Formulario;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSistema,
            this.tsmLineales,
            this.tsmNoLineales,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSistema
            // 
            this.tsmSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosProgramadorToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tsmSistema.ForeColor = System.Drawing.Color.White;
            this.tsmSistema.Name = "tsmSistema";
            this.tsmSistema.Size = new System.Drawing.Size(60, 20);
            this.tsmSistema.Text = "Sistema";
            // 
            // datosProgramadorToolStripMenuItem
            // 
            this.datosProgramadorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.datosProgramadorToolStripMenuItem.Name = "datosProgramadorToolStripMenuItem";
            this.datosProgramadorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.datosProgramadorToolStripMenuItem.Text = "Datos Programador";
            this.datosProgramadorToolStripMenuItem.Click += new System.EventHandler(this.datosProgramadorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tsmLineales
            // 
            this.tsmLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listasEnlazadasToolStripMenuItem});
            this.tsmLineales.ForeColor = System.Drawing.Color.White;
            this.tsmLineales.Name = "tsmLineales";
            this.tsmLineales.Size = new System.Drawing.Size(61, 20);
            this.tsmLineales.Text = "Lineales";
            this.tsmLineales.Click += new System.EventHandler(this.tsmLineales_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // listasEnlazadasToolStripMenuItem
            // 
            this.listasEnlazadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSimpleToolStripMenuItem,
            this.listaDoblementeEnlazaadaToolStripMenuItem});
            this.listasEnlazadasToolStripMenuItem.Name = "listasEnlazadasToolStripMenuItem";
            this.listasEnlazadasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listasEnlazadasToolStripMenuItem.Text = "Listas Enlazadas";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple";
            this.listaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaSimpleToolStripMenuItem_Click);
            // 
            // listaDoblementeEnlazaadaToolStripMenuItem
            // 
            this.listaDoblementeEnlazaadaToolStripMenuItem.Name = "listaDoblementeEnlazaadaToolStripMenuItem";
            this.listaDoblementeEnlazaadaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listaDoblementeEnlazaadaToolStripMenuItem.Text = "Lista Doblemente Enlazaada";
            this.listaDoblementeEnlazaadaToolStripMenuItem.Click += new System.EventHandler(this.listaDoblementeEnlazaadaToolStripMenuItem_Click);
            // 
            // tsmNoLineales
            // 
            this.tsmNoLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem,
            this.grafoToolStripMenuItem});
            this.tsmNoLineales.ForeColor = System.Drawing.Color.White;
            this.tsmNoLineales.Name = "tsmNoLineales";
            this.tsmNoLineales.Size = new System.Drawing.Size(80, 20);
            this.tsmNoLineales.Text = "No Lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol Binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.grafoToolStripMenuItem.Text = "Grafo";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem,
            this.consultaEnLaBaseDeDatosToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // operacionesConTablasDeLaBaseDeDatosToolStripMenuItem
            // 
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem.Name = "operacionesConTablasDeLaBaseDeDatosToolStripMenuItem";
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem.Text = "Operaciones con tablas de la base de datos...";
            this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.operacionesConTablasDeLaBaseDeDatosToolStripMenuItem_Click);
            // 
            // consultaEnLaBaseDeDatosToolStripMenuItem
            // 
            this.consultaEnLaBaseDeDatosToolStripMenuItem.Name = "consultaEnLaBaseDeDatosToolStripMenuItem";
            this.consultaEnLaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.consultaEnLaBaseDeDatosToolStripMenuItem.Text = "Consulta en la base de datos";
            this.consultaEnLaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultaEnLaBaseDeDatosToolStripMenuItem_Click);
            // 
            // frmEstructuraDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.BackgroundImage = global::pryEstructuraDeDatos.Properties.Resources.fondo_formulario_grande;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 461);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstructuraDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSistema;
        private System.Windows.Forms.ToolStripMenuItem datosProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLineales;
        private System.Windows.Forms.ToolStripMenuItem tsmNoLineales;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasEnlazadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDoblementeEnlazaadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesConTablasDeLaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEnLaBaseDeDatosToolStripMenuItem;
    }
}

