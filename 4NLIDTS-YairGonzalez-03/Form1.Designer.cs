namespace _4NLIDTS_YairGonzalez_03
{
    partial class Form1
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
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFarenheit = new System.Windows.Forms.Button();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFarenheit = new System.Windows.Forms.TextBox();
            this.lbCelsius = new System.Windows.Forms.Label();
            this.lbFarenheit = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCelsius
            // 
            this.btnCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelsius.Location = new System.Drawing.Point(134, 182);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(88, 38);
            this.btnCelsius.TabIndex = 0;
            this.btnCelsius.Text = "Celsius a Farenheit";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Coral;
            this.btnLimpiar.Location = new System.Drawing.Point(288, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFarenheit
            // 
            this.btnFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarenheit.Location = new System.Drawing.Point(441, 182);
            this.btnFarenheit.Name = "btnFarenheit";
            this.btnFarenheit.Size = new System.Drawing.Size(88, 38);
            this.btnFarenheit.TabIndex = 2;
            this.btnFarenheit.Text = "Farenheit a Celsius";
            this.btnFarenheit.UseVisualStyleBackColor = true;
            this.btnFarenheit.Click += new System.EventHandler(this.btnFarenheit_Click);
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(119, 121);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(126, 20);
            this.tbCelsius.TabIndex = 3;
            // 
            // tbFarenheit
            // 
            this.tbFarenheit.Location = new System.Drawing.Point(424, 121);
            this.tbFarenheit.Name = "tbFarenheit";
            this.tbFarenheit.Size = new System.Drawing.Size(124, 20);
            this.tbFarenheit.TabIndex = 4;
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelsius.Location = new System.Drawing.Point(116, 88);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(91, 13);
            this.lbCelsius.TabIndex = 5;
            this.lbCelsius.Text = "Grados Celsius";
            // 
            // lbFarenheit
            // 
            this.lbFarenheit.AutoSize = true;
            this.lbFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFarenheit.Location = new System.Drawing.Point(425, 79);
            this.lbFarenheit.Name = "lbFarenheit";
            this.lbFarenheit.Size = new System.Drawing.Size(104, 13);
            this.lbFarenheit.TabIndex = 6;
            this.lbFarenheit.Text = "Grados Farenheit";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Indigo;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitulo.Location = new System.Drawing.Point(191, 22);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(293, 25);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Conversor de Temperatura";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4NLIDTS_YairGonzalez_03.Properties.Resources.Sin_título_1;
            this.ClientSize = new System.Drawing.Size(628, 300);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbFarenheit);
            this.Controls.Add(this.lbCelsius);
            this.Controls.Add(this.tbFarenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.btnFarenheit);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFarenheit;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFarenheit;
        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.Label lbFarenheit;
        private System.Windows.Forms.Label lbTitulo;
    }
}

