namespace ArticulosAppViews
{
    partial class viewMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonCategorias = new System.Windows.Forms.Button();
            this.buttonMarcas = new System.Windows.Forms.Button();
            this.buttonArticulos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWindowTitle = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelWindows = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelWindowTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.labelLogo);
            this.panelMenu.Controls.Add(this.buttonSalir);
            this.panelMenu.Controls.Add(this.buttonCategorias);
            this.panelMenu.Controls.Add(this.buttonMarcas);
            this.panelMenu.Controls.Add(this.buttonArticulos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 609);
            this.panelMenu.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.labelLogo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(22, 29);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(193, 29);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Artículos App";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.buttonSalir.Location = new System.Drawing.Point(0, 544);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonSalir.Size = new System.Drawing.Size(240, 65);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonCategorias
            // 
            this.buttonCategorias.FlatAppearance.BorderSize = 0;
            this.buttonCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategorias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.buttonCategorias.Location = new System.Drawing.Point(0, 339);
            this.buttonCategorias.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonCategorias.Name = "buttonCategorias";
            this.buttonCategorias.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonCategorias.Size = new System.Drawing.Size(240, 65);
            this.buttonCategorias.TabIndex = 2;
            this.buttonCategorias.Text = "Categorías";
            this.buttonCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategorias.UseVisualStyleBackColor = true;
            this.buttonCategorias.Click += new System.EventHandler(this.buttonCategorias_Click);
            // 
            // buttonMarcas
            // 
            this.buttonMarcas.FlatAppearance.BorderSize = 0;
            this.buttonMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.buttonMarcas.Location = new System.Drawing.Point(0, 267);
            this.buttonMarcas.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonMarcas.Name = "buttonMarcas";
            this.buttonMarcas.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonMarcas.Size = new System.Drawing.Size(240, 65);
            this.buttonMarcas.TabIndex = 1;
            this.buttonMarcas.Text = "Marcas";
            this.buttonMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMarcas.UseVisualStyleBackColor = true;
            this.buttonMarcas.Click += new System.EventHandler(this.buttonMarcas_Click);
            // 
            // buttonArticulos
            // 
            this.buttonArticulos.FlatAppearance.BorderSize = 0;
            this.buttonArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArticulos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.buttonArticulos.Location = new System.Drawing.Point(0, 193);
            this.buttonArticulos.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonArticulos.Name = "buttonArticulos";
            this.buttonArticulos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.buttonArticulos.Size = new System.Drawing.Size(240, 65);
            this.buttonArticulos.TabIndex = 0;
            this.buttonArticulos.Text = "Artículos";
            this.buttonArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArticulos.UseVisualStyleBackColor = true;
            this.buttonArticulos.Click += new System.EventHandler(this.buttonArticulos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 85);
            this.panelLogo.TabIndex = 5;
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.panelWindowTitle.Controls.Add(this.labelWindowTitle);
            this.panelWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWindowTitle.Location = new System.Drawing.Point(240, 0);
            this.panelWindowTitle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.Size = new System.Drawing.Size(1024, 85);
            this.panelWindowTitle.TabIndex = 1;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.AutoSize = true;
            this.labelWindowTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowTitle.ForeColor = System.Drawing.Color.White;
            this.labelWindowTitle.Location = new System.Drawing.Point(25, 29);
            this.labelWindowTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(82, 25);
            this.labelWindowTitle.TabIndex = 0;
            this.labelWindowTitle.Text = "HOME";
            this.labelWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWindows
            // 
            this.panelWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindows.Location = new System.Drawing.Point(240, 85);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(1024, 524);
            this.panelWindows.TabIndex = 3;
            // 
            // viewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 609);
            this.Controls.Add(this.panelWindows);
            this.Controls.Add(this.panelWindowTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimumSize = new System.Drawing.Size(1280, 648);
            this.Name = "viewMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos App";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelWindowTitle.ResumeLayout(false);
            this.panelWindowTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonArticulos;
        private System.Windows.Forms.Button buttonMarcas;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonCategorias;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelWindowTitle;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Panel panelWindows;
    }
}

