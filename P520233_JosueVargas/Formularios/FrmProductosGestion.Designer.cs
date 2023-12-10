namespace P520233_JosueVargas.Formularios
{
    partial class FrmProductosGestion
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCantidadStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTasaImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboxCategoriaTipo = new System.Windows.Forms.ComboBox();
            this.TxtUtilidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtProductoID = new System.Windows.Forms.TextBox();
            this.TxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.CbProductoActivo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 470);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(210, 71);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(972, 470);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(210, 71);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Sienna;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(1205, 470);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(210, 71);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbProductoActivo);
            this.groupBox1.Controls.Add(this.TxtCodigoBarras);
            this.groupBox1.Controls.Add(this.TxtProductoID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtCantidadStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtSubTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTasaImpuesto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CboxCategoriaTipo);
            this.groupBox1.Controls.Add(this.TxtUtilidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNombreProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(88, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1292, 467);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Producto...";
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Location = new System.Drawing.Point(661, 371);
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.Size = new System.Drawing.Size(433, 31);
            this.TxtCantidadStock.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad Stock";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(661, 296);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(433, 31);
            this.TxtPrecioUnitario.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Precio Unitario";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(95, 369);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(419, 31);
            this.TxtSubTotal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "SubTotal";
            // 
            // TxtTasaImpuesto
            // 
            this.TxtTasaImpuesto.Location = new System.Drawing.Point(661, 220);
            this.TxtTasaImpuesto.Name = "TxtTasaImpuesto";
            this.TxtTasaImpuesto.Size = new System.Drawing.Size(433, 31);
            this.TxtTasaImpuesto.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "TasaImpuesto";
            // 
            // CboxCategoriaTipo
            // 
            this.CboxCategoriaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoriaTipo.FormattingEnabled = true;
            this.CboxCategoriaTipo.Location = new System.Drawing.Point(661, 146);
            this.CboxCategoriaTipo.Name = "CboxCategoriaTipo";
            this.CboxCategoriaTipo.Size = new System.Drawing.Size(433, 33);
            this.CboxCategoriaTipo.TabIndex = 7;
            // 
            // TxtUtilidad
            // 
            this.TxtUtilidad.Location = new System.Drawing.Point(96, 299);
            this.TxtUtilidad.Name = "TxtUtilidad";
            this.TxtUtilidad.Size = new System.Drawing.Size(418, 31);
            this.TxtUtilidad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(96, 224);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(418, 31);
            this.TxtCosto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Utilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(95, 148);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(419, 31);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de Barras";
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            this.DgvListaProductos.AllowUserToOrderColumns = true;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductoID,
            this.ColCodigoBarras,
            this.ColNombreProducto,
            this.ColCosto,
            this.ColUtilidad,
            this.ColSubTotal,
            this.ColTasaImpuesto,
            this.ColPrecioUnitario,
            this.ColCantidadStock});
            this.DgvListaProductos.Location = new System.Drawing.Point(12, 36);
            this.DgvListaProductos.MultiSelect = false;
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 82;
            this.DgvListaProductos.RowTemplate.Height = 33;
            this.DgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProductos.Size = new System.Drawing.Size(1403, 411);
            this.DgvListaProductos.TabIndex = 4;
            this.DgvListaProductos.VirtualMode = true;
            this.DgvListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellClick);
            this.DgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellContentClick);
            this.DgvListaProductos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaProductos_DataBindingComplete);
            // 
            // ColProductoID
            // 
            this.ColProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "ID";
            this.ColProductoID.MinimumWidth = 10;
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            this.ColProductoID.Width = 120;
            // 
            // ColCodigoBarras
            // 
            this.ColCodigoBarras.DataPropertyName = "CodigoBarras";
            this.ColCodigoBarras.HeaderText = "CodigoBarras";
            this.ColCodigoBarras.MinimumWidth = 10;
            this.ColCodigoBarras.Name = "ColCodigoBarras";
            this.ColCodigoBarras.ReadOnly = true;
            this.ColCodigoBarras.Width = 200;
            // 
            // ColNombreProducto
            // 
            this.ColNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombreProducto.DataPropertyName = "NombreProducto";
            this.ColNombreProducto.HeaderText = "Producto";
            this.ColNombreProducto.MinimumWidth = 10;
            this.ColNombreProducto.Name = "ColNombreProducto";
            this.ColNombreProducto.ReadOnly = true;
            this.ColNombreProducto.Width = 300;
            // 
            // ColCosto
            // 
            this.ColCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCosto.DataPropertyName = "Costo";
            this.ColCosto.HeaderText = "Costo";
            this.ColCosto.MinimumWidth = 10;
            this.ColCosto.Name = "ColCosto";
            this.ColCosto.ReadOnly = true;
            this.ColCosto.Width = 120;
            // 
            // ColUtilidad
            // 
            this.ColUtilidad.DataPropertyName = "Utilidad";
            this.ColUtilidad.HeaderText = "Utilidad";
            this.ColUtilidad.MinimumWidth = 10;
            this.ColUtilidad.Name = "ColUtilidad";
            this.ColUtilidad.ReadOnly = true;
            this.ColUtilidad.Width = 200;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.DataPropertyName = "SubTotal";
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.MinimumWidth = 10;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 200;
            // 
            // ColTasaImpuesto
            // 
            this.ColTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.ColTasaImpuesto.HeaderText = "Impuesto";
            this.ColTasaImpuesto.MinimumWidth = 10;
            this.ColTasaImpuesto.Name = "ColTasaImpuesto";
            this.ColTasaImpuesto.ReadOnly = true;
            this.ColTasaImpuesto.Width = 200;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.ColPrecioUnitario.HeaderText = "PrecioU";
            this.ColPrecioUnitario.MinimumWidth = 10;
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.ReadOnly = true;
            this.ColPrecioUnitario.Width = 200;
            // 
            // ColCantidadStock
            // 
            this.ColCantidadStock.DataPropertyName = "CantidadStock";
            this.ColCantidadStock.HeaderText = "CStock";
            this.ColCantidadStock.MinimumWidth = 10;
            this.ColCantidadStock.Name = "ColCantidadStock";
            this.ColCantidadStock.ReadOnly = true;
            this.ColCantidadStock.Width = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "ProductoID";
            // 
            // TxtProductoID
            // 
            this.TxtProductoID.Enabled = false;
            this.TxtProductoID.Location = new System.Drawing.Point(95, 69);
            this.TxtProductoID.Name = "TxtProductoID";
            this.TxtProductoID.Size = new System.Drawing.Size(296, 31);
            this.TxtProductoID.TabIndex = 19;
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.Location = new System.Drawing.Point(661, 69);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Size = new System.Drawing.Size(419, 31);
            this.TxtCodigoBarras.TabIndex = 20;
            // 
            // CbProductoActivo
            // 
            this.CbProductoActivo.AutoSize = true;
            this.CbProductoActivo.Enabled = false;
            this.CbProductoActivo.Location = new System.Drawing.Point(397, 41);
            this.CbProductoActivo.Name = "CbProductoActivo";
            this.CbProductoActivo.Size = new System.Drawing.Size(103, 29);
            this.CbProductoActivo.TabIndex = 21;
            this.CbProductoActivo.Text = "Activo";
            this.CbProductoActivo.UseVisualStyleBackColor = true;
            // 
            // FrmProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1035);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvListaProductos);
            this.Name = "FrmProductosGestion";
            this.Text = "FrmProductosGestion";
            this.Load += new System.EventHandler(this.FrmProductosGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTasaImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxCategoriaTipo;
        private System.Windows.Forms.TextBox TxtUtilidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCantidadStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.DataGridView DgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadStock;
        private System.Windows.Forms.TextBox TxtProductoID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigoBarras;
        private System.Windows.Forms.CheckBox CbProductoActivo;
    }
}