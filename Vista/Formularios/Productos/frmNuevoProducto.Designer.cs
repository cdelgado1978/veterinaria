
namespace Veterinaria.Vista.Formularios.Productos
{
    partial class frmNuevoProducto
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label proveedorIdLabel;
            System.Windows.Forms.Label tipoProductoIdLabel;
            this.productoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCosto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbProveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTipoProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkBoxInactivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            cantidadLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            proveedorIdLabel = new System.Windows.Forms.Label();
            tipoProductoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.White;
            cantidadLabel.Location = new System.Drawing.Point(117, 381);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(72, 20);
            cantidadLabel.TabIndex = 25;
            cantidadLabel.Text = "Cantidad:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.White;
            costoLabel.Location = new System.Drawing.Point(137, 330);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(50, 20);
            costoLabel.TabIndex = 26;
            costoLabel.Text = "Costo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(99, 147);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(90, 20);
            descripcionLabel.TabIndex = 27;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(122, 117);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 29;
            nombreLabel.Text = "Nombre:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.Color.White;
            precioLabel.Location = new System.Drawing.Point(376, 330);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(53, 20);
            precioLabel.TabIndex = 30;
            precioLabel.Text = "Precio:";
            // 
            // proveedorIdLabel
            // 
            proveedorIdLabel.AutoSize = true;
            proveedorIdLabel.BackColor = System.Drawing.Color.White;
            proveedorIdLabel.Location = new System.Drawing.Point(106, 292);
            proveedorIdLabel.Name = "proveedorIdLabel";
            proveedorIdLabel.Size = new System.Drawing.Size(80, 20);
            proveedorIdLabel.TabIndex = 31;
            proveedorIdLabel.Text = "Proveedor:";
            // 
            // tipoProductoIdLabel
            // 
            tipoProductoIdLabel.AutoSize = true;
            tipoProductoIdLabel.BackColor = System.Drawing.Color.White;
            tipoProductoIdLabel.Location = new System.Drawing.Point(83, 239);
            tipoProductoIdLabel.Name = "tipoProductoIdLabel";
            tipoProductoIdLabel.Size = new System.Drawing.Size(106, 20);
            tipoProductoIdLabel.TabIndex = 32;
            tipoProductoIdLabel.Text = "Tipo Producto:";
            // 
            // productoDtoBindingSource
            // 
            this.productoDtoBindingSource.DataSource = typeof(Veterinaria.Modelo.DTO.ProductoDto);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Veterinaria.Modelo.Producto);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtPrecio);
            this.guna2GroupBox1.Controls.Add(this.txtCosto);
            this.guna2GroupBox1.Controls.Add(this.txtCantidad);
            this.guna2GroupBox1.Controls.Add(this.txtDescripcion);
            this.guna2GroupBox1.Controls.Add(this.txtNombre);
            this.guna2GroupBox1.Controls.Add(this.cbProveedor);
            this.guna2GroupBox1.Controls.Add(this.cbTipoProducto);
            this.guna2GroupBox1.Controls.Add(cantidadLabel);
            this.guna2GroupBox1.Controls.Add(costoLabel);
            this.guna2GroupBox1.Controls.Add(descripcionLabel);
            this.guna2GroupBox1.Controls.Add(this.chkBoxInactivo);
            this.guna2GroupBox1.Controls.Add(nombreLabel);
            this.guna2GroupBox1.Controls.Add(precioLabel);
            this.guna2GroupBox1.Controls.Add(proveedorIdLabel);
            this.guna2GroupBox1.Controls.Add(tipoProductoIdLabel);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(651, 487);
            this.guna2GroupBox1.TabIndex = 25;
            this.guna2GroupBox1.Text = "Nuevo Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.Location = new System.Drawing.Point(436, 309);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(128, 41);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCosto
            // 
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.DefaultText = "";
            this.txtCosto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCosto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCosto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCosto.DisabledState.Parent = this.txtCosto;
            this.txtCosto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCosto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCosto.FocusedState.Parent = this.txtCosto;
            this.txtCosto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCosto.HoverState.Parent = this.txtCosto;
            this.txtCosto.Location = new System.Drawing.Point(194, 309);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.PasswordChar = '\0';
            this.txtCosto.PlaceholderText = "";
            this.txtCosto.SelectedText = "";
            this.txtCosto.ShadowDecoration.Parent = this.txtCosto;
            this.txtCosto.Size = new System.Drawing.Size(134, 41);
            this.txtCosto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.HoverState.Parent = this.txtCantidad;
            this.txtCantidad.Location = new System.Drawing.Point(194, 360);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(134, 41);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(194, 147);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(370, 68);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(194, 96);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(370, 41);
            this.txtNombre.TabIndex = 1;
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.Transparent;
            this.cbProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cbProveedor.FocusedState.Parent = this.cbProveedor;
            this.cbProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.HoverState.Parent = this.cbProveedor;
            this.cbProveedor.ItemHeight = 30;
            this.cbProveedor.ItemsAppearance.Parent = this.cbProveedor;
            this.cbProveedor.Location = new System.Drawing.Point(194, 265);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.ShadowDecoration.Parent = this.cbProveedor;
            this.cbProveedor.Size = new System.Drawing.Size(370, 36);
            this.cbProveedor.TabIndex = 4;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoProducto.FocusedState.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.HoverState.Parent = this.cbTipoProducto;
            this.cbTipoProducto.ItemHeight = 30;
            this.cbTipoProducto.ItemsAppearance.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Location = new System.Drawing.Point(194, 223);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.ShadowDecoration.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Size = new System.Drawing.Size(370, 36);
            this.cbTipoProducto.TabIndex = 3;
            // 
            // chkBoxInactivo
            // 
            this.chkBoxInactivo.BackColor = System.Drawing.Color.White;
            this.chkBoxInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productoBindingSource, "Inactivo", true));
            this.chkBoxInactivo.Location = new System.Drawing.Point(460, 64);
            this.chkBoxInactivo.Name = "chkBoxInactivo";
            this.chkBoxInactivo.Size = new System.Drawing.Size(104, 24);
            this.chkBoxInactivo.TabIndex = 28;
            this.chkBoxInactivo.Text = "Inactivo";
            this.chkBoxInactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 63);
            this.panel1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(82, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(473, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(651, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.productoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productoDtoBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtCosto;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cbProveedor;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoProducto;
        private System.Windows.Forms.CheckBox chkBoxInactivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}