namespace Tarea03
{
    partial class frmPrograma03
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(226, 227);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(173, 44);
            this.btnSumar.TabIndex = 13;
            this.btnSumar.Text = "Elevar al cubo";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblResultante
            // 
            this.lblResultante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultante.Location = new System.Drawing.Point(184, 156);
            this.lblResultante.Name = "lblResultante";
            this.lblResultante.Size = new System.Drawing.Size(315, 48);
            this.lblResultante.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultante";
            // 
            // lblOriginal
            // 
            this.lblOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginal.Location = new System.Drawing.Point(184, 68);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(315, 48);
            this.lblOriginal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Original";
            // 
            // frmPrograma03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 313);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblResultante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.label1);
            this.Name = "frmPrograma03";
            this.Text = "frmPrograma03";
            this.Load += new System.EventHandler(this.frmPrograma03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label label1;
    }
}