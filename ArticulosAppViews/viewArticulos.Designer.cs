namespace ArticulosAppViews
{
    partial class viewArticulos
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
            this.panelDetails = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelGestor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetails.Location = new System.Drawing.Point(708, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(300, 537);
            this.panelDetails.TabIndex = 0;
            // 
            // flowLayoutPanelGestor
            // 
            this.flowLayoutPanelGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanelGestor.Controls.Add(this.buttonBuscar);
            this.flowLayoutPanelGestor.Controls.Add(this.textBoxBuscar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonFiltrar);
            this.flowLayoutPanelGestor.Controls.Add(this.comboBoxFiltrar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonNuevo);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonModificar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanelGestor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelGestor.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGestor.Name = "flowLayoutPanelGestor";
            this.flowLayoutPanelGestor.Padding = new System.Windows.Forms.Padding(9, 25, 0, 0);
            this.flowLayoutPanelGestor.Size = new System.Drawing.Size(708, 108);
            this.flowLayoutPanelGestor.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(358, 57);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(167, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(185, 57);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(167, 23);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.buttonNuevo.FlatAppearance.BorderSize = 0;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(12, 57);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(167, 23);
            this.buttonNuevo.TabIndex = 4;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = false;
            // 
            // comboBoxFiltrar
            // 
            this.flowLayoutPanelGestor.SetFlowBreak(this.comboBoxFiltrar, true);
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Location = new System.Drawing.Point(531, 28);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(167, 22);
            this.comboBoxFiltrar.TabIndex = 3;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonFiltrar.FlatAppearance.BorderSize = 0;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(450, 28);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(93, 28);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(351, 22);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(12, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridViewArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(0, 108);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.Size = new System.Drawing.Size(708, 429);
            this.dataGridViewArticulos.TabIndex = 1;
            // 
            // viewArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dataGridViewArticulos);
            this.Controls.Add(this.flowLayoutPanelGestor);
            this.Controls.Add(this.panelDetails);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "viewArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.SizeChanged += new System.EventHandler(this.viewArticulos_SizeChanged);
            this.flowLayoutPanelGestor.ResumeLayout(false);
            this.flowLayoutPanelGestor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGestor;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
    }
}