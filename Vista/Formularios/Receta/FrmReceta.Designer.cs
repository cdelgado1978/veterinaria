
namespace Veterinaria.Vista.Formularios.Receta
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
            System.Windows.Forms.Label lblanimalid;
            System.Windows.Forms.Label RazaLabel;
            System.Windows.Forms.Label tipoanimalLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.PanelControlBox = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelForm = new System.Windows.Forms.Panel();
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
            this.Panel_botones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.PanelTituloDetalle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
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
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            lblanimalid = new System.Windows.Forms.Label();
            RazaLabel = new System.Windows.Forms.Label();
            tipoanimalLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.PanelControlBox.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.Panel_botones.SuspendLayout();
            this.PanelTituloDetalle.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblanimalid
            // 
            lblanimalid.AutoSize = true;
            lblanimalid.BackColor = System.Drawing.Color.Transparent;
            lblanimalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblanimalid.Location = new System.Drawing.Point(9, 18);
            lblanimalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblanimalid.Name = "lblanimalid";
            lblanimalid.Size = new System.Drawing.Size(65, 13);
            lblanimalid.TabIndex = 44;
            lblanimalid.Text = "Animal ID:";
            // 
            // RazaLabel
            // 
            RazaLabel.AutoSize = true;
            RazaLabel.BackColor = System.Drawing.Color.Transparent;
            RazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RazaLabel.Location = new System.Drawing.Point(222, 119);
            RazaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            RazaLabel.Name = "RazaLabel";
            RazaLabel.Size = new System.Drawing.Size(40, 13);
            RazaLabel.TabIndex = 67;
            RazaLabel.Text = "Raza:";
            // 
            // tipoanimalLabel
            // 
            tipoanimalLabel.AutoSize = true;
            tipoanimalLabel.BackColor = System.Drawing.Color.Transparent;
            tipoanimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoanimalLabel.Location = new System.Drawing.Point(1, 119);
            tipoanimalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoanimalLabel.Name = "tipoanimalLabel";
            tipoanimalLabel.Size = new System.Drawing.Size(95, 13);
            tipoanimalLabel.TabIndex = 68;
            tipoanimalLabel.Text = "Tipo de Animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(8, 158);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 13);
            label3.TabIndex = 64;
            label3.Text = "Propietario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(175, 17);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 13);
            label2.TabIndex = 62;
            label2.Text = "Edad:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(8, 58);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(54, 13);
            nombreLabel.TabIndex = 60;
            nombreLabel.Text = "Nombre:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.Transparent;
            costoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(1, 88);
            costoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(65, 13);
            costoLabel.TabIndex = 58;
            costoLabel.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(347, 66);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 13);
            label4.TabIndex = 72;
            label4.Text = "Producto ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(342, 100);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 13);
            label5.TabIndex = 75;
            label5.Text = "Nombre producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(399, 132);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 13);
            label6.TabIndex = 76;
            label6.Text = "Dosis:";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.panelTitulo.Controls.Add(this.PanelControlBox);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 62);
            this.panelTitulo.TabIndex = 6;
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(760, 0);
            this.PanelControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.PanelControlBox.Name = "PanelControlBox";
            this.PanelControlBox.Size = new System.Drawing.Size(40, 62);
            this.PanelControlBox.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(4, 2);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recetas";
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
            this.PanelForm.Enabled = false;
            this.PanelForm.Location = new System.Drawing.Point(0, 62);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(2);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(636, 242);
            this.PanelForm.TabIndex = 49;
            // 
            // txtDosis
            // 
            this.txtDosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosis.Location = new System.Drawing.Point(446, 123);
            this.txtDosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDosis.Multiline = true;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(180, 48);
            this.txtDosis.TabIndex = 77;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.Location = new System.Drawing.Point(455, 93);
            this.txtNombrePro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(139, 22);
            this.txtNombrePro.TabIndex = 74;
            // 
            // txtProductoID
            // 
            this.txtProductoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductoID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoID.Location = new System.Drawing.Point(431, 63);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(82, 22);
            this.txtProductoID.TabIndex = 73;
            // 
            // txtPropietario
            // 
            this.txtPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(82, 150);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPropietario.Multiline = true;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(242, 33);
            this.txtPropietario.TabIndex = 71;
            // 
            // txtRaza
            // 
            this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(267, 119);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(88, 22);
            this.txtRaza.TabIndex = 70;
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoAnimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnimal.Location = new System.Drawing.Point(93, 117);
            this.txtTipoAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.Size = new System.Drawing.Size(112, 22);
            this.txtTipoAnimal.TabIndex = 69;
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(216, 9);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(73, 22);
            this.txtEdad.TabIndex = 61;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(77, 80);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 33);
            this.txtDireccion.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(77, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 56;
            // 
            // checkboxinactivo
            // 
            this.checkboxinactivo.BackColor = System.Drawing.Color.Transparent;
            this.checkboxinactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxinactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxinactivo.Location = new System.Drawing.Point(551, 177);
            this.checkboxinactivo.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxinactivo.Name = "checkboxinactivo";
            this.checkboxinactivo.Size = new System.Drawing.Size(78, 19);
            this.checkboxinactivo.TabIndex = 59;
            this.checkboxinactivo.Text = "Inactivo";
            this.checkboxinactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxinactivo.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(79, 9);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(82, 22);
            this.txtNombre.TabIndex = 33;
            // 
            // Panel_botones
            // 
            this.Panel_botones.Controls.Add(this.btnNuevo);
            this.Panel_botones.Controls.Add(this.btnGuardar);
            this.Panel_botones.Location = new System.Drawing.Point(640, 62);
            this.Panel_botones.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_botones.Name = "Panel_botones";
            this.Panel_botones.Size = new System.Drawing.Size(160, 280);
            this.Panel_botones.TabIndex = 48;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(27, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 33);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(27, 82);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PanelTituloDetalle
            // 
            this.PanelTituloDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.PanelTituloDetalle.Controls.Add(this.panel3);
            this.PanelTituloDetalle.Controls.Add(this.lblTituloDetalle);
            this.PanelTituloDetalle.Location = new System.Drawing.Point(0, 262);
            this.PanelTituloDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTituloDetalle.Name = "PanelTituloDetalle";
            this.PanelTituloDetalle.Size = new System.Drawing.Size(798, 40);
            this.PanelTituloDetalle.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(544, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 40);
            this.panel3.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(2, 6);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(80, 26);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(81, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(165, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloDetalle.ForeColor = System.Drawing.Color.White;
            this.lblTituloDetalle.Location = new System.Drawing.Point(8, 6);
            this.lblTituloDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(80, 26);
            this.lblTituloDetalle.TabIndex = 0;
            this.lblTituloDetalle.Text = "Detalle";
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
            this.dbGridDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbGridDetalle.Location = new System.Drawing.Point(0, 298);
            this.dbGridDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dbGridDetalle.Name = "dbGridDetalle";
            this.dbGridDetalle.ReadOnly = true;
            this.dbGridDetalle.RowHeadersWidth = 51;
            this.dbGridDetalle.RowTemplate.Height = 24;
            this.dbGridDetalle.Size = new System.Drawing.Size(800, 152);
            this.dbGridDetalle.TabIndex = 51;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(305, 2);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 13);
            label7.TabIndex = 79;
            label7.Text = "Padecimiento:";
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPadecimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPadecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadecimiento.Location = new System.Drawing.Point(397, 4);
            this.txtPadecimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPadecimiento.Multiline = true;
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(229, 51);
            this.txtPadecimiento.TabIndex = 78;
            // 
            // FrmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbGridDetalle);
            this.Controls.Add(this.PanelTituloDetalle);
            this.Controls.Add(this.Panel_botones);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmReceta";
            this.Text = "FrmReceta";
            this.Load += new System.EventHandler(this.FrmReceta_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelControlBox.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.PanelForm.PerformLayout();
            this.Panel_botones.ResumeLayout(false);
            this.PanelTituloDetalle.ResumeLayout(false);
            this.PanelTituloDetalle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel PanelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel Panel_botones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel PanelTituloDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTituloDetalle;
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
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtTipoAnimal;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkboxinactivo;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtPadecimiento;
    }
}