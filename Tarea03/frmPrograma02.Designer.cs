namespace Tarea03
{
    partial class frmPrograma02
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
            this.lblVectorA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVectorB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVectorC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVectorA
            // 
            this.lblVectorA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVectorA.Location = new System.Drawing.Point(77, 9);
            this.lblVectorA.Name = "lblVectorA";
            this.lblVectorA.Size = new System.Drawing.Size(300, 46);
            this.lblVectorA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // lblVectorB
            // 
            this.lblVectorB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVectorB.Location = new System.Drawing.Point(77, 72);
            this.lblVectorB.Name = "lblVectorB";
            this.lblVectorB.Size = new System.Drawing.Size(300, 46);
            this.lblVectorB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // lblVectorC
            // 
            this.lblVectorC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVectorC.Location = new System.Drawing.Point(77, 139);
            this.lblVectorC.Name = "lblVectorC";
            this.lblVectorC.Size = new System.Drawing.Size(300, 46);
            this.lblVectorC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "C";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(228, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(42, 249);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(180, 38);
            this.btnInicializar.TabIndex = 10;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // frmPrograma02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 310);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVectorC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVectorB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVectorA);
            this.Controls.Add(this.label1);
            this.Name = "frmPrograma02";
            this.Text = "Programa 2";
            this.Load += new System.EventHandler(this.frmPrograma02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVectorA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVectorB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVectorC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnInicializar;
    }
}