namespace ArticulosAppViews
{
    partial class viewAdvertencia
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.butonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(13, 98);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(88, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // butonCancelar
            // 
            this.butonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.butonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butonCancelar.FlatAppearance.BorderSize = 0;
            this.butonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonCancelar.ForeColor = System.Drawing.Color.White;
            this.butonCancelar.Location = new System.Drawing.Point(221, 98);
            this.butonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butonCancelar.Name = "butonCancelar";
            this.butonCancelar.Size = new System.Drawing.Size(88, 23);
            this.butonCancelar.TabIndex = 2;
            this.butonCancelar.Text = "Cancelar";
            this.butonCancelar.UseVisualStyleBackColor = false;
            this.butonCancelar.Click += new System.EventHandler(this.butonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Seguro que quieres realizar esta operacion?";
            // 
            // viewAdvertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(322, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "viewAdvertencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "viewAdvertencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button butonCancelar;
        private System.Windows.Forms.Label label1;
    }
}