namespace ArticulosAppViews
{
    partial class viewAgregarImagen
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
            this.labelArticulo = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxAgregarImagenLink = new System.Windows.Forms.TextBox();
            this.labelTotalImagenes = new System.Windows.Forms.Label();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelArticulo
            // 
            this.labelArticulo.AutoSize = true;
            this.labelArticulo.Location = new System.Drawing.Point(400, 70);
            this.labelArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArticulo.Name = "labelArticulo";
            this.labelArticulo.Size = new System.Drawing.Size(0, 14);
            this.labelArticulo.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBoxImagen);
            this.panelContainer.Controls.Add(this.panelControls);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImagen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(800, 295);
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.labelUrl);
            this.panelControls.Controls.Add(this.textBoxAgregarImagenLink);
            this.panelControls.Controls.Add(this.labelTotalImagenes);
            this.panelControls.Controls.Add(this.buttonSiguiente);
            this.panelControls.Controls.Add(this.buttonAnterior);
            this.panelControls.Controls.Add(this.buttonCancelar);
            this.panelControls.Controls.Add(this.buttonConfirmar);
            this.panelControls.Controls.Add(this.buttonAgregarImagen);
            this.panelControls.Controls.Add(this.labelArticulo);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 295);
            this.panelControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(800, 155);
            this.panelControls.TabIndex = 0;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(46, 106);
            this.labelUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(40, 14);
            this.labelUrl.TabIndex = 8;
            this.labelUrl.Text = "URL: ";
            // 
            // textBoxAgregarImagenLink
            // 
            this.textBoxAgregarImagenLink.Location = new System.Drawing.Point(94, 106);
            this.textBoxAgregarImagenLink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAgregarImagenLink.Name = "textBoxAgregarImagenLink";
            this.textBoxAgregarImagenLink.Size = new System.Drawing.Size(289, 22);
            this.textBoxAgregarImagenLink.TabIndex = 0;
            // 
            // labelTotalImagenes
            // 
            this.labelTotalImagenes.AutoSize = true;
            this.labelTotalImagenes.Location = new System.Drawing.Point(336, 5);
            this.labelTotalImagenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalImagenes.Name = "labelTotalImagenes";
            this.labelTotalImagenes.Size = new System.Drawing.Size(59, 14);
            this.labelTotalImagenes.TabIndex = 6;
            this.labelTotalImagenes.Text = "Imagen ";
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(404, 22);
            this.buttonSiguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(100, 25);
            this.buttonSiguiente.TabIndex = 2;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(296, 22);
            this.buttonAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(100, 25);
            this.buttonAnterior.TabIndex = 3;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(679, 106);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 25);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(571, 106);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(100, 25);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Location = new System.Drawing.Point(389, 99);
            this.buttonAgregarImagen.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(36, 32);
            this.buttonAgregarImagen.TabIndex = 1;
            this.buttonAgregarImagen.Text = "+";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // viewAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "viewAgregarImagen";
            this.Text = "Agregar Imagen";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelArticulo;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonAgregarImagen;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Label labelTotalImagenes;
        private System.Windows.Forms.TextBox textBoxAgregarImagenLink;
        private System.Windows.Forms.Label labelUrl;
    }
}