﻿namespace ArticulosAppViews
{
    partial class viewAgregarMarca
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
            this.lblCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxFormulario = new System.Windows.Forms.PictureBox();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancelar
            // 
            this.lblCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.lblCancelar.FlatAppearance.BorderSize = 0;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.ForeColor = System.Drawing.Color.White;
            this.lblCancelar.Location = new System.Drawing.Point(304, 357);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(75, 23);
            this.lblCancelar.TabIndex = 2;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.UseVisualStyleBackColor = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(24, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(29, 162);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(333, 73);
            this.textBoxDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 127);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 18);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-1, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 17);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PbxFormulario);
            this.panel1.Controls.Add(this.lblAgregarMarca);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 74);
            this.panel1.TabIndex = 4;
            // 
            // PbxFormulario
            // 
            this.PbxFormulario.BackColor = System.Drawing.Color.Transparent;
            this.PbxFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxFormulario.Image = global::ArticulosAppViews.Properties.Resources.pngwing_com__1_;
            this.PbxFormulario.Location = new System.Drawing.Point(289, 11);
            this.PbxFormulario.Name = "PbxFormulario";
            this.PbxFormulario.Size = new System.Drawing.Size(100, 50);
            this.PbxFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxFormulario.TabIndex = 1;
            this.PbxFormulario.TabStop = false;
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.AutoSize = true;
            this.lblAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAgregarMarca.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.lblAgregarMarca.Location = new System.Drawing.Point(85, 27);
            this.lblAgregarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(214, 25);
            this.lblAgregarMarca.TabIndex = 0;
            this.lblAgregarMarca.Text = "AGREGAR MARCA";
            // 
            // viewAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(390, 396);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(406, 435);
            this.MinimumSize = new System.Drawing.Size(406, 435);
            this.Name = "viewAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "viewAgregarMarca";
            this.Load += new System.EventHandler(this.viewAgregarMarca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxFormulario;
        private System.Windows.Forms.Label lblAgregarMarca;
    }
}