
namespace Veterinaria.Vista.Formularios.Productos
{
    partial class frmProductos
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
            System.Windows.Forms.Label tipoProductoIdLabel;
            System.Windows.Forms.Label proveedorIdLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label cantidadLabel;
            this.PanelRoot = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkBoxInactivo = new System.Windows.Forms.CheckBox();
            this.cbProveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTipoProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel_botones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PanelDetalle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbGridDetalle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTituloDetalle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.PanelControlBox = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            tipoProductoIdLabel = new System.Windows.Forms.Label();
            proveedorIdLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            this.PanelRoot.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.Panel_botones.SuspendLayout();
            this.PanelDetalle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridDetalle)).BeginInit();
            this.PanelTituloDetalle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.PanelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoProductoIdLabel
            // 
            tipoProductoIdLabel.AutoSize = true;
            tipoProductoIdLabel.BackColor = System.Drawing.Color.Transparent;
            tipoProductoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoProductoIdLabel.Location = new System.Drawing.Point(23, 160);
            tipoProductoIdLabel.Name = "tipoProductoIdLabel";
            tipoProductoIdLabel.Size = new System.Drawing.Size(115, 17);
            tipoProductoIdLabel.TabIndex = 47;
            tipoProductoIdLabel.Text = "Tipo Producto:";
            // 
            // proveedorIdLabel
            // 
            proveedorIdLabel.AutoSize = true;
            proveedorIdLabel.BackColor = System.Drawing.Color.Transparent;
            proveedorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proveedorIdLabel.Location = new System.Drawing.Point(51, 202);
            proveedorIdLabel.Name = "proveedorIdLabel";
            proveedorIdLabel.Size = new System.Drawing.Size(88, 17);
            proveedorIdLabel.TabIndex = 46;
            proveedorIdLabel.Text = "Proveedor:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.Color.Transparent;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(320, 236);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(59, 17);
            precioLabel.TabIndex = 45;
            precioLabel.Text = "Precio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(69, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 17);
            nombreLabel.TabIndex = 44;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(40, 69);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(98, 17);
            descripcionLabel.TabIndex = 42;
            descripcionLabel.Text = "Descripcion:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.Transparent;
            costoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(84, 236);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(54, 17);
            costoLabel.TabIndex = 41;
            costoLabel.Text = "Costo:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(61, 271);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(77, 17);
            cantidadLabel.TabIndex = 40;
            cantidadLabel.Text = "Cantidad:";
            // 
            // PanelRoot
            // 
            this.PanelRoot.Controls.Add(this.panelContenido);
            this.PanelRoot.Controls.Add(this.panelTitulo);
            this.PanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoot.Location = new System.Drawing.Point(0, 0);
            this.PanelRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRoot.Name = "PanelRoot";
            this.PanelRoot.Size = new System.Drawing.Size(1016, 671);
            this.PanelRoot.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.panelContenido.Controls.Add(this.PanelForm);
            this.panelContenido.Controls.Add(this.Panel_botones);
            this.panelContenido.Controls.Add(this.PanelDetalle);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 76);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1016, 595);
            this.panelContenido.TabIndex = 6;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(this.txtCantidad);
            this.PanelForm.Controls.Add(this.txtPrecio);
            this.PanelForm.Controls.Add(tipoProductoIdLabel);
            this.PanelForm.Controls.Add(this.txtCosto);
            this.PanelForm.Controls.Add(proveedorIdLabel);
            this.PanelForm.Controls.Add(precioLabel);
            this.PanelForm.Controls.Add(this.txtDescripcion);
            this.PanelForm.Controls.Add(nombreLabel);
            this.PanelForm.Controls.Add(this.txtNombre);
            this.PanelForm.Controls.Add(this.chkBoxInactivo);
            this.PanelForm.Controls.Add(this.cbProveedor);
            this.PanelForm.Controls.Add(descripcionLabel);
            this.PanelForm.Controls.Add(this.cbTipoProducto);
            this.PanelForm.Controls.Add(costoLabel);
            this.PanelForm.Controls.Add(cantidadLabel);
            this.PanelForm.Enabled = false;
            this.PanelForm.Location = new System.Drawing.Point(0, 0);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(848, 345);
            this.PanelForm.TabIndex = 48;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(139, 260);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 27);
            this.txtCantidad.TabIndex = 39;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(379, 231);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 27);
            this.txtPrecio.TabIndex = 38;
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(139, 230);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(133, 27);
            this.txtCosto.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(139, 65);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(371, 68);
            this.txtDescripcion.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(139, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 27);
            this.txtNombre.TabIndex = 33;
            // 
            // chkBoxInactivo
            // 
            this.chkBoxInactivo.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxInactivo.Location = new System.Drawing.Point(403, 260);
            this.chkBoxInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBoxInactivo.Name = "chkBoxInactivo";
            this.chkBoxInactivo.Size = new System.Drawing.Size(104, 25);
            this.chkBoxInactivo.TabIndex = 43;
            this.chkBoxInactivo.Text = "Inactivo";
            this.chkBoxInactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.UseVisualStyleBackColor = false;
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.Transparent;
            this.cbProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cbProveedor.FocusedState.Parent = this.cbProveedor;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.HoverState.Parent = this.cbProveedor;
            this.cbProveedor.ItemHeight = 30;
            this.cbProveedor.ItemsAppearance.Parent = this.cbProveedor;
            this.cbProveedor.Location = new System.Drawing.Point(139, 183);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.ShadowDecoration.Parent = this.cbProveedor;
            this.cbProveedor.Size = new System.Drawing.Size(369, 36);
            this.cbProveedor.TabIndex = 36;
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoProducto.FocusedState.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.HoverState.Parent = this.cbTipoProducto;
            this.cbTipoProducto.ItemHeight = 30;
            this.cbTipoProducto.ItemsAppearance.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Location = new System.Drawing.Point(143, 137);
            this.cbTipoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.ShadowDecoration.Parent = this.cbTipoProducto;
            this.cbTipoProducto.Size = new System.Drawing.Size(369, 36);
            this.cbTipoProducto.TabIndex = 35;
            // 
            // Panel_botones
            // 
            this.Panel_botones.Controls.Add(this.btnBorrar);
            this.Panel_botones.Controls.Add(this.btnEditar);
            this.Panel_botones.Controls.Add(this.btnNuevo);
            this.Panel_botones.Controls.Add(this.btnGuardar);
            this.Panel_botones.Location = new System.Drawing.Point(848, 0);
            this.Panel_botones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_botones.Name = "Panel_botones";
            this.Panel_botones.Size = new System.Drawing.Size(176, 345);
            this.Panel_botones.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(36, 85);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 41);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(36, 39);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 41);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(36, 130);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 41);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PanelDetalle
            // 
            this.PanelDetalle.Controls.Add(this.panel2);
            this.PanelDetalle.Controls.Add(this.PanelTituloDetalle);
            this.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDetalle.Location = new System.Drawing.Point(0, 345);
            this.PanelDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(1016, 250);
            this.PanelDetalle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dbGridDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 204);
            this.panel2.TabIndex = 2;
            // 
            // dbGridDetalle
            // 
            this.dbGridDetalle.AllowUserToAddRows = false;
            this.dbGridDetalle.AllowUserToDeleteRows = false;
            this.dbGridDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.dbGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Inactivo,
            this.Nombre,
            this.TipoProductoNombre,
            this.Descripcion,
            this.ProveedorNombre,
            this.Costo,
            this.Precio,
            this.Cantidad,
            this.TipoProductoId,
            this.ProveedorId});
            this.dbGridDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridDetalle.Location = new System.Drawing.Point(0, 0);
            this.dbGridDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbGridDetalle.Name = "dbGridDetalle";
            this.dbGridDetalle.ReadOnly = true;
            this.dbGridDetalle.RowHeadersWidth = 51;
            this.dbGridDetalle.RowTemplate.Height = 24;
            this.dbGridDetalle.Size = new System.Drawing.Size(1016, 204);
            this.dbGridDetalle.TabIndex = 1;
            this.dbGridDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridDetalle_CellContentClick);
            this.dbGridDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridDetalle_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Inactivo
            // 
            this.Inactivo.DataPropertyName = "Inactivo";
            this.Inactivo.HeaderText = "Inactivo";
            this.Inactivo.MinimumWidth = 6;
            this.Inactivo.Name = "Inactivo";
            this.Inactivo.ReadOnly = true;
            this.Inactivo.Visible = false;
            this.Inactivo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // TipoProductoNombre
            // 
            this.TipoProductoNombre.DataPropertyName = "TipoProductoNombre";
            this.TipoProductoNombre.HeaderText = "Tipo Producto";
            this.TipoProductoNombre.MinimumWidth = 6;
            this.TipoProductoNombre.Name = "TipoProductoNombre";
            this.TipoProductoNombre.ReadOnly = true;
            this.TipoProductoNombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // ProveedorNombre
            // 
            this.ProveedorNombre.DataPropertyName = "ProveedorNombre";
            this.ProveedorNombre.HeaderText = "Proveedor";
            this.ProveedorNombre.MinimumWidth = 6;
            this.ProveedorNombre.Name = "ProveedorNombre";
            this.ProveedorNombre.ReadOnly = true;
            this.ProveedorNombre.Width = 125;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // TipoProductoId
            // 
            this.TipoProductoId.DataPropertyName = "TipoProductoId";
            this.TipoProductoId.HeaderText = "TipoProductoId";
            this.TipoProductoId.MinimumWidth = 6;
            this.TipoProductoId.Name = "TipoProductoId";
            this.TipoProductoId.ReadOnly = true;
            this.TipoProductoId.Visible = false;
            this.TipoProductoId.Width = 125;
            // 
            // ProveedorId
            // 
            this.ProveedorId.DataPropertyName = "ProveedorId";
            this.ProveedorId.HeaderText = "ProveedorId";
            this.ProveedorId.MinimumWidth = 6;
            this.ProveedorId.Name = "ProveedorId";
            this.ProveedorId.ReadOnly = true;
            this.ProveedorId.Visible = false;
            this.ProveedorId.Width = 125;
            // 
            // PanelTituloDetalle
            // 
            this.PanelTituloDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.PanelTituloDetalle.Controls.Add(this.panel3);
            this.PanelTituloDetalle.Controls.Add(this.lblTituloDetalle);
            this.PanelTituloDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloDetalle.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTituloDetalle.Name = "PanelTituloDetalle";
            this.PanelTituloDetalle.Size = new System.Drawing.Size(1016, 46);
            this.PanelTituloDetalle.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(677, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 46);
            this.panel3.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(3, 7);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(99, 31);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 7);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 30);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.White;
            this.lblTituloDetalle.Location = new System.Drawing.Point(11, 7);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(99, 31);
            this.lblTituloDetalle.TabIndex = 0;
            this.lblTituloDetalle.Text = "Detalle";
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.PanelControlBox);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1016, 76);
            this.panelTitulo.TabIndex = 5;
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(963, 0);
            this.PanelControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelControlBox.Name = "PanelControlBox";
            this.PanelControlBox.Size = new System.Drawing.Size(53, 76);
            this.PanelControlBox.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(5, 2);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(36, 175);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 41);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1016, 671);
            this.Controls.Add(this.PanelRoot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelRoot.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.Panel_botones.ResumeLayout(false);
            this.PanelDetalle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridDetalle)).EndInit();
            this.PanelTituloDetalle.ResumeLayout(false);
            this.PanelTituloDetalle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRoot;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkBoxInactivo;
        private Guna.UI2.WinForms.Guna2ComboBox cbProveedor;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoProducto;
        private System.Windows.Forms.Panel Panel_botones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel PanelDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dbGridDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorId;
        private System.Windows.Forms.Panel PanelTituloDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel PanelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
    }
}

