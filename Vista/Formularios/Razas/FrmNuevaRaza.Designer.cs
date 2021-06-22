
namespace Veterinaria.Vista.Formularios.Razas
{
    partial class FrmNuevaRaza
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
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label tipoProductoIdLabel;
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkBoxInactivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRaza = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTipoAnimal = new Guna.UI2.WinForms.Guna2ComboBox();
            costoLabel = new System.Windows.Forms.Label();
            tipoProductoIdLabel = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbTipoAnimal);
            this.guna2GroupBox1.Controls.Add(tipoProductoIdLabel);
            this.guna2GroupBox1.Controls.Add(this.txtRaza);
            this.guna2GroupBox1.Controls.Add(costoLabel);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.chkBoxInactivo);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(488, 396);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Nueva Raza";
            // 
            // chkBoxInactivo
            // 
            this.chkBoxInactivo.BackColor = System.Drawing.Color.White;
            this.chkBoxInactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.Location = new System.Drawing.Point(145, 215);
            this.chkBoxInactivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxInactivo.Name = "chkBoxInactivo";
            this.chkBoxInactivo.Size = new System.Drawing.Size(78, 20);
            this.chkBoxInactivo.TabIndex = 28;
            this.chkBoxInactivo.Text = "Inactivo";
            this.chkBoxInactivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxInactivo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 51);
            this.panel1.TabIndex = 33;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(62, 8);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(355, 8);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 51);
            this.panel2.TabIndex = 27;
            // 
            // txtRaza
            // 
            this.txtRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaza.DefaultText = "";
            this.txtRaza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.DisabledState.Parent = this.txtRaza;
            this.txtRaza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.FocusedState.Parent = this.txtRaza;
            this.txtRaza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaza.HoverState.Parent = this.txtRaza;
            this.txtRaza.Location = new System.Drawing.Point(175, 101);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.PasswordChar = '\0';
            this.txtRaza.PlaceholderText = "";
            this.txtRaza.SelectedText = "";
            this.txtRaza.ShadowDecoration.Parent = this.txtRaza;
            this.txtRaza.Size = new System.Drawing.Size(206, 38);
            this.txtRaza.TabIndex = 34;
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.BackColor = System.Drawing.Color.White;
            costoLabel.Location = new System.Drawing.Point(59, 112);
            costoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(109, 15);
            costoLabel.TabIndex = 37;
            costoLabel.Text = "Nombre de la Raza:";
            // 
            // cbTipoAnimal
            // 
            this.cbTipoAnimal.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoAnimal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAnimal.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoAnimal.FocusedState.Parent = this.cbTipoAnimal;
            this.cbTipoAnimal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipoAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTipoAnimal.FormattingEnabled = true;
            this.cbTipoAnimal.HoverState.Parent = this.cbTipoAnimal;
            this.cbTipoAnimal.ItemHeight = 30;
            this.cbTipoAnimal.ItemsAppearance.Parent = this.cbTipoAnimal;
            this.cbTipoAnimal.Location = new System.Drawing.Point(145, 146);
            this.cbTipoAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoAnimal.Name = "cbTipoAnimal";
            this.cbTipoAnimal.ShadowDecoration.Parent = this.cbTipoAnimal;
            this.cbTipoAnimal.Size = new System.Drawing.Size(236, 36);
            this.cbTipoAnimal.TabIndex = 38;
            // 
            // tipoProductoIdLabel
            // 
            tipoProductoIdLabel.AutoSize = true;
            tipoProductoIdLabel.BackColor = System.Drawing.Color.White;
            tipoProductoIdLabel.Location = new System.Drawing.Point(61, 159);
            tipoProductoIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoProductoIdLabel.Name = "tipoProductoIdLabel";
            tipoProductoIdLabel.Size = new System.Drawing.Size(74, 15);
            tipoProductoIdLabel.TabIndex = 39;
            tipoProductoIdLabel.Text = "Tipo Animal:";
            // 
            // FrmNuevaRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 396);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaRaza";
            this.Text = "FrmNuevaRaza";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.CheckBox chkBoxInactivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtRaza;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipoAnimal;
    }
}