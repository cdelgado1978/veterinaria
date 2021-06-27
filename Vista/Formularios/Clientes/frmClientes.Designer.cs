
namespace Veterinaria.Vista.Formularios.Clientes
{
    partial class frmClientes
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
            System.Windows.Forms.Label lblProvincia;
            System.Windows.Forms.Label lblMunicipio;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label lblTelefono;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.PanelRoot = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkBoxInactivo = new System.Windows.Forms.CheckBox();
            this.cbMunicipio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbProvincia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Panel_botones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PanelDetalle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgGridDetalle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinciaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MunicipioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            lblProvincia = new System.Windows.Forms.Label();
            lblMunicipio = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.PanelRoot.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.Panel_botones.SuspendLayout();
            this.PanelDetalle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridDetalle)).BeginInit();
            this.PanelTituloDetalle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.PanelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.BackColor = System.Drawing.Color.Transparent;
            lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProvincia.Location = new System.Drawing.Point(57, 215);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new System.Drawing.Size(80, 17);
            lblProvincia.TabIndex = 47;
            lblProvincia.Text = "Provincia:";
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.BackColor = System.Drawing.Color.Transparent;
            lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMunicipio.Location = new System.Drawing.Point(57, 255);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new System.Drawing.Size(81, 17);
            lblMunicipio.TabIndex = 46;
            lblMunicipio.Text = "Municipio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(69, 35);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 17);
            nombreLabel.TabIndex = 44;
            nombreLabel.Text = "Nombre:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.Transparent;
            costoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(57, 111);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(81, 17);
            costoLabel.TabIndex = 41;
            costoLabel.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = System.Drawing.Color.Transparent;
            lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefono.Location = new System.Drawing.Point(61, 172);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(77, 17);
            lblTelefono.TabIndex = 40;
            lblTelefono.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(395, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 17);
            label2.TabIndex = 49;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(75, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 17);
            label3.TabIndex = 51;
            label3.Text = "Cedula:";
            // 
            // PanelRoot
            // 
            this.PanelRoot.Controls.Add(this.panelContenido);
            this.PanelRoot.Controls.Add(this.panelTitulo);
            this.PanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoot.Location = new System.Drawing.Point(0, 0);
            this.PanelRoot.Name = "PanelRoot";
            this.PanelRoot.Size = new System.Drawing.Size(1040, 708);
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
            this.panelContenido.Size = new System.Drawing.Size(1040, 632);
            this.panelContenido.TabIndex = 6;
            // 
            // PanelForm
            // 
            this.PanelForm.Controls.Add(label3);
            this.PanelForm.Controls.Add(this.txtCedula);
            this.PanelForm.Controls.Add(label2);
            this.PanelForm.Controls.Add(this.txtApellidos);
            this.PanelForm.Controls.Add(this.txtTelefono);
            this.PanelForm.Controls.Add(lblProvincia);
            this.PanelForm.Controls.Add(this.txtDireccion);
            this.PanelForm.Controls.Add(lblMunicipio);
            this.PanelForm.Controls.Add(nombreLabel);
            this.PanelForm.Controls.Add(this.txtNombre);
            this.PanelForm.Controls.Add(this.chkBoxInactivo);
            this.PanelForm.Controls.Add(this.cbMunicipio);
            this.PanelForm.Controls.Add(this.cbProvincia);
            this.PanelForm.Controls.Add(costoLabel);
            this.PanelForm.Controls.Add(lblTelefono);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Enabled = false;
            this.PanelForm.Location = new System.Drawing.Point(0, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(864, 382);
            this.PanelForm.TabIndex = 48;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(140, 62);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(227, 27);
            this.txtCedula.TabIndex = 50;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(476, 25);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(227, 27);
            this.txtApellidos.TabIndex = 48;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(140, 162);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(227, 27);
            this.txtTelefono.TabIndex = 39;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(140, 99);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(563, 53);
            this.txtDireccion.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(140, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 27);
            this.txtNombre.TabIndex = 33;
            // 
            // chkBoxInactivo
            // 
            this.chkBoxInactivo.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxInactivo.Location = new System.Drawing.Point(405, 276);
            this.chkBoxInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBoxInactivo.Name = "chkBoxInactivo";
            this.chkBoxInactivo.Size = new System.Drawing.Size(104, 23);
            this.chkBoxInactivo.TabIndex = 43;
            this.chkBoxInactivo.Text = "Inactivo";
            this.chkBoxInactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.UseVisualStyleBackColor = false;
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.cbMunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunicipio.FocusedColor = System.Drawing.Color.Empty;
            this.cbMunicipio.FocusedState.Parent = this.cbMunicipio;
            this.cbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.HoverState.Parent = this.cbMunicipio;
            this.cbMunicipio.ItemHeight = 30;
            this.cbMunicipio.ItemsAppearance.Parent = this.cbMunicipio;
            this.cbMunicipio.Location = new System.Drawing.Point(140, 236);
            this.cbMunicipio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.ShadowDecoration.Parent = this.cbMunicipio;
            this.cbMunicipio.Size = new System.Drawing.Size(369, 36);
            this.cbMunicipio.TabIndex = 36;
            // 
            // cbProvincia
            // 
            this.cbProvincia.BackColor = System.Drawing.Color.Transparent;
            this.cbProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FocusedColor = System.Drawing.Color.Empty;
            this.cbProvincia.FocusedState.Parent = this.cbProvincia;
            this.cbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.HoverState.Parent = this.cbProvincia;
            this.cbProvincia.ItemHeight = 30;
            this.cbProvincia.ItemsAppearance.Parent = this.cbProvincia;
            this.cbProvincia.Location = new System.Drawing.Point(140, 196);
            this.cbProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.ShadowDecoration.Parent = this.cbProvincia;
            this.cbProvincia.Size = new System.Drawing.Size(369, 36);
            this.cbProvincia.TabIndex = 35;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // Panel_botones
            // 
            this.Panel_botones.Controls.Add(this.btnBorrar);
            this.Panel_botones.Controls.Add(this.btnEditar);
            this.Panel_botones.Controls.Add(this.btnNuevo);
            this.Panel_botones.Controls.Add(this.btnGuardar);
            this.Panel_botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_botones.Location = new System.Drawing.Point(864, 0);
            this.Panel_botones.Name = "Panel_botones";
            this.Panel_botones.Size = new System.Drawing.Size(176, 382);
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
            this.btnNuevo.Location = new System.Drawing.Point(36, 40);
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
            this.PanelDetalle.Location = new System.Drawing.Point(0, 382);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(1040, 250);
            this.PanelDetalle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgGridDetalle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 205);
            this.panel2.TabIndex = 2;
            // 
            // dgGridDetalle
            // 
            this.dgGridDetalle.AllowUserToAddRows = false;
            this.dgGridDetalle.AllowUserToDeleteRows = false;
            this.dgGridDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.dgGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellidos,
            this.Cedula,
            this.Direccion,
            this.Telefono,
            this.ProvinciaNombre,
            this.MunicipioNombre,
            this.Inactivo,
            this.MunicipioId});
            this.dgGridDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGridDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgGridDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgGridDetalle.Name = "dgGridDetalle";
            this.dgGridDetalle.ReadOnly = true;
            this.dgGridDetalle.RowHeadersWidth = 51;
            this.dgGridDetalle.RowTemplate.Height = 24;
            this.dgGridDetalle.Size = new System.Drawing.Size(1040, 205);
            this.dgGridDetalle.TabIndex = 1;
            this.dgGridDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGridDetalle_CellDoubleClick);
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
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellido";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // ProvinciaNombre
            // 
            this.ProvinciaNombre.DataPropertyName = "ProvinciaNombre";
            this.ProvinciaNombre.HeaderText = "Provincia";
            this.ProvinciaNombre.MinimumWidth = 6;
            this.ProvinciaNombre.Name = "ProvinciaNombre";
            this.ProvinciaNombre.ReadOnly = true;
            this.ProvinciaNombre.Width = 125;
            // 
            // MunicipioNombre
            // 
            this.MunicipioNombre.DataPropertyName = "MunicipioNombre";
            this.MunicipioNombre.HeaderText = "Municipio";
            this.MunicipioNombre.MinimumWidth = 6;
            this.MunicipioNombre.Name = "MunicipioNombre";
            this.MunicipioNombre.ReadOnly = true;
            this.MunicipioNombre.Width = 125;
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
            // MunicipioId
            // 
            this.MunicipioId.DataPropertyName = "MunicipioId";
            this.MunicipioId.HeaderText = "MunicipioId";
            this.MunicipioId.MinimumWidth = 6;
            this.MunicipioId.Name = "MunicipioId";
            this.MunicipioId.ReadOnly = true;
            this.MunicipioId.Visible = false;
            this.MunicipioId.Width = 125;
            // 
            // PanelTituloDetalle
            // 
            this.PanelTituloDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.PanelTituloDetalle.Controls.Add(this.panel3);
            this.PanelTituloDetalle.Controls.Add(this.lblTituloDetalle);
            this.PanelTituloDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTituloDetalle.Location = new System.Drawing.Point(0, 0);
            this.PanelTituloDetalle.Name = "PanelTituloDetalle";
            this.PanelTituloDetalle.Size = new System.Drawing.Size(1040, 45);
            this.PanelTituloDetalle.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(701, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 45);
            this.panel3.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(3, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(99, 31);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(108, 8);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 30);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.White;
            this.lblTituloDetalle.Location = new System.Drawing.Point(10, 7);
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
            this.panelTitulo.Size = new System.Drawing.Size(1040, 76);
            this.panelTitulo.TabIndex = 5;
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(987, 0);
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
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(36, 176);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 41);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 708);
            this.Controls.Add(this.PanelRoot);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.PanelRoot.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.Panel_botones.ResumeLayout(false);
            this.PanelDetalle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridDetalle)).EndInit();
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
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkBoxInactivo;
        private Guna.UI2.WinForms.Guna2ComboBox cbMunicipio;
        private Guna.UI2.WinForms.Guna2ComboBox cbProvincia;
        private System.Windows.Forms.Panel Panel_botones;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel PanelDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgGridDetalle;
        private System.Windows.Forms.Panel PanelTituloDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel PanelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinciaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MunicipioId;
        private System.Windows.Forms.Button btnBorrar;
    }
}