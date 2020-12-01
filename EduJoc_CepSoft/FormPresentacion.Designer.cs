namespace EduJoc_CepSoft
{
    partial class FormPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.btnPersonajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(227, 36);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(604, 363);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreguntas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntas.Image = ((System.Drawing.Image)(resources.GetObject("btnPreguntas.Image")));
            this.btnPreguntas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreguntas.Location = new System.Drawing.Point(227, 438);
            this.btnPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(276, 68);
            this.btnPreguntas.TabIndex = 1;
            this.btnPreguntas.Text = "Gestionar Preguntas";
            this.btnPreguntas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreguntas.UseVisualStyleBackColor = false;
            this.btnPreguntas.Click += new System.EventHandler(this.btnPreguntas_Click);
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersonajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPersonajes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonajes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonajes.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonajes.Image")));
            this.btnPersonajes.Location = new System.Drawing.Point(555, 438);
            this.btnPersonajes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(276, 68);
            this.btnPersonajes.TabIndex = 2;
            this.btnPersonajes.Text = "Gestionar Personajes";
            this.btnPersonajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonajes.UseVisualStyleBackColor = false;
            this.btnPersonajes.Click += new System.EventHandler(this.btnPersonajes_Click);
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1056, 554);
            this.Controls.Add(this.btnPersonajes);
            this.Controls.Add(this.btnPreguntas);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EcoArts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.Button btnPersonajes;
    }
}

