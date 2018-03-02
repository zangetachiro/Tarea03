namespace Tarea03
{
    partial class frmPrograma06
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
            this.cboA = new System.Windows.Forms.ComboBox();
            this.cboB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(12, 22);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(216, 293);
            this.cboA.TabIndex = 0;
            this.cboA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // cboB
            // 
            this.cboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboB.FormattingEnabled = true;
            this.cboB.Location = new System.Drawing.Point(234, 22);
            this.cboB.Name = "cboB";
            this.cboB.Size = new System.Drawing.Size(216, 293);
            this.cboB.TabIndex = 1;
            this.cboB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Areglo A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arreglo B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arreglo C";
            // 
            // lblC
            // 
            this.lblC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblC.Location = new System.Drawing.Point(456, 22);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(162, 284);
            this.lblC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Multiplicar valores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrograma06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboB);
            this.Controls.Add(this.cboA);
            this.Name = "frmPrograma06";
            this.Text = "frmPrograma06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.ComboBox cboB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button button1;
    }
}