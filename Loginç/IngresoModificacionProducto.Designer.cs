﻿namespace Loginç
{
    partial class IngresoModificacionProducto
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriaProductoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet6 = new Loginç._A_Beltran_CopiadoraDataSet6();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._A_Beltran_CopiadoraDataSet7 = new Loginç._A_Beltran_CopiadoraDataSet7();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._A_Beltran_CopiadoraDataSet3 = new Loginç._A_Beltran_CopiadoraDataSet3();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet3TableAdapters.EstadoTableAdapter();
            this._A_Beltran_CopiadoraDataSet4 = new Loginç._A_Beltran_CopiadoraDataSet4();
            this.categoriaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_ProductoTableAdapter = new Loginç._A_Beltran_CopiadoraDataSet4TableAdapters.Categoria_ProductoTableAdapter();
            this._A_Beltran_CopiadoraDataSet5 = new Loginç._A_Beltran_CopiadoraDataSet5();
            this.categoriaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_ProductoTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet5TableAdapters.Categoria_ProductoTableAdapter();
            this.obtenerIdProducto = new System.Windows.Forms.TextBox();
            this.categoria_ProductoTableAdapter2 = new Loginç._A_Beltran_CopiadoraDataSet6TableAdapters.Categoria_ProductoTableAdapter();
            this.estadoTableAdapter1 = new Loginç._A_Beltran_CopiadoraDataSet7TableAdapters.EstadoTableAdapter();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(54, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 125);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clasificacion del Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriaProductoBindingSource2;
            this.comboBox1.DisplayMember = "Nombre_Categoria";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID_Categoria";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // categoriaProductoBindingSource2
            // 
            this.categoriaProductoBindingSource2.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource2.DataSource = this._A_Beltran_CopiadoraDataSet6;
            // 
            // _A_Beltran_CopiadoraDataSet6
            // 
            this._A_Beltran_CopiadoraDataSet6.DataSetName = "_A_Beltran_CopiadoraDataSet6";
            this._A_Beltran_CopiadoraDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.estadoBindingSource1;
            this.comboBox2.DisplayMember = "Descripcion_Estado";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID_Estado";
            this.comboBox2.Visible = false;
            // 
            // estadoBindingSource1
            // 
            this.estadoBindingSource1.DataMember = "Estado";
            this.estadoBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet7;
            // 
            // _A_Beltran_CopiadoraDataSet7
            // 
            this._A_Beltran_CopiadoraDataSet7.DataSetName = "_A_Beltran_CopiadoraDataSet7";
            this._A_Beltran_CopiadoraDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Descripcion del Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codigo de Barra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numero de Serie:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(242, 197);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(188, 20);
            this.txtCantidad.TabIndex = 26;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(242, 171);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(188, 20);
            this.txtPrecio.TabIndex = 25;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(242, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(242, 119);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(188, 20);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(242, 93);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(188, 20);
            this.txtNum.TabIndex = 22;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            this.txtNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.Location = new System.Drawing.Point(242, 67);
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(188, 20);
            this.txtNomProducto.TabIndex = 21;
            this.txtNomProducto.TextChanged += new System.EventHandler(this.txtNomProducto_TextChanged);
            this.txtNomProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomProducto_KeyDown);
            this.txtNomProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomProducto_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(242, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo:";
            this.label1.Visible = false;
            // 
            // _A_Beltran_CopiadoraDataSet3
            // 
            this._A_Beltran_CopiadoraDataSet3.DataSetName = "_A_Beltran_CopiadoraDataSet3";
            this._A_Beltran_CopiadoraDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet3;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet4
            // 
            this._A_Beltran_CopiadoraDataSet4.DataSetName = "_A_Beltran_CopiadoraDataSet4";
            this._A_Beltran_CopiadoraDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaProductoBindingSource
            // 
            this.categoriaProductoBindingSource.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource.DataSource = this._A_Beltran_CopiadoraDataSet4;
            // 
            // categoria_ProductoTableAdapter
            // 
            this.categoria_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // _A_Beltran_CopiadoraDataSet5
            // 
            this._A_Beltran_CopiadoraDataSet5.DataSetName = "_A_Beltran_CopiadoraDataSet5";
            this._A_Beltran_CopiadoraDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaProductoBindingSource1
            // 
            this.categoriaProductoBindingSource1.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource1.DataSource = this._A_Beltran_CopiadoraDataSet5;
            // 
            // categoria_ProductoTableAdapter1
            // 
            this.categoria_ProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // obtenerIdProducto
            // 
            this.obtenerIdProducto.Location = new System.Drawing.Point(12, 12);
            this.obtenerIdProducto.Name = "obtenerIdProducto";
            this.obtenerIdProducto.Size = new System.Drawing.Size(21, 20);
            this.obtenerIdProducto.TabIndex = 36;
            this.obtenerIdProducto.Visible = false;
            // 
            // categoria_ProductoTableAdapter2
            // 
            this.categoria_ProductoTableAdapter2.ClearBeforeFill = true;
            // 
            // estadoTableAdapter1
            // 
            this.estadoTableAdapter1.ClearBeforeFill = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // IngresoModificacionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 413);
            this.Controls.Add(this.obtenerIdProducto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNomProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoModificacionProducto";
            this.Text = "IngresoModificacionProducto";
            this.Load += new System.EventHandler(this.IngresoModificacionProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._A_Beltran_CopiadoraDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtNomProducto;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private _A_Beltran_CopiadoraDataSet3 _A_Beltran_CopiadoraDataSet3;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private _A_Beltran_CopiadoraDataSet3TableAdapters.EstadoTableAdapter estadoTableAdapter;
        private _A_Beltran_CopiadoraDataSet4 _A_Beltran_CopiadoraDataSet4;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource;
        private _A_Beltran_CopiadoraDataSet4TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter;
        private _A_Beltran_CopiadoraDataSet5 _A_Beltran_CopiadoraDataSet5;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource1;
        private _A_Beltran_CopiadoraDataSet5TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox obtenerIdProducto;
        public System.Windows.Forms.ComboBox comboBox1;
        private _A_Beltran_CopiadoraDataSet6 _A_Beltran_CopiadoraDataSet6;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource2;
        private _A_Beltran_CopiadoraDataSet6TableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter2;
        private _A_Beltran_CopiadoraDataSet7 _A_Beltran_CopiadoraDataSet7;
        private System.Windows.Forms.BindingSource estadoBindingSource1;
        private _A_Beltran_CopiadoraDataSet7TableAdapters.EstadoTableAdapter estadoTableAdapter1;
        private System.Windows.Forms.ErrorProvider epError;
        public System.Windows.Forms.Label label9;
    }
}