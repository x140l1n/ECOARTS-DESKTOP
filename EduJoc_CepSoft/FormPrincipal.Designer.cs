﻿
namespace EduJoc_CepSoft
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnAnadir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPersonajes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbFiltrarTema = new System.Windows.Forms.ComboBox();
            this.cmbFiltrarIdioma = new System.Windows.Forms.ComboBox();
            this.panelTbBuscar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFiltrarPregunta = new System.Windows.Forms.TextBox();
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnPersonajes,
            this.toolStripSeparator2,
            this.btnSalir});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(783, 37);
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
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.Text = "Editar pregunta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 34);
            this.btnEliminar.Text = "Eliminar preguntas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 34);
            this.btnGuardar.Text = "Guardar preguntas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPersonajes.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonajes.Image")));
            this.btnPersonajes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(34, 34);
            this.btnPersonajes.Text = "Gestionar personajes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
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
            this.gbFiltrar.Controls.Add(this.btnBuscar);
            this.gbFiltrar.Controls.Add(this.cmbFiltrarTema);
            this.gbFiltrar.Controls.Add(this.cmbFiltrarIdioma);
            this.gbFiltrar.Controls.Add(this.panelTbBuscar);
            this.gbFiltrar.Location = new System.Drawing.Point(12, 49);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(759, 57);
            this.gbFiltrar.TabIndex = 1;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(674, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 25);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFiltrarTema
            // 
            this.cmbFiltrarTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarTema.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarTema.FormattingEnabled = true;
            this.cmbFiltrarTema.Location = new System.Drawing.Point(409, 21);
            this.cmbFiltrarTema.Name = "cmbFiltrarTema";
            this.cmbFiltrarTema.Size = new System.Drawing.Size(121, 25);
            this.cmbFiltrarTema.TabIndex = 3;
            // 
            // cmbFiltrarIdioma
            // 
            this.cmbFiltrarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltrarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarIdioma.FormattingEnabled = true;
            this.cmbFiltrarIdioma.Items.AddRange(new object[] {
            "Castellano",
            "Catalán",
            "Inglés"});
            this.cmbFiltrarIdioma.Location = new System.Drawing.Point(282, 21);
            this.cmbFiltrarIdioma.Name = "cmbFiltrarIdioma";
            this.cmbFiltrarIdioma.Size = new System.Drawing.Size(121, 25);
            this.cmbFiltrarIdioma.TabIndex = 2;
            // 
            // panelTbBuscar
            // 
            this.panelTbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTbBuscar.BackColor = System.Drawing.Color.White;
            this.panelTbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTbBuscar.Controls.Add(this.pictureBox1);
            this.panelTbBuscar.Controls.Add(this.tbFiltrarPregunta);
            this.panelTbBuscar.Location = new System.Drawing.Point(6, 20);
            this.panelTbBuscar.Name = "panelTbBuscar";
            this.panelTbBuscar.Size = new System.Drawing.Size(270, 26);
            this.panelTbBuscar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
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
            this.tbFiltrarPregunta.Location = new System.Drawing.Point(28, 3);
            this.tbFiltrarPregunta.Name = "tbFiltrarPregunta";
            this.tbFiltrarPregunta.Size = new System.Drawing.Size(237, 18);
            this.tbFiltrarPregunta.TabIndex = 1;
            this.tbFiltrarPregunta.Text = "Buscar pregunta...";
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.AllowUserToAddRows = false;
            this.dgvPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnIdioma,
            this.columnTema,
            this.columnPregunta});
            this.dgvPreguntas.EnableHeadersVisualStyles = false;
            this.dgvPreguntas.Location = new System.Drawing.Point(12, 112);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.Size = new System.Drawing.Size(759, 434);
            this.dgvPreguntas.TabIndex = 2;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.Frozen = true;
            this.columnId.HeaderText = "#";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnId.Width = 50;
            // 
            // columnIdioma
            // 
            this.columnIdioma.DataPropertyName = "idioma";
            this.columnIdioma.HeaderText = "Idioma";
            this.columnIdioma.Name = "columnIdioma";
            this.columnIdioma.ReadOnly = true;
            // 
            // columnTema
            // 
            this.columnTema.DataPropertyName = "tema";
            this.columnTema.HeaderText = "Tema";
            this.columnTema.Name = "columnTema";
            this.columnTema.ReadOnly = true;
            // 
            // columnPregunta
            // 
            this.columnPregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPregunta.DataPropertyName = "pregunta";
            this.columnPregunta.HeaderText = "Pregunta";
            this.columnPregunta.Name = "columnPregunta";
            this.columnPregunta.ReadOnly = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 558);
            this.Controls.Add(this.dgvPreguntas);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.toolStripPrincipal);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
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
        private System.Windows.Forms.ToolStripButton btnPersonajes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.Panel panelTbBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFiltrarPregunta;
        private System.Windows.Forms.ComboBox cmbFiltrarTema;
        private System.Windows.Forms.ComboBox cmbFiltrarIdioma;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPregunta;
    }
}

