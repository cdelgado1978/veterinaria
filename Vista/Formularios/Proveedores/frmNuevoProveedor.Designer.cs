
namespace Veterinaria.Vista.Formularios.Proveedores
{
    partial class frmNuevoProveedor
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
            System.Windows.Forms.Label tipoProveedorIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label TelefonoLabel;
            this.productoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chkBoxInactivo = new System.Windows.Forms.CheckBox();
            this.cbTipoProveedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBoxProveedor = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            tipoProveedorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            TelefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoProveedorIdLabel
            // 
            tipoProveedorIdLabel.AutoSize = true;
            tipoProveedorIdLabel.BackColor = System.Drawing.Color.White;
            tipoProveedorIdLabel.Location = new System.Drawing.Point(75, 239);
            tipoProveedorIdLabel.Name = "tipoProveedorIdLabel";
            tipoProveedorIdLabel.Size = new System.Drawing.Size(114, 20);
            tipoProveedorIdLabel.TabIndex = 32;
            tipoProveedorIdLabel.Text = "Tipo Proveedor:";
            tipoProveedorIdLabel.Visible = false;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(122, 111);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 29;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(114, 138);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(75, 20);
            descripcionLabel.TabIndex = 27;
            descripcionLabel.Text = "Dirección:";
            // 
            // TelefonoLabel
            // 
            TelefonoLabel.AutoSize = true;
            TelefonoLabel.BackColor = System.Drawing.Color.White;
            TelefonoLabel.Location = new System.Drawing.Point(119, 288);
            TelefonoLabel.Name = "TelefonoLabel";
            TelefonoLabel.Size = new System.Drawing.Size(70, 20);
            TelefonoLabel.TabIndex = 26;
            TelefonoLabel.Text = "Telefono:";
            // 
            // productoDtoBindingSource
            // 
            this.productoDtoBindingSource.DataSource = typeof(Veterinaria.Modelo.DTO.ProductoDto);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Veterinaria.Modelo.Raza);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
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
            // cbTipoProveedor
            // 
            this.cbTipoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoProveedor.FocusedState.Parent = this.cbTipoProveedor;
            this.cbTipoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoProveedor.FormattingEnabled = true;
            this.cbTipoProveedor.HoverState.Parent = this.cbTipoProveedor;
            this.cbTipoProveedor.ItemHeight = 30;
            this.cbTipoProveedor.ItemsAppearance.Parent = this.cbTipoProveedor;
            this.cbTipoProveedor.Location = new System.Drawing.Point(194, 223);
            this.cbTipoProveedor.Name = "cbTipoProveedor";
            this.cbTipoProveedor.ShadowDecoration.Parent = this.cbTipoProveedor;
            this.cbTipoProveedor.Size = new System.Drawing.Size(370, 36);
            this.cbTipoProveedor.TabIndex = 3;
            this.cbTipoProveedor.Visible = false;
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
            this.txtNombre.Location = new System.Drawing.Point(194, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(370, 38);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.Parent = this.txtDireccion;
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.FocusedState.Parent = this.txtDireccion;
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.HoverState.Parent = this.txtDireccion;
            this.txtDireccion.Location = new System.Drawing.Point(194, 138);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.ShadowDecoration.Parent = this.txtDireccion;
            this.txtDireccion.Size = new System.Drawing.Size(370, 74);
            this.txtDireccion.TabIndex = 2;
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.txtTelefono);
            this.groupBoxProveedor.Controls.Add(this.txtDireccion);
            this.groupBoxProveedor.Controls.Add(this.txtNombre);
            this.groupBoxProveedor.Controls.Add(this.cbTipoProveedor);
            this.groupBoxProveedor.Controls.Add(TelefonoLabel);
            this.groupBoxProveedor.Controls.Add(descripcionLabel);
            this.groupBoxProveedor.Controls.Add(this.chkBoxInactivo);
            this.groupBoxProveedor.Controls.Add(nombreLabel);
            this.groupBoxProveedor.Controls.Add(tipoProveedorIdLabel);
            this.groupBoxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxProveedor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.ShadowDecoration.Parent = this.groupBoxProveedor;
            this.groupBoxProveedor.Size = new System.Drawing.Size(651, 388);
            this.groupBoxProveedor.TabIndex = 25;
            this.groupBoxProveedor.Text = "Nuevo Proveedor";
            this.groupBoxProveedor.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.Location = new System.Drawing.Point(194, 267);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(189, 41);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // frmNuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(651, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.productoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productoDtoBindingSource;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxProveedor;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoProveedor;
        private System.Windows.Forms.CheckBox chkBoxInactivo;
    }
}