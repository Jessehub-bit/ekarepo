
namespace Harjoitus7
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
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna asteet:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(12, 88);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(274, 50);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(75, 23);
            this.MuunnaBT.TabIndex = 2;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(184, 27);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(62, 19);
            this.CelsiusRB.TabIndex = 3;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(173, 52);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(84, 19);
            this.FahrenheitRB.TabIndex = 4;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit\'";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(90, 6);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(45, 23);
            this.AsteetTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miten muunnat?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 108);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.FahrenheitRB);
            this.Controls.Add(this.CelsiusRB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Celcius to Fahrenheit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.RadioButton CelsiusRB;
        private System.Windows.Forms.RadioButton FahrenheitRB;
        private System.Windows.Forms.TextBox AsteetTB;
        private System.Windows.Forms.Label label2;
    }
}

