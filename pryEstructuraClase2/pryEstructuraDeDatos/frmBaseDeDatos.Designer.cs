namespace pryEstructuraDeDatos
{
    partial class frmBaseDeDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcOperacionesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.mrcOperacionesDeSeleccion = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionConvolucion = new System.Windows.Forms.Button();
            this.cmdSeleccionMulti = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.mrcOperacionesDeProyeccion = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdProyeccionMulti = new System.Windows.Forms.Button();
            this.cmdProyeccionSimple = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.mrcOperacionesAlgebraicas.SuspendLayout();
            this.mrcOperacionesDeSeleccion.SuspendLayout();
            this.mrcOperacionesDeProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcOperacionesAlgebraicas
            // 
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdDiferencia);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdInterseccion);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.cmdUnion);
            this.mrcOperacionesAlgebraicas.Location = new System.Drawing.Point(560, 331);
            this.mrcOperacionesAlgebraicas.Name = "mrcOperacionesAlgebraicas";
            this.mrcOperacionesAlgebraicas.Size = new System.Drawing.Size(228, 153);
            this.mrcOperacionesAlgebraicas.TabIndex = 6;
            this.mrcOperacionesAlgebraicas.TabStop = false;
            this.mrcOperacionesAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(13, 109);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(203, 23);
            this.cmdDiferencia.TabIndex = 2;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click_1);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(13, 62);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(203, 23);
            this.cmdInterseccion.TabIndex = 1;
            this.cmdInterseccion.Text = "Interseccion";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click_1);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(13, 19);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(203, 23);
            this.cmdUnion.TabIndex = 0;
            this.cmdUnion.Text = "Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click_1);
            // 
            // mrcOperacionesDeSeleccion
            // 
            this.mrcOperacionesDeSeleccion.Controls.Add(this.cmdSeleccionConvolucion);
            this.mrcOperacionesDeSeleccion.Controls.Add(this.cmdSeleccionMulti);
            this.mrcOperacionesDeSeleccion.Controls.Add(this.cmdSeleccionSimple);
            this.mrcOperacionesDeSeleccion.Location = new System.Drawing.Point(286, 331);
            this.mrcOperacionesDeSeleccion.Name = "mrcOperacionesDeSeleccion";
            this.mrcOperacionesDeSeleccion.Size = new System.Drawing.Size(228, 153);
            this.mrcOperacionesDeSeleccion.TabIndex = 7;
            this.mrcOperacionesDeSeleccion.TabStop = false;
            this.mrcOperacionesDeSeleccion.Text = "Opereaciones de Seleccion";
            // 
            // cmdSeleccionConvolucion
            // 
            this.cmdSeleccionConvolucion.Location = new System.Drawing.Point(13, 109);
            this.cmdSeleccionConvolucion.Name = "cmdSeleccionConvolucion";
            this.cmdSeleccionConvolucion.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionConvolucion.TabIndex = 2;
            this.cmdSeleccionConvolucion.Text = "Seleccion por convolucion";
            this.cmdSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.cmdSeleccionConvolucion.Click += new System.EventHandler(this.cmdSeleccionConvolucion_Click);
            // 
            // cmdSeleccionMulti
            // 
            this.cmdSeleccionMulti.Location = new System.Drawing.Point(13, 62);
            this.cmdSeleccionMulti.Name = "cmdSeleccionMulti";
            this.cmdSeleccionMulti.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionMulti.TabIndex = 1;
            this.cmdSeleccionMulti.Text = "Seleccion Multiatributo";
            this.cmdSeleccionMulti.UseVisualStyleBackColor = true;
            this.cmdSeleccionMulti.Click += new System.EventHandler(this.cmdSeleccionMulti_Click_1);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(13, 19);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionSimple.TabIndex = 0;
            this.cmdSeleccionSimple.Text = "Seleccion Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.cmdSeleccionSimple_Click_1);
            // 
            // mrcOperacionesDeProyeccion
            // 
            this.mrcOperacionesDeProyeccion.Controls.Add(this.cmdJuntar);
            this.mrcOperacionesDeProyeccion.Controls.Add(this.cmdProyeccionMulti);
            this.mrcOperacionesDeProyeccion.Controls.Add(this.cmdProyeccionSimple);
            this.mrcOperacionesDeProyeccion.Location = new System.Drawing.Point(12, 331);
            this.mrcOperacionesDeProyeccion.Name = "mrcOperacionesDeProyeccion";
            this.mrcOperacionesDeProyeccion.Size = new System.Drawing.Size(228, 153);
            this.mrcOperacionesDeProyeccion.TabIndex = 5;
            this.mrcOperacionesDeProyeccion.TabStop = false;
            this.mrcOperacionesDeProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(13, 109);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(203, 23);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdProyeccionMulti
            // 
            this.cmdProyeccionMulti.Location = new System.Drawing.Point(13, 62);
            this.cmdProyeccionMulti.Name = "cmdProyeccionMulti";
            this.cmdProyeccionMulti.Size = new System.Drawing.Size(203, 23);
            this.cmdProyeccionMulti.TabIndex = 1;
            this.cmdProyeccionMulti.Text = "Proyeccion Multiatributo";
            this.cmdProyeccionMulti.UseVisualStyleBackColor = true;
            this.cmdProyeccionMulti.Click += new System.EventHandler(this.cmdProyeccionMulti_Click_1);
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(13, 19);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(203, 23);
            this.cmdProyeccionSimple.TabIndex = 0;
            this.cmdProyeccionSimple.Text = "Proyeccion Simple";
            this.cmdProyeccionSimple.UseVisualStyleBackColor = true;
            this.cmdProyeccionSimple.Click += new System.EventHandler(this.cmdProyeccionSimple_Click_1);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 297);
            this.dgv.TabIndex = 4;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 492);
            this.Controls.Add(this.mrcOperacionesAlgebraicas);
            this.Controls.Add(this.mrcOperacionesDeSeleccion);
            this.Controls.Add(this.mrcOperacionesDeProyeccion);
            this.Controls.Add(this.dgv);
            this.Name = "frmBaseDeDatos";
            this.Text = "Base De Datos";
            this.Load += new System.EventHandler(this.frmBaseDeDatos_Load);
            this.mrcOperacionesAlgebraicas.ResumeLayout(false);
            this.mrcOperacionesDeSeleccion.ResumeLayout(false);
            this.mrcOperacionesDeProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcOperacionesAlgebraicas;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
        private System.Windows.Forms.GroupBox mrcOperacionesDeSeleccion;
        private System.Windows.Forms.Button cmdSeleccionConvolucion;
        private System.Windows.Forms.Button cmdSeleccionMulti;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.GroupBox mrcOperacionesDeProyeccion;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyeccionMulti;
        private System.Windows.Forms.Button cmdProyeccionSimple;
        private System.Windows.Forms.DataGridView dgv;
    }
}