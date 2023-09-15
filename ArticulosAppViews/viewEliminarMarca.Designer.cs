namespace ArticulosAppViews
{
    partial class viewEliminarMarca
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxFormulario = new System.Windows.Forms.PictureBox();
            this.lblEliminarMarca = new System.Windows.Forms.Label();
            this.lblAdvertencia2 = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.lblCancelar.Location = new System.Drawing.Point(302, 357);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(75, 23);
            this.lblCancelar.TabIndex = 75;
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
            this.btnAceptar.Location = new System.Drawing.Point(22, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 74;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(170, 158);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(185, 20);
            this.numericUpDown1.TabIndex = 70;
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblIdMarca.Location = new System.Drawing.Point(19, 158);
            this.lblIdMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(142, 18);
            this.lblIdMarca.TabIndex = 71;
            this.lblIdMarca.Text = "Codigo de Marca";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-3, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 17);
            this.panel3.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PbxFormulario);
            this.panel1.Controls.Add(this.lblEliminarMarca);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 74);
            this.panel1.TabIndex = 68;
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
            // lblEliminarMarca
            // 
            this.lblEliminarMarca.AutoSize = true;
            this.lblEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEliminarMarca.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEliminarMarca.ForeColor = System.Drawing.Color.White;
            this.lblEliminarMarca.Location = new System.Drawing.Point(76, 27);
            this.lblEliminarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEliminarMarca.Name = "lblEliminarMarca";
            this.lblEliminarMarca.Size = new System.Drawing.Size(221, 25);
            this.lblEliminarMarca.TabIndex = 0;
            this.lblEliminarMarca.Text = "ELIMINAR MARCA";
            // 
            // lblAdvertencia2
            // 
            this.lblAdvertencia2.AutoSize = true;
            this.lblAdvertencia2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia2.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia2.Location = new System.Drawing.Point(70, 249);
            this.lblAdvertencia2.Name = "lblAdvertencia2";
            this.lblAdvertencia2.Size = new System.Drawing.Size(278, 14);
            this.lblAdvertencia2.TabIndex = 77;
            this.lblAdvertencia2.Text = "mismo no se podra recuperar en un futuro.";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(-1, 231);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(393, 14);
            this.lblAdvertencia.TabIndex = 76;
            this.lblAdvertencia.Text = "Advertencia: Cuidadoo, al eliminar una marca de la lista, este";
            // 
            // viewEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(390, 396);
            this.Controls.Add(this.lblAdvertencia2);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(406, 435);
            this.MinimumSize = new System.Drawing.Size(406, 435);
            this.Name = "viewEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "viewEliminarMarca";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxFormulario;
        private System.Windows.Forms.Label lblEliminarMarca;
        private System.Windows.Forms.Label lblAdvertencia2;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}