namespace P520233_JosueVargas.Formularios
{
    partial class FrmMovimientosInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientosInventario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAnotaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvListaDetalle = new System.Windows.Forms.DataGridView();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTotalGranTotal = new System.Windows.Forms.Label();
            this.LblTotalImpuestos = new System.Windows.Forms.Label();
            this.LblTotalSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalCosto = new System.Windows.Forms.Label();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDetalle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAnotaciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1424, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENCABEZADO";
            // 
            // TxtAnotaciones
            // 
            this.TxtAnotaciones.Location = new System.Drawing.Point(1113, 82);
            this.TxtAnotaciones.Multiline = true;
            this.TxtAnotaciones.Name = "TxtAnotaciones";
            this.TxtAnotaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAnotaciones.Size = new System.Drawing.Size(277, 132);
            this.TxtAnotaciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1108, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anotaciones";
            // 
            // CboxTipo
            // 
            this.CboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipo.FormattingEnabled = true;
            this.CboxTipo.Location = new System.Drawing.Point(614, 80);
            this.CboxTipo.Name = "CboxTipo";
            this.CboxTipo.Size = new System.Drawing.Size(308, 33);
            this.CboxTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Movimiento";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(44, 80);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(408, 31);
            this.DtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Movimiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvListaDetalle);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1424, 557);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE";
            // 
            // DgvListaDetalle
            // 
            this.DgvListaDetalle.AllowUserToAddRows = false;
            this.DgvListaDetalle.AllowUserToDeleteRows = false;
            this.DgvListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CNombreProducto,
            this.CCantidadMovimiento,
            this.CCosto,
            this.CSubtotal,
            this.CTotalIVA,
            this.CPrecioUnitario,
            this.CCodigoDeBarras});
            this.DgvListaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaDetalle.Location = new System.Drawing.Point(3, 74);
            this.DgvListaDetalle.Name = "DgvListaDetalle";
            this.DgvListaDetalle.ReadOnly = true;
            this.DgvListaDetalle.RowHeadersVisible = false;
            this.DgvListaDetalle.RowHeadersWidth = 82;
            this.DgvListaDetalle.RowTemplate.Height = 33;
            this.DgvListaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaDetalle.Size = new System.Drawing.Size(1418, 480);
            this.DgvListaDetalle.TabIndex = 1;
            // 
            // CProductoID
            // 
            this.CProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Codigo";
            this.CProductoID.MinimumWidth = 10;
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            this.CProductoID.Width = 90;
            // 
            // CNombreProducto
            // 
            this.CNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreProducto.DataPropertyName = "NombreProducto";
            this.CNombreProducto.HeaderText = "Producto";
            this.CNombreProducto.MinimumWidth = 10;
            this.CNombreProducto.Name = "CNombreProducto";
            this.CNombreProducto.ReadOnly = true;
            // 
            // CCantidadMovimiento
            // 
            this.CCantidadMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidadMovimiento.DataPropertyName = "CantidadMovimiento";
            this.CCantidadMovimiento.HeaderText = "Cantidad";
            this.CCantidadMovimiento.MinimumWidth = 10;
            this.CCantidadMovimiento.Name = "CCantidadMovimiento";
            this.CCantidadMovimiento.ReadOnly = true;
            this.CCantidadMovimiento.Width = 200;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.MinimumWidth = 10;
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Width = 200;
            // 
            // CSubtotal
            // 
            this.CSubtotal.DataPropertyName = "Subtotal";
            this.CSubtotal.HeaderText = "Precio sin IVA";
            this.CSubtotal.MinimumWidth = 10;
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.ReadOnly = true;
            this.CSubtotal.Width = 200;
            // 
            // CTotalIVA
            // 
            this.CTotalIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTotalIVA.DataPropertyName = "CTotalIVA";
            this.CTotalIVA.HeaderText = "IVA";
            this.CTotalIVA.MinimumWidth = 10;
            this.CTotalIVA.Name = "CTotalIVA";
            this.CTotalIVA.ReadOnly = true;
            this.CTotalIVA.Width = 60;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio final";
            this.CPrecioUnitario.MinimumWidth = 10;
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            this.CPrecioUnitario.Width = 200;
            // 
            // CCodigoDeBarras
            // 
            this.CCodigoDeBarras.DataPropertyName = "CodigoDeBarras";
            this.CCodigoDeBarras.HeaderText = "Codigo de barras";
            this.CCodigoDeBarras.MinimumWidth = 10;
            this.CCodigoDeBarras.Name = "CCodigoDeBarras";
            this.CCodigoDeBarras.ReadOnly = true;
            this.CCodigoDeBarras.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregar,
            this.BtnModificar,
            this.BtnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1418, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(18, 841);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1418, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOTALES:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.LblTotalGranTotal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalImpuestos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalSubTotal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalCosto, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1412, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblTotalGranTotal
            // 
            this.LblTotalGranTotal.AutoSize = true;
            this.LblTotalGranTotal.BackColor = System.Drawing.Color.Black;
            this.LblTotalGranTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotalGranTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTotalGranTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalGranTotal.ForeColor = System.Drawing.Color.Yellow;
            this.LblTotalGranTotal.Location = new System.Drawing.Point(1062, 25);
            this.LblTotalGranTotal.Name = "LblTotalGranTotal";
            this.LblTotalGranTotal.Size = new System.Drawing.Size(347, 64);
            this.LblTotalGranTotal.TabIndex = 7;
            this.LblTotalGranTotal.Text = "0";
            this.LblTotalGranTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalImpuestos
            // 
            this.LblTotalImpuestos.AutoSize = true;
            this.LblTotalImpuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotalImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotalImpuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTotalImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalImpuestos.ForeColor = System.Drawing.Color.White;
            this.LblTotalImpuestos.Location = new System.Drawing.Point(709, 25);
            this.LblTotalImpuestos.Name = "LblTotalImpuestos";
            this.LblTotalImpuestos.Size = new System.Drawing.Size(347, 64);
            this.LblTotalImpuestos.TabIndex = 6;
            this.LblTotalImpuestos.Text = "0";
            this.LblTotalImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalSubTotal
            // 
            this.LblTotalSubTotal.AutoSize = true;
            this.LblTotalSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotalSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotalSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTotalSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSubTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotalSubTotal.Location = new System.Drawing.Point(356, 25);
            this.LblTotalSubTotal.Name = "LblTotalSubTotal";
            this.LblTotalSubTotal.Size = new System.Drawing.Size(347, 64);
            this.LblTotalSubTotal.TabIndex = 5;
            this.LblTotalSubTotal.Text = "0";
            this.LblTotalSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(1062, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(709, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "IMPUESTOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(356, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "SUBTOTAL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "COSTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalCosto
            // 
            this.LblTotalCosto.AutoSize = true;
            this.LblTotalCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotalCosto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotalCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTotalCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCosto.ForeColor = System.Drawing.Color.White;
            this.LblTotalCosto.Location = new System.Drawing.Point(3, 25);
            this.LblTotalCosto.Name = "LblTotalCosto";
            this.LblTotalCosto.Size = new System.Drawing.Size(347, 64);
            this.LblTotalCosto.TabIndex = 1;
            this.LblTotalCosto.Text = "0";
            this.LblTotalCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAplicar.ForeColor = System.Drawing.Color.White;
            this.BtnAplicar.Location = new System.Drawing.Point(30, 966);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(1047, 40);
            this.BtnAplicar.TabIndex = 3;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1088, 966);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(348, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(284, 41);
            this.BtnAgregar.Text = "Agergar Producto";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Chocolate;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(304, 44);
            this.BtnModificar.Text = "Modificar Producto";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(158, 44);
            this.BtnEliminar.Text = "Eliminar";
            // 
            // FrmMovimientosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 1018);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAplicar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMovimientosInventario";
            this.Text = "MovimientosDeInventario";
            this.Load += new System.EventHandler(this.FrmMovimientosInventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDetalle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAnotaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAgregar;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.DataGridView DgvListaDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotalCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotalGranTotal;
        private System.Windows.Forms.Label LblTotalImpuestos;
        private System.Windows.Forms.Label LblTotalSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoDeBarras;
    }
}