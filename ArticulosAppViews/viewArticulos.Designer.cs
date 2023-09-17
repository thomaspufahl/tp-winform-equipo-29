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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanelGestor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.checkBoxDetails = new System.Windows.Forms.CheckBox();
            this.buttonSiguienteImagen = new System.Windows.Forms.Button();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panelDetailsInformation = new System.Windows.Forms.Panel();
            this.labelDescripcionValue = new System.Windows.Forms.Label();
            this.labelPrecioValue = new System.Windows.Forms.Label();
            this.labelMarcaValue = new System.Windows.Forms.Label();
            this.labelCategoriaValue = new System.Windows.Forms.Label();
            this.labelNombreValue = new System.Windows.Forms.Label();
            this.labelCodigoValue = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonImagenAnterior = new System.Windows.Forms.Button();
            this.labelImagenActual = new System.Windows.Forms.Label();
            this.buttonImagen = new System.Windows.Forms.Button();
            this.flowLayoutPanelGestor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelDetailsInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGestor
            // 
            this.flowLayoutPanelGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanelGestor.Controls.Add(this.buttonBuscar);
            this.flowLayoutPanelGestor.Controls.Add(this.textBoxBuscar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonFiltrar);
            this.flowLayoutPanelGestor.Controls.Add(this.comboBoxFiltrar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonNuevo);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonImagen);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonModificar);
            this.flowLayoutPanelGestor.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanelGestor.Controls.Add(this.checkBoxDetails);
            this.flowLayoutPanelGestor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelGestor.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGestor.Name = "flowLayoutPanelGestor";
            this.flowLayoutPanelGestor.Padding = new System.Windows.Forms.Padding(9, 25, 0, 0);
            this.flowLayoutPanelGestor.Size = new System.Drawing.Size(1008, 108);
            this.flowLayoutPanelGestor.TabIndex = 0;
            this.flowLayoutPanelGestor.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelGestor_Paint);
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
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(93, 28);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(351, 22);
            this.textBoxBuscar.TabIndex = 1;
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
            // comboBoxFiltrar
            // 
            this.flowLayoutPanelGestor.SetFlowBreak(this.comboBoxFiltrar, true);
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Location = new System.Drawing.Point(531, 28);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(167, 22);
            this.comboBoxFiltrar.TabIndex = 3;
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
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Location = new System.Drawing.Point(358, 57);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(167, 23);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(531, 57);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(167, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // checkBoxDetails
            // 
            this.checkBoxDetails.AutoSize = true;
            this.checkBoxDetails.ForeColor = System.Drawing.Color.White;
            this.checkBoxDetails.Location = new System.Drawing.Point(704, 57);
            this.checkBoxDetails.Name = "checkBoxDetails";
            this.checkBoxDetails.Size = new System.Drawing.Size(120, 18);
            this.checkBoxDetails.TabIndex = 7;
            this.checkBoxDetails.Text = "Vista detallada";
            this.checkBoxDetails.UseVisualStyleBackColor = true;
            this.checkBoxDetails.CheckedChanged += new System.EventHandler(this.checkBoxDetails_CheckedChanged);
            // 
            // buttonSiguienteImagen
            // 
            this.buttonSiguienteImagen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSiguienteImagen.Location = new System.Drawing.Point(278, 243);
            this.buttonSiguienteImagen.Name = "buttonSiguienteImagen";
            this.buttonSiguienteImagen.Size = new System.Drawing.Size(35, 23);
            this.buttonSiguienteImagen.TabIndex = 8;
            this.buttonSiguienteImagen.Text = ">";
            this.buttonSiguienteImagen.UseVisualStyleBackColor = true;
            this.buttonSiguienteImagen.Click += new System.EventHandler(this.buttonSiguienteImagen_Click);
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.AllowUserToAddRows = false;
            this.dataGridViewArticulos.AllowUserToDeleteRows = false;
            this.dataGridViewArticulos.AllowUserToResizeColumns = false;
            this.dataGridViewArticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridViewArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArticulos.ColumnHeadersHeight = 35;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticulos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewArticulos.EnableHeadersVisualStyles = false;
            this.dataGridViewArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridViewArticulos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(0, 108);
            this.dataGridViewArticulos.MultiSelect = false;
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewArticulos.RowHeadersVisible = false;
            this.dataGridViewArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(1008, 429);
            this.dataGridViewArticulos.TabIndex = 6;
            this.dataGridViewArticulos.SelectionChanged += new System.EventHandler(this.dataGridViewArticulos_SelectionChanged);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelImagenActual);
            this.panelDetails.Controls.Add(this.buttonImagenAnterior);
            this.panelDetails.Controls.Add(this.buttonSiguienteImagen);
            this.panelDetails.Controls.Add(this.pictureBoxImage);
            this.panelDetails.Controls.Add(this.panelDetailsInformation);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetails.ForeColor = System.Drawing.Color.White;
            this.panelDetails.Location = new System.Drawing.Point(408, 108);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(600, 429);
            this.panelDetails.TabIndex = 7;
            this.panelDetails.Visible = false;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(600, 272);
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // panelDetailsInformation
            // 
            this.panelDetailsInformation.Controls.Add(this.labelDescripcionValue);
            this.panelDetailsInformation.Controls.Add(this.labelPrecioValue);
            this.panelDetailsInformation.Controls.Add(this.labelMarcaValue);
            this.panelDetailsInformation.Controls.Add(this.labelCategoriaValue);
            this.panelDetailsInformation.Controls.Add(this.labelNombreValue);
            this.panelDetailsInformation.Controls.Add(this.labelCodigoValue);
            this.panelDetailsInformation.Controls.Add(this.labelDescripcion);
            this.panelDetailsInformation.Controls.Add(this.labelPrecio);
            this.panelDetailsInformation.Controls.Add(this.labelMarca);
            this.panelDetailsInformation.Controls.Add(this.labelCategoria);
            this.panelDetailsInformation.Controls.Add(this.labelNombre);
            this.panelDetailsInformation.Controls.Add(this.labelCodigo);
            this.panelDetailsInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetailsInformation.Location = new System.Drawing.Point(0, 272);
            this.panelDetailsInformation.Name = "panelDetailsInformation";
            this.panelDetailsInformation.Size = new System.Drawing.Size(600, 157);
            this.panelDetailsInformation.TabIndex = 1;
            // 
            // labelDescripcionValue
            // 
            this.labelDescripcionValue.AutoSize = true;
            this.labelDescripcionValue.Location = new System.Drawing.Point(120, 124);
            this.labelDescripcionValue.Name = "labelDescripcionValue";
            this.labelDescripcionValue.Size = new System.Drawing.Size(0, 14);
            this.labelDescripcionValue.TabIndex = 11;
            // 
            // labelPrecioValue
            // 
            this.labelPrecioValue.AutoSize = true;
            this.labelPrecioValue.Location = new System.Drawing.Point(120, 14);
            this.labelPrecioValue.Name = "labelPrecioValue";
            this.labelPrecioValue.Size = new System.Drawing.Size(0, 14);
            this.labelPrecioValue.TabIndex = 10;
            // 
            // labelMarcaValue
            // 
            this.labelMarcaValue.AutoSize = true;
            this.labelMarcaValue.Location = new System.Drawing.Point(120, 80);
            this.labelMarcaValue.Name = "labelMarcaValue";
            this.labelMarcaValue.Size = new System.Drawing.Size(0, 14);
            this.labelMarcaValue.TabIndex = 9;
            // 
            // labelCategoriaValue
            // 
            this.labelCategoriaValue.AutoSize = true;
            this.labelCategoriaValue.Location = new System.Drawing.Point(120, 102);
            this.labelCategoriaValue.Name = "labelCategoriaValue";
            this.labelCategoriaValue.Size = new System.Drawing.Size(0, 14);
            this.labelCategoriaValue.TabIndex = 8;
            // 
            // labelNombreValue
            // 
            this.labelNombreValue.AutoSize = true;
            this.labelNombreValue.Location = new System.Drawing.Point(120, 58);
            this.labelNombreValue.Name = "labelNombreValue";
            this.labelNombreValue.Size = new System.Drawing.Size(0, 14);
            this.labelNombreValue.TabIndex = 7;
            // 
            // labelCodigoValue
            // 
            this.labelCodigoValue.AutoSize = true;
            this.labelCodigoValue.Location = new System.Drawing.Point(120, 36);
            this.labelCodigoValue.Name = "labelCodigoValue";
            this.labelCodigoValue.Size = new System.Drawing.Size(0, 14);
            this.labelCodigoValue.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(19, 125);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(87, 14);
            this.labelDescripcion.TabIndex = 5;
            this.labelDescripcion.Text = "Descripcíon: ";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(19, 15);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(54, 14);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio: ";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(19, 81);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(53, 14);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca: ";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(19, 103);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(78, 14);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoría: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(19, 59);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 14);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(19, 37);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(60, 14);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código: ";
            // 
            // buttonImagenAnterior
            // 
            this.buttonImagenAnterior.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonImagenAnterior.Location = new System.Drawing.Point(324, 243);
            this.buttonImagenAnterior.Name = "buttonImagenAnterior";
            this.buttonImagenAnterior.Size = new System.Drawing.Size(35, 23);
            this.buttonImagenAnterior.TabIndex = 9;
            this.buttonImagenAnterior.Text = "<";
            this.buttonImagenAnterior.UseVisualStyleBackColor = true;
            this.buttonImagenAnterior.Click += new System.EventHandler(this.buttonImagenAnterior_Click);
            // 
            // labelImagenActual
            // 
            this.labelImagenActual.AutoSize = true;
            this.labelImagenActual.Location = new System.Drawing.Point(242, 226);
            this.labelImagenActual.Name = "labelImagenActual";
            this.labelImagenActual.Size = new System.Drawing.Size(55, 14);
            this.labelImagenActual.TabIndex = 10;
            this.labelImagenActual.Text = "Imagen";
            // 
            // buttonImagen
            // 
            this.buttonImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.buttonImagen.FlatAppearance.BorderSize = 0;
            this.buttonImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImagen.ForeColor = System.Drawing.Color.White;
            this.buttonImagen.Location = new System.Drawing.Point(185, 57);
            this.buttonImagen.Name = "buttonImagen";
            this.buttonImagen.Size = new System.Drawing.Size(167, 23);
            this.buttonImagen.TabIndex = 8;
            this.buttonImagen.Text = "Agregar Imagen";
            this.buttonImagen.UseVisualStyleBackColor = false;
            // 
            // viewArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.dataGridViewArticulos);
            this.Controls.Add(this.flowLayoutPanelGestor);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "viewArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.SizeChanged += new System.EventHandler(this.viewArticulos_SizeChanged);
            this.flowLayoutPanelGestor.ResumeLayout(false);
            this.flowLayoutPanelGestor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelDetailsInformation.ResumeLayout(false);
            this.panelDetailsInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGestor;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.CheckBox checkBoxDetails;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelDetailsInformation;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelDescripcionValue;
        private System.Windows.Forms.Label labelPrecioValue;
        private System.Windows.Forms.Label labelMarcaValue;
        private System.Windows.Forms.Label labelCategoriaValue;
        private System.Windows.Forms.Label labelNombreValue;
        private System.Windows.Forms.Label labelCodigoValue;
        private System.Windows.Forms.Button buttonSiguienteImagen;
        private System.Windows.Forms.Button buttonImagenAnterior;
        private System.Windows.Forms.Label labelImagenActual;
        private System.Windows.Forms.Button buttonImagen;
    }
}