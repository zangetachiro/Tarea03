namespace Tarea03
{
    partial class frmPrograma04
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblSumPos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSumNeg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPositivos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNegativos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCeros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(213, 284);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(173, 44);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir Valores";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblSumPos
            // 
            this.lblSumPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSumPos.Location = new System.Drawing.Point(423, 193);
            this.lblSumPos.Name = "lblSumPos";
            this.lblSumPos.Size = new System.Drawing.Size(150, 48);
            this.lblSumPos.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Suma Positivos";
            // 
            // lblSumNeg
            // 
            this.lblSumNeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSumNeg.Location = new System.Drawing.Point(155, 193);
            this.lblSumNeg.Name = "lblSumNeg";
            this.lblSumNeg.Size = new System.Drawing.Size(150, 48);
            this.lblSumNeg.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Suma Negativos";
            // 
            // lblPositivos
            // 
            this.lblPositivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPositivos.Location = new System.Drawing.Point(481, 110);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(61, 48);
            this.lblPositivos.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Positivos";
            // 
            // lblNegativos
            // 
            this.lblNegativos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNegativos.Location = new System.Drawing.Point(325, 110);
            this.lblNegativos.Name = "lblNegativos";
            this.lblNegativos.Size = new System.Drawing.Size(61, 48);
            this.lblNegativos.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Negativos";
            // 
            // lblCeros
            // 
            this.lblCeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCeros.Location = new System.Drawing.Point(155, 110);
            this.lblCeros.Name = "lblCeros";
            this.lblCeros.Size = new System.Drawing.Size(61, 48);
            this.lblCeros.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "0\'s";
            // 
            // lblOriginal
            // 
            this.lblOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginal.Location = new System.Drawing.Point(155, 37);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(387, 48);
            this.lblOriginal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vector Original";
            // 
            // frmPrograma04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 364);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblSumPos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSumNeg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPositivos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNegativos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.label1);
            this.Name = "frmPrograma04";
            this.Text = "frmPrograma04";
            this.Load += new System.EventHandler(this.frmPrograma04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblSumPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSumNeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNegativos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label label1;
    }
}