namespace Tarea03
{
    partial class frmPrograma05
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
            this.btnInvertir = new System.Windows.Forms.Button();
            this.lblInverso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(203, 217);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(163, 47);
            this.btnInvertir.TabIndex = 16;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // lblInverso
            // 
            this.lblInverso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInverso.Location = new System.Drawing.Point(111, 121);
            this.lblInverso.Name = "lblInverso";
            this.lblInverso.Size = new System.Drawing.Size(398, 33);
            this.lblInverso.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inverso";
            // 
            // lblOriginal
            // 
            this.lblOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginal.Location = new System.Drawing.Point(111, 52);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(398, 33);
            this.lblOriginal.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Original";
            // 
            // frmPrograma05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 287);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.lblInverso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.label1);
            this.Name = "frmPrograma05";
            this.Text = "frmPrograma05";
            this.Load += new System.EventHandler(this.frmPrograma05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label lblInverso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label label1;
    }
}