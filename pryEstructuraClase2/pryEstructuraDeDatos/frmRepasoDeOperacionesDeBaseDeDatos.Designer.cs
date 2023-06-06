namespace pryEstructuraDeDatos
{
    partial class frmRepasoDeOperacionesDeBaseDeDatos
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOperacion = new System.Windows.Forms.ComboBox();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 248);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 297);
            this.dgv.TabIndex = 6;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(12, 65);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(776, 151);
            this.lblEnunciado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operaciones a realizar en la base de datos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstOperacion
            // 
            this.lstOperacion.FormattingEnabled = true;
            this.lstOperacion.Items.AddRange(new object[] {
            "Diferencia",
            "Interseccion",
            "Juntar",
            "Proyeccion Simple",
            "Proyeccion Multiatributo",
            "Seleccion Multiatributo con operador AND",
            "Seleccion Multiatributo con operador OR",
            "Seleccion Multiatributo por convolucion",
            "Seleccion Simple",
            "Unión"});
            this.lstOperacion.Location = new System.Drawing.Point(303, 12);
            this.lstOperacion.Name = "lstOperacion";
            this.lstOperacion.Size = new System.Drawing.Size(322, 21);
            this.lstOperacion.TabIndex = 9;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(652, 10);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(136, 23);
            this.cmdListar.TabIndex = 10;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmRepasoDeOperacionesDeBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.lstOperacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.dgv);
            this.Name = "frmRepasoDeOperacionesDeBaseDeDatos";
            this.Text = "Repaso De Operaciones De Base De Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstOperacion;
        private System.Windows.Forms.Button cmdListar;
    }
}