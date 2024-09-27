namespace Sesion12
{
    partial class Form1
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbregister = new System.Windows.Forms.GroupBox();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.gbregister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(126, 34);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(126, 67);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(126, 103);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(135, 145);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Precio";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(220, 26);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(257, 20);
            this.tbid.TabIndex = 4;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(220, 64);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(257, 20);
            this.tbname.TabIndex = 5;
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(220, 103);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(257, 20);
            this.tbdescripcion.TabIndex = 6;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(220, 145);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(257, 20);
            this.tbprice.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(511, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbregister
            // 
            this.gbregister.Controls.Add(this.dgvproducts);
            this.gbregister.Location = new System.Drawing.Point(56, 202);
            this.gbregister.Name = "gbregister";
            this.gbregister.Size = new System.Drawing.Size(690, 129);
            this.gbregister.TabIndex = 9;
            this.gbregister.TabStop = false;
            this.gbregister.Text = ".";
            // 
            // dgvproducts
            // 
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproducts.Location = new System.Drawing.Point(3, 16);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.Size = new System.Drawing.Size(684, 110);
            this.dgvproducts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbregister);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbdescripcion);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbregister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox gbregister;
        private System.Windows.Forms.DataGridView dgvproducts;
    }
}

