
using System;
using System.Windows.Forms;

namespace Veterinaria.Vista.Tipo_Animal
{
    partial class TipoAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dgListaTiposAnimal = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.PanelControlBox.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTiposAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.panelTitulo.Controls.Add(this.PanelControlBox);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.btnNuevoProducto);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(715, 62);
            this.panelTitulo.TabIndex = 4;
            
            // 
            // PanelControlBox
            // 
            this.PanelControlBox.Controls.Add(this.guna2ControlBox1);
            this.PanelControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControlBox.Location = new System.Drawing.Point(675, 0);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Animales";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Location = new System.Drawing.Point(10, 38);
            this.btnNuevoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(146, 24);
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.Text = "Nuevo Tipo de animal";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(162)))), ((int)(((byte)(130)))));
            this.panelContenido.Controls.Add(this.dgListaTiposAnimal);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 62);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(715, 415);
            this.panelContenido.TabIndex = 5;
            // 
            // dgListaTiposAnimal
            // 
            this.dgListaTiposAnimal.AllowUserToAddRows = false;
            this.dgListaTiposAnimal.AllowUserToDeleteRows = false;
            this.dgListaTiposAnimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(230)))), ((int)(((byte)(222)))));
            this.dgListaTiposAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaTiposAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListaTiposAnimal.Location = new System.Drawing.Point(0, 0);
            this.dgListaTiposAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.dgListaTiposAnimal.Name = "dgListaTiposAnimal";
            this.dgListaTiposAnimal.ReadOnly = true;
            this.dgListaTiposAnimal.RowHeadersWidth = 51;
            this.dgListaTiposAnimal.RowTemplate.Height = 24;
            this.dgListaTiposAnimal.Size = new System.Drawing.Size(715, 415);
            this.dgListaTiposAnimal.TabIndex = 0;
            // 
            // TipoAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 477);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTitulo);
            this.Name = "TipoAnimal";
            this.Text = "TipoAnimal";
            this.Load += new System.EventHandler(this.TipoAnimal_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.PanelControlBox.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTiposAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel PanelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridView dgListaTiposAnimal;
        private PaintEventHandler panelTitulo_Paint;
    }
}