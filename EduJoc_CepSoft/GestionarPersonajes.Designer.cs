namespace EduJoc_CepSoft
{
    partial class GestionarPersonajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPersonajes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPersonajes = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRutaImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.cmbFiltrarIdioma = new System.Windows.Forms.ComboBox();
            this.panelTbBuscar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFiltrarPersonaje = new System.Windows.Forms.TextBox();
            this.toolStripPersonajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            this.gbFiltrar.SuspendLayout();
            this.panelTbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripPersonajes
            // 
            this.toolStripPersonajes.AutoSize = false;
            this.toolStripPersonajes.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripPersonajes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripButtonSave,
            this.toolStripSeparator,
            this.toolStripButtonExit});
            this.toolStripPersonajes.Location = new System.Drawing.Point(0, 0);
            this.toolStripPersonajes.Name = "toolStripPersonajes";
            this.toolStripPersonajes.Size = new System.Drawing.Size(833, 49);
            this.toolStripPersonajes.TabIndex = 2;
            this.toolStripPersonajes.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.AutoSize = false;
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonAdd.Text = "Añadir Personaje";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.AutoSize = false;
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonEdit.Text = "Modificar Personaje";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.AutoSize = false;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonDelete.Text = "Eliminar ";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonSave.Text = "Guardar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.AutoSize = false;
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonExit.Text = "Salir";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToAddRows = false;
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnaIdioma,
            this.ColumnNombre,
            this.ColumnaImagen,
            this.ColumnaDescripcion,
            this.ColumnRutaImagen});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonajes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPersonajes.EnableHeadersVisualStyles = false;
            this.dgvPersonajes.Location = new System.Drawing.Point(16, 134);
            this.dgvPersonajes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonajes.MultiSelect = false;
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.ReadOnly = true;
            this.dgvPersonajes.RowHeadersWidth = 51;
            this.dgvPersonajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPersonajes.Size = new System.Drawing.Size(801, 364);
            this.dgvPersonajes.TabIndex = 4;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.Frozen = true;
            this.ColumnId.HeaderText = "#";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnId.Width = 50;
            // 
            // ColumnaIdioma
            // 
            this.ColumnaIdioma.DataPropertyName = "idioma";
            this.ColumnaIdioma.Frozen = true;
            this.ColumnaIdioma.HeaderText = "Idioma";
            this.ColumnaIdioma.MinimumWidth = 6;
            this.ColumnaIdioma.Name = "ColumnaIdioma";
            this.ColumnaIdioma.ReadOnly = true;
            this.ColumnaIdioma.Width = 125;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "nombre";
            this.ColumnNombre.Frozen = true;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 125;
            // 
            // ColumnaImagen
            // 
            this.ColumnaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnaImagen.DataPropertyName = "imagen";
            this.ColumnaImagen.HeaderText = "Imagen";
            this.ColumnaImagen.MinimumWidth = 6;
            this.ColumnaImagen.Name = "ColumnaImagen";
            this.ColumnaImagen.ReadOnly = true;
            this.ColumnaImagen.Width = 90;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaDescripcion.DataPropertyName = "descripcion";
            this.ColumnaDescripcion.HeaderText = "Descripción";
            this.ColumnaDescripcion.MinimumWidth = 6;
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            this.ColumnaDescripcion.ReadOnly = true;
            // 
            // ColumnRutaImagen
            // 
            this.ColumnRutaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRutaImagen.DataPropertyName = "rutaImagen";
            this.ColumnRutaImagen.HeaderText = "Ruta imagen";
            this.ColumnRutaImagen.MinimumWidth = 6;
            this.ColumnRutaImagen.Name = "ColumnRutaImagen";
            this.ColumnRutaImagen.ReadOnly = true;
            this.ColumnRutaImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRutaImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnRutaImagen.Visible = false;
            this.ColumnRutaImagen.Width = 508;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.cmbFiltrarIdioma);
            this.gbFiltrar.Controls.Add(this.panelTbBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(16, 53);
            this.gbFiltrar.Margin = new System.Windows.Forms.Padding(5);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Padding = new System.Windows.Forms.Padding(5);
            this.gbFiltrar.Size = new System.Drawing.Size(802, 72);
            this.gbFiltrar.TabIndex = 5;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // cmbFiltrarIdioma
            // 
            this.cmbFiltrarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarIdioma.FormattingEnabled = true;
            this.cmbFiltrarIdioma.Location = new System.Drawing.Point(525, 32);
            this.cmbFiltrarIdioma.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFiltrarIdioma.Name = "cmbFiltrarIdioma";
            this.cmbFiltrarIdioma.Size = new System.Drawing.Size(231, 30);
            this.cmbFiltrarIdioma.TabIndex = 2;
            this.cmbFiltrarIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarIdioma_SelectedIndexChanged);
            // 
            // panelTbBuscar
            // 
            this.panelTbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTbBuscar.BackColor = System.Drawing.Color.White;
            this.panelTbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTbBuscar.Controls.Add(this.pictureBox1);
            this.panelTbBuscar.Controls.Add(this.tbFiltrarPersonaje);
            this.panelTbBuscar.Location = new System.Drawing.Point(9, 32);
            this.panelTbBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.panelTbBuscar.Name = "panelTbBuscar";
            this.panelTbBuscar.Size = new System.Drawing.Size(452, 25);
            this.panelTbBuscar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbFiltrarPersonaje
            // 
            this.tbFiltrarPersonaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltrarPersonaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFiltrarPersonaje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrarPersonaje.Location = new System.Drawing.Point(40, 3);
            this.tbFiltrarPersonaje.Margin = new System.Windows.Forms.Padding(5);
            this.tbFiltrarPersonaje.Name = "tbFiltrarPersonaje";
            this.tbFiltrarPersonaje.Size = new System.Drawing.Size(402, 22);
            this.tbFiltrarPersonaje.TabIndex = 1;
            this.tbFiltrarPersonaje.TextChanged += new System.EventHandler(this.tbFiltrarPersonaje_TextChanged);
            // 
            // GestionarPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.dgvPersonajes);
            this.Controls.Add(this.toolStripPersonajes);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de personajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionarPersonajes_FormClosing);
            this.Load += new System.EventHandler(this.GestionarPersonajes_Load);
            this.toolStripPersonajes.ResumeLayout(false);
            this.toolStripPersonajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            this.gbFiltrar.ResumeLayout(false);
            this.panelTbBuscar.ResumeLayout(false);
            this.panelTbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPersonajes;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.ComboBox cmbFiltrarIdioma;
        private System.Windows.Forms.Panel panelTbBuscar;
        private System.Windows.Forms.TextBox tbFiltrarPersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewImageColumn ColumnaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRutaImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}