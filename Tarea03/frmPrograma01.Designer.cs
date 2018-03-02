namespace Tarea03
{
    partial class frmPrograma01
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMayores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValoresMayores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores";
            // 
            // lblValores
            // 
            this.lblValores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValores.Location = new System.Drawing.Point(76, 9);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(300, 46);
            this.lblValores.TabIndex = 1;
            this.lblValores.Text = "[ valores ]";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(76, 75);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(127, 30);
            this.lblPromedio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promedio";
            // 
            // lblMayores
            // 
            this.lblMayores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayores.Location = new System.Drawing.Point(262, 75);
            this.lblMayores.Name = "lblMayores";
            this.lblMayores.Size = new System.Drawing.Size(127, 30);
            this.lblMayores.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mayores";
            // 
            // lblValoresMayores
            // 
            this.lblValoresMayores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValoresMayores.Location = new System.Drawing.Point(76, 134);
            this.lblValoresMayores.Name = "lblValoresMayores";
            this.lblValoresMayores.Size = new System.Drawing.Size(300, 46);
            this.lblValoresMayores.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valores Mayores";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 38);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmPrograma01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 256);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValoresMayores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMayores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.label1);
            this.Name = "frmPrograma01";
            this.Text = "Programa 1";
            this.Load += new System.EventHandler(this.frmPrograma01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMayores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValoresMayores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
    }
}

