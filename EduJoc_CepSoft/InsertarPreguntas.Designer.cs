namespace EduJoc_CepSoft
{
    partial class InsertarPreguntas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTema = new System.Windows.Forms.ComboBox();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tema: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idioma: ";
            // 
            // comboBoxTema
            // 
            this.comboBoxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTema.FormattingEnabled = true;
            this.comboBoxTema.Location = new System.Drawing.Point(21, 35);
            this.comboBoxTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTema.Name = "comboBoxTema";
            this.comboBoxTema.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTema.TabIndex = 2;
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Location = new System.Drawing.Point(218, 35);
            this.comboBoxIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(181, 21);
            this.comboBoxIdioma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pregunta";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(21, 78);
            this.textBoxPregunta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(376, 97);
            this.textBoxPregunta.TabIndex = 5;
            // 
            // InsertarPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 512);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.comboBoxTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InsertarPreguntas";
            this.Text = "Insertar pregunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTema;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPregunta;
    }
}