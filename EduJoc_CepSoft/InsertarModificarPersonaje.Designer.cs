namespace EduJoc_CepSoft
{
    partial class InsertarModificarPersonaje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarModificarPersonaje));
            this.lblDescCatalan = new System.Windows.Forms.Label();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.btnInsertarModificar = new System.Windows.Forms.Button();
            this.picboxImagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescCatalan
            // 
            this.lblDescCatalan.AutoSize = true;
            this.lblDescCatalan.Location = new System.Drawing.Point(396, 75);
            this.lblDescCatalan.Name = "lblDescCatalan";
            this.lblDescCatalan.Size = new System.Drawing.Size(70, 14);
            this.lblDescCatalan.TabIndex = 15;
            this.lblDescCatalan.Text = "Descripción: ";
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDescripcion.Location = new System.Drawing.Point(399, 106);
            this.txtboxDescripcion.Multiline = true;
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(350, 292);
            this.txtboxDescripcion.TabIndex = 17;
            // 
            // btnInsertarModificar
            // 
            this.btnInsertarModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertarModificar.Location = new System.Drawing.Point(654, 417);
            this.btnInsertarModificar.Name = "btnInsertarModificar";
            this.btnInsertarModificar.Size = new System.Drawing.Size(95, 25);
            this.btnInsertarModificar.TabIndex = 22;
            this.btnInsertarModificar.Text = "Insertar";
            this.btnInsertarModificar.UseVisualStyleBackColor = true;
            this.btnInsertarModificar.Click += new System.EventHandler(this.btnInsertarModificar_Click);
            // 
            // picboxImagen
            // 
            this.picboxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picboxImagen.Location = new System.Drawing.Point(12, 106);
            this.picboxImagen.Name = "picboxImagen";
            this.picboxImagen.Size = new System.Drawing.Size(351, 292);
            this.picboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImagen.TabIndex = 16;
            this.picboxImagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(60, 75);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(40, 25);
            this.btnImagen.TabIndex = 14;
            this.btnImagen.Text = "...";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(9, 80);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(44, 14);
            this.lblImagen.TabIndex = 13;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(12, 30);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(351, 20);
            this.txtboxNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 14);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 422);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 14);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "#IdPersonaje";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(399, 28);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(162, 22);
            this.cmbIdioma.TabIndex = 25;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(396, 11);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(43, 14);
            this.lblIdioma.TabIndex = 24;
            this.lblIdioma.Text = "Idioma: ";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(197, 411);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(390, 25);
            this.lblError.TabIndex = 26;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // InsertarModificarPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 452);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDescCatalan);
            this.Controls.Add(this.txtboxDescripcion);
            this.Controls.Add(this.btnInsertarModificar);
            this.Controls.Add(this.picboxImagen);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertarModificarPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Personaje";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescCatalan;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.Button btnInsertarModificar;
        private System.Windows.Forms.PictureBox picboxImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}