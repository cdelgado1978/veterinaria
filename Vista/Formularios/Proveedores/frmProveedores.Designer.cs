
namespace Veterinaria.Formularios.Proveedores
{
    partial class frmProveedores
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.PanelControlBox = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTituloProveedores = new System.Windows.Forms.Label();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.PanelControlBox.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.panelTitulo.Controls.Add(this.PanelControlBox);
            this.panelTitulo.Controls.Add(this.lblTituloProveedores);
            this.panelTitulo.Controls.Add(this.btnNuevoProducto);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(965, 76);
            this.panelTitulo.TabIndex = 0;
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(912, 0);
            this.PanelControlBox.Name = "PanelControlBox";
            this.PanelControlBox.Size = new System.Drawing.Size(53, 76);
            this.PanelControlBox.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(5, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // lblTituloProveedores
            // 
            this.lblTituloProveedores.AutoSize = true;
            this.lblTituloProveedores.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedores.Location = new System.Drawing.Point(12, 9);
            this.lblTituloProveedores.Name = "lblTituloProveedores";
            this.lblTituloProveedores.Size = new System.Drawing.Size(207, 41);
            this.lblTituloProveedores.TabIndex = 4;
            this.lblTituloProveedores.Text = "Proveedores";
            this.lblTituloProveedores.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Location = new System.Drawing.Point(13, 44);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(125, 29);
            this.btnNuevoProducto.TabIndex = 3;
            this.btnNuevoProducto.Text = "Nuevo Proveedor";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.dgProveedores);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 76);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(965, 524);
            this.panelContenido.TabIndex = 1;
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.RowTemplate.Height = 24;
            this.dgProveedores.Size = new System.Drawing.Size(965, 524);
            this.dgProveedores.TabIndex = 0;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 600);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTitulo);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelControlBox.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblTituloProveedores;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel PanelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView dgProveedores;
    }
}