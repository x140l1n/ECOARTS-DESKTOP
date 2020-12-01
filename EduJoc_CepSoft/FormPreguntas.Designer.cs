
namespace EduJoc_CepSoft
{
    partial class FormPreguntas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreguntas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnAnadir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.cmbFiltrarTema = new System.Windows.Forms.ComboBox();
            this.cmbFiltrarIdioma = new System.Windows.Forms.ComboBox();
            this.panelTbBuscar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFiltrarPregunta = new System.Windows.Forms.TextBox();
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripPrincipal.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.panelTbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAnadir,
            this.btnEditar,
            this.btnEliminar,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(913, 37);
            this.toolStripPrincipal.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAnadir.Image")));
            this.btnAnadir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(34, 34);
            this.btnAnadir.Text = "Añadir pregunta";
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.Text = "Editar pregunta";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 34);
            this.btnEliminar.Text = "Eliminar preguntas";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 34);
            this.btnGuardar.Text = "Guardar preguntas";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 34);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrar.Controls.Add(this.cmbFiltrarTema);
            this.gbFiltrar.Controls.Add(this.cmbFiltrarIdioma);
            this.gbFiltrar.Controls.Add(this.panelTbBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(13, 50);
            this.gbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiltrar.Size = new System.Drawing.Size(885, 63);
            this.gbFiltrar.TabIndex = 1;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // cmbFiltrarTema
            // 
            this.cmbFiltrarTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarTema.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarTema.FormattingEnabled = true;
            this.cmbFiltrarTema.Location = new System.Drawing.Point(584, 26);
            this.cmbFiltrarTema.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltrarTema.Name = "cmbFiltrarTema";
            this.cmbFiltrarTema.Size = new System.Drawing.Size(197, 30);
            this.cmbFiltrarTema.TabIndex = 3;
            this.cmbFiltrarTema.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarTema_SelectedIndexChanged);
            // 
            // cmbFiltrarIdioma
            // 
            this.cmbFiltrarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarIdioma.FormattingEnabled = true;
            this.cmbFiltrarIdioma.Location = new System.Drawing.Point(348, 27);
            this.cmbFiltrarIdioma.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltrarIdioma.Name = "cmbFiltrarIdioma";
            this.cmbFiltrarIdioma.Size = new System.Drawing.Size(197, 30);
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
            this.panelTbBuscar.Controls.Add(this.tbFiltrarPregunta);
            this.panelTbBuscar.Location = new System.Drawing.Point(7, 26);
            this.panelTbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTbBuscar.Name = "panelTbBuscar";
            this.panelTbBuscar.Size = new System.Drawing.Size(314, 26);
            this.panelTbBuscar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbFiltrarPregunta
            // 
            this.tbFiltrarPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltrarPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFiltrarPregunta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrarPregunta.Location = new System.Drawing.Point(31, 3);
            this.tbFiltrarPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.tbFiltrarPregunta.Name = "tbFiltrarPregunta";
            this.tbFiltrarPregunta.Size = new System.Drawing.Size(276, 22);
            this.tbFiltrarPregunta.TabIndex = 1;
            this.tbFiltrarPregunta.TextChanged += new System.EventHandler(this.tbFiltrarPregunta_TextChanged);
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.AllowUserToAddRows = false;
            this.dgvPreguntas.AllowUserToDeleteRows = false;
            this.dgvPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnaIdioma,
            this.columnTema,
            this.columnPregunta});
            this.dgvPreguntas.EnableHeadersVisualStyles = false;
            this.dgvPreguntas.Location = new System.Drawing.Point(13, 121);
            this.dgvPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPreguntas.MultiSelect = false;
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.RowHeadersWidth = 51;
            this.dgvPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPreguntas.Size = new System.Drawing.Size(885, 593);
            this.dgvPreguntas.TabIndex = 2;
            this.dgvPreguntas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreguntas_CellDoubleClick);
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.Frozen = true;
            this.columnId.HeaderText = "#";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnId.Width = 50;
            // 
            // columnaIdioma
            // 
            this.columnaIdioma.DataPropertyName = "idioma";
            this.columnaIdioma.HeaderText = "Idioma";
            this.columnaIdioma.MinimumWidth = 6;
            this.columnaIdioma.Name = "columnaIdioma";
            this.columnaIdioma.ReadOnly = true;
            this.columnaIdioma.Width = 125;
            // 
            // columnTema
            // 
            this.columnTema.DataPropertyName = "tema";
            this.columnTema.HeaderText = "Tema";
            this.columnTema.MinimumWidth = 6;
            this.columnTema.Name = "columnTema";
            this.columnTema.ReadOnly = true;
            this.columnTema.Width = 125;
            // 
            // columnPregunta
            // 
            this.columnPregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPregunta.DataPropertyName = "pregunta";
            this.columnPregunta.HeaderText = "Pregunta";
            this.columnPregunta.MinimumWidth = 6;
            this.columnPregunta.Name = "columnPregunta";
            this.columnPregunta.ReadOnly = true;
            // 
            // FormPreguntas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 730);
            this.Controls.Add(this.dgvPreguntas);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.toolStripPrincipal);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de preguntas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.panelTbBuscar.ResumeLayout(false);
            this.panelTbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton btnAnadir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Panel panelTbBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFiltrarPregunta;
        private System.Windows.Forms.ComboBox cmbFiltrarTema;
        private System.Windows.Forms.ComboBox cmbFiltrarIdioma;
        private System.Windows.Forms.DataGridView dgvPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPregunta;
    }
}

