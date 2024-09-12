namespace Evaluacion
{
    partial class form1
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
            this.lblNames = new System.Windows.Forms.Label();
            this.tbNames = new System.Windows.Forms.TextBox();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(74, 61);
            this.lblNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(87, 25);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Nombre:";
            // 
            // tbNames
            // 
            this.tbNames.Location = new System.Drawing.Point(168, 61);
            this.tbNames.Name = "tbNames";
            this.tbNames.Size = new System.Drawing.Size(248, 30);
            this.tbNames.TabIndex = 1;
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(168, 161);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(248, 33);
            this.cmbNames.TabIndex = 2;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(500, 108);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 47);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Subir";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.tbNames);
            this.Controls.Add(this.lblNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form1";
            this.Text = "Almacenar Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.TextBox tbNames;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnUpload;
    }
}

