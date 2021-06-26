
namespace Veterinaria.Vista.Formularios.Recetas
{
    partial class FrmReceta
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label RazaLabel;
            System.Windows.Forms.Label tipoanimalLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label lblanimalid;
            this.PanelRoot = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
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
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtTipoAnimal = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkboxinactivo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            RazaLabel = new System.Windows.Forms.Label();
            tipoanimalLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            lblanimalid = new System.Windows.Forms.Label();
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
            // PanelRoot
            // 
            this.PanelRoot.Controls.Add(this.panelContenido);
            this.PanelRoot.Controls.Add(this.panelTitulo);
            this.PanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoot.Location = new System.Drawing.Point(0, 0);
            this.PanelRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelRoot.Name = "PanelRoot";
            this.PanelRoot.Size = new System.Drawing.Size(1067, 697);
            this.PanelRoot.TabIndex = 1;
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
            this.panelContenido.Size = new System.Drawing.Size(1067, 621);
            this.panelContenido.TabIndex = 6;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(label7);
            this.PanelForm.Controls.Add(this.txtPadecimiento);
            this.PanelForm.Controls.Add(this.txtDosis);
            this.PanelForm.Controls.Add(label6);
            this.PanelForm.Controls.Add(label5);
            this.PanelForm.Controls.Add(this.txtNombrePro);
            this.PanelForm.Controls.Add(this.txtProductoID);
            this.PanelForm.Controls.Add(label4);
            this.PanelForm.Controls.Add(this.txtPropietario);
            this.PanelForm.Controls.Add(this.txtRaza);
            this.PanelForm.Controls.Add(this.txtTipoAnimal);
            this.PanelForm.Controls.Add(RazaLabel);
            this.PanelForm.Controls.Add(tipoanimalLabel);
            this.PanelForm.Controls.Add(label3);
            this.PanelForm.Controls.Add(label2);
            this.PanelForm.Controls.Add(this.txtEdad);
            this.PanelForm.Controls.Add(this.txtDireccion);
            this.PanelForm.Controls.Add(nombreLabel);
            this.PanelForm.Controls.Add(this.textBox1);
            this.PanelForm.Controls.Add(this.checkboxinactivo);
            this.PanelForm.Controls.Add(costoLabel);
            this.PanelForm.Controls.Add(lblanimalid);
            this.PanelForm.Controls.Add(this.txtNombre);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Enabled = false;
            this.PanelForm.Location = new System.Drawing.Point(0, 0);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(891, 371);
            this.PanelForm.TabIndex = 48;
            // 
            // Panel_botones
            // 
            this.Panel_botones.Controls.Add(this.btnEditar);
            this.Panel_botones.Controls.Add(this.btnNuevo);
            this.Panel_botones.Controls.Add(this.btnGuardar);
            this.Panel_botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_botones.Location = new System.Drawing.Point(891, 0);
            this.Panel_botones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_botones.Name = "Panel_botones";
            this.Panel_botones.Size = new System.Drawing.Size(176, 371);
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
            // 
            // PanelDetalle
            // 
            this.PanelDetalle.Controls.Add(this.panel2);
            this.PanelDetalle.Controls.Add(this.PanelTituloDetalle);
            this.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDetalle.Location = new System.Drawing.Point(0, 371);
            this.PanelDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(1067, 250);
            this.PanelDetalle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dbGridDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 204);
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
            this.dbGridDetalle.Size = new System.Drawing.Size(1067, 204);
            this.dbGridDetalle.TabIndex = 1;
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
            this.PanelTituloDetalle.Size = new System.Drawing.Size(1067, 46);
            this.PanelTituloDetalle.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(728, 0);
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
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.panelTitulo.Controls.Add(this.PanelControlBox);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1067, 76);
            this.panelTitulo.TabIndex = 5;
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(1014, 0);
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
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recetas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(432, 66);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(110, 17);
            label7.TabIndex = 125;
            label7.Text = "Padecimiento:";
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPadecimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPadecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadecimiento.Location = new System.Drawing.Point(554, 69);
            this.txtPadecimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPadecimiento.Multiline = true;
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(305, 63);
            this.txtPadecimiento.TabIndex = 124;
            // 
            // txtDosis
            // 
            this.txtDosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosis.Location = new System.Drawing.Point(620, 215);
            this.txtDosis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDosis.Multiline = true;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(240, 59);
            this.txtDosis.TabIndex = 123;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(557, 226);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 17);
            label6.TabIndex = 122;
            label6.Text = "Dosis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(481, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(138, 17);
            label5.TabIndex = 121;
            label5.Text = "Nombre producto:";
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.Location = new System.Drawing.Point(632, 178);
            this.txtNombrePro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(185, 27);
            this.txtNombrePro.TabIndex = 120;
            // 
            // txtProductoID
            // 
            this.txtProductoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductoID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoID.Location = new System.Drawing.Point(600, 142);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(109, 27);
            this.txtProductoID.TabIndex = 119;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(488, 145);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 17);
            label4.TabIndex = 118;
            label4.Text = "Producto ID:";
            // 
            // txtPropietario
            // 
            this.txtPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(134, 249);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPropietario.Multiline = true;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(323, 41);
            this.txtPropietario.TabIndex = 117;
            // 
            // txtRaza
            // 
            this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(381, 210);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(117, 27);
            this.txtRaza.TabIndex = 116;
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoAnimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnimal.Location = new System.Drawing.Point(149, 208);
            this.txtTipoAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.Size = new System.Drawing.Size(149, 27);
            this.txtTipoAnimal.TabIndex = 115;
            // 
            // RazaLabel
            // 
            RazaLabel.AutoSize = true;
            RazaLabel.BackColor = System.Drawing.Color.Transparent;
            RazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RazaLabel.Location = new System.Drawing.Point(321, 210);
            RazaLabel.Name = "RazaLabel";
            RazaLabel.Size = new System.Drawing.Size(50, 17);
            RazaLabel.TabIndex = 113;
            RazaLabel.Text = "Raza:";
            // 
            // tipoanimalLabel
            // 
            tipoanimalLabel.AutoSize = true;
            tipoanimalLabel.BackColor = System.Drawing.Color.Transparent;
            tipoanimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoanimalLabel.Location = new System.Drawing.Point(26, 210);
            tipoanimalLabel.Name = "tipoanimalLabel";
            tipoanimalLabel.Size = new System.Drawing.Size(121, 17);
            tipoanimalLabel.TabIndex = 114;
            tipoanimalLabel.Text = "Tipo de Animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(36, 258);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 17);
            label3.TabIndex = 112;
            label3.Text = "Propietario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(258, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 17);
            label2.TabIndex = 111;
            label2.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(313, 75);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(97, 27);
            this.txtEdad.TabIndex = 110;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(128, 162);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(283, 41);
            this.txtDireccion.TabIndex = 106;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(36, 135);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 17);
            nombreLabel.TabIndex = 109;
            nombreLabel.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 105;
            // 
            // checkboxinactivo
            // 
            this.checkboxinactivo.BackColor = System.Drawing.Color.Transparent;
            this.checkboxinactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxinactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxinactivo.Location = new System.Drawing.Point(760, 282);
            this.checkboxinactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxinactivo.Name = "checkboxinactivo";
            this.checkboxinactivo.Size = new System.Drawing.Size(104, 23);
            this.checkboxinactivo.TabIndex = 108;
            this.checkboxinactivo.Text = "Inactivo";
            this.checkboxinactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxinactivo.UseVisualStyleBackColor = false;
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.Transparent;
            costoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(26, 172);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(81, 17);
            costoLabel.TabIndex = 107;
            costoLabel.Text = "Direccion:";
            // 
            // lblanimalid
            // 
            lblanimalid.AutoSize = true;
            lblanimalid.BackColor = System.Drawing.Color.Transparent;
            lblanimalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblanimalid.Location = new System.Drawing.Point(37, 86);
            lblanimalid.Name = "lblanimalid";
            lblanimalid.Size = new System.Drawing.Size(81, 17);
            lblanimalid.TabIndex = 104;
            lblanimalid.Text = "Animal ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(130, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 27);
            this.txtNombre.TabIndex = 103;
            // 
            // FrmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 697);
            this.Controls.Add(this.PanelRoot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReceta";
            this.Text = "FrmReceta";
            this.Load += new System.EventHandler(this.FrmReceta_Load);
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
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtTipoAnimal;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkboxinactivo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}