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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPersonajes = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbFiltrarIdioma = new System.Windows.Forms.ComboBox();
            this.panelTbBuscar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFiltrarPersonaje = new System.Windows.Forms.TextBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRutaImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnaIdioma,
            this.ColumnNombre,
            this.ColumnaImagen,
            this.ColumnaDescripcion,
            this.ColumnRutaImagen});
            this.dgvPersonajes.EnableHeadersVisualStyles = false;
            this.dgvPersonajes.Location = new System.Drawing.Point(16, 134);
            this.dgvPersonajes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.ReadOnly = true;
            this.dgvPersonajes.Size = new System.Drawing.Size(801, 364);
            this.dgvPersonajes.TabIndex = 4;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.btnBuscar);
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
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(667, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 25);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFiltrarIdioma
            // 
            this.cmbFiltrarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarIdioma.FormattingEnabled = true;
            this.cmbFiltrarIdioma.Location = new System.Drawing.Point(472, 32);
            this.cmbFiltrarIdioma.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFiltrarIdioma.Name = "cmbFiltrarIdioma";
            this.cmbFiltrarIdioma.Size = new System.Drawing.Size(185, 25);
            this.cmbFiltrarIdioma.TabIndex = 2;
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbFiltrarPersonaje
            // 
            this.tbFiltrarPersonaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltrarPersonaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFiltrarPersonaje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrarPersonaje.Location = new System.Drawing.Point(41, 3);
            this.tbFiltrarPersonaje.Margin = new System.Windows.Forms.Padding(5);
            this.tbFiltrarPersonaje.Name = "tbFiltrarPersonaje";
            this.tbFiltrarPersonaje.Size = new System.Drawing.Size(402, 18);
            this.tbFiltrarPersonaje.TabIndex = 1;
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
            this.ColumnaIdioma.Name = "ColumnaIdioma";
            this.ColumnaIdioma.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "nombre";
            this.ColumnNombre.Frozen = true;
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnaImagen
            // 
            this.ColumnaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnaImagen.DataPropertyName = "imagen";
            this.ColumnaImagen.HeaderText = "Imagen";
            this.ColumnaImagen.Name = "ColumnaImagen";
            this.ColumnaImagen.ReadOnly = true;
            this.ColumnaImagen.Width = 72;
            // 
            // ColumnaDescripcion
            // 
            this.ColumnaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnaDescripcion.DataPropertyName = "descripcion";
            this.ColumnaDescripcion.HeaderText = "Descripción";
            this.ColumnaDescripcion.Name = "ColumnaDescripcion";
            this.ColumnaDescripcion.ReadOnly = true;
            // 
            // ColumnRutaImagen
            // 
            this.ColumnRutaImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRutaImagen.DataPropertyName = "rutaImagen";
            this.ColumnRutaImagen.HeaderText = "Ruta imagen";
            this.ColumnRutaImagen.Name = "ColumnRutaImagen";
            this.ColumnRutaImagen.ReadOnly = true;
            this.ColumnRutaImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRutaImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnRutaImagen.Visible = false;
            this.ColumnRutaImagen.Width = 508;
            // 
            // GestionarPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
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
            this.Text = "Gestionar Personajes";
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbFiltrarIdioma;
        private System.Windows.Forms.Panel panelTbBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFiltrarPersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewImageColumn ColumnaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRutaImagen;
    }
}