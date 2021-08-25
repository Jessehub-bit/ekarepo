
namespace Harjoitus_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.painoTb = new System.Windows.Forms.TextBox();
            this.pituusBT = new System.Windows.Forms.TextBox();
            this.BMIBT = new System.Windows.Forms.Button();
            this.BmiLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus";
            // 
            // painoTb
            // 
            this.painoTb.Location = new System.Drawing.Point(89, 25);
            this.painoTb.Name = "painoTb";
            this.painoTb.Size = new System.Drawing.Size(100, 23);
            this.painoTb.TabIndex = 2;
            // 
            // pituusBT
            // 
            this.pituusBT.Location = new System.Drawing.Point(89, 50);
            this.pituusBT.Name = "pituusBT";
            this.pituusBT.Size = new System.Drawing.Size(100, 23);
            this.pituusBT.TabIndex = 3;
            // 
            // BMIBT
            // 
            this.BMIBT.Location = new System.Drawing.Point(12, 84);
            this.BMIBT.Name = "BMIBT";
            this.BMIBT.Size = new System.Drawing.Size(177, 23);
            this.BMIBT.TabIndex = 4;
            this.BMIBT.Text = "Laske painoindeksi";
            this.BMIBT.UseVisualStyleBackColor = true;
            this.BMIBT.Click += new System.EventHandler(this.BMIBT_Click);
            // 
            // BmiLB
            // 
            this.BmiLB.AutoSize = true;
            this.BmiLB.Location = new System.Drawing.Point(12, 122);
            this.BmiLB.Name = "BmiLB";
            this.BmiLB.Size = new System.Drawing.Size(0, 15);
            this.BmiLB.TabIndex = 5;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Location = new System.Drawing.Point(12, 151);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(0, 15);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(216, 192);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.BmiLB);
            this.Controls.Add(this.BMIBT);
            this.Controls.Add(this.pituusBT);
            this.Controls.Add(this.painoTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MBI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox painoTb;
        private System.Windows.Forms.TextBox pituusBT;
        private System.Windows.Forms.Button BMIBT;
        private System.Windows.Forms.Label BmiLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

