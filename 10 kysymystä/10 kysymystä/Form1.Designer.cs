
namespace _10_kysymystä
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
            this.KysymysLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VastausDRB = new System.Windows.Forms.RadioButton();
            this.VastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.DummyRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLb
            // 
            this.KysymysLb.AutoSize = true;
            this.KysymysLb.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KysymysLb.Location = new System.Drawing.Point(12, 9);
            this.KysymysLb.Name = "KysymysLb";
            this.KysymysLb.Size = new System.Drawing.Size(277, 25);
            this.KysymysLb.TabIndex = 4;
            this.KysymysLb.Text = "Vastaus 1. kysymykseen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VastausDRB);
            this.groupBox1.Controls.Add(this.VastausCRB);
            this.groupBox1.Controls.Add(this.VastausBRB);
            this.groupBox1.Controls.Add(this.VastausARB);
            this.groupBox1.Controls.Add(this.DummyRB);
            this.groupBox1.Location = new System.Drawing.Point(295, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(62, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VastausDRB
            // 
            this.VastausDRB.AutoSize = true;
            this.VastausDRB.Location = new System.Drawing.Point(7, 101);
            this.VastausDRB.Name = "VastausDRB";
            this.VastausDRB.Size = new System.Drawing.Size(33, 19);
            this.VastausDRB.TabIndex = 4;
            this.VastausDRB.TabStop = true;
            this.VastausDRB.Text = "D";
            this.VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            this.VastausCRB.AutoSize = true;
            this.VastausCRB.Location = new System.Drawing.Point(7, 75);
            this.VastausCRB.Name = "VastausCRB";
            this.VastausCRB.Size = new System.Drawing.Size(33, 19);
            this.VastausCRB.TabIndex = 3;
            this.VastausCRB.TabStop = true;
            this.VastausCRB.Text = "C";
            this.VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            this.VastausBRB.AutoSize = true;
            this.VastausBRB.Location = new System.Drawing.Point(7, 49);
            this.VastausBRB.Name = "VastausBRB";
            this.VastausBRB.Size = new System.Drawing.Size(32, 19);
            this.VastausBRB.TabIndex = 2;
            this.VastausBRB.TabStop = true;
            this.VastausBRB.Text = "B";
            this.VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(7, 23);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(33, 19);
            this.VastausARB.TabIndex = 1;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            this.DummyRB.AutoCheck = false;
            this.DummyRB.AutoSize = true;
            this.DummyRB.Location = new System.Drawing.Point(7, 23);
            this.DummyRB.Name = "DummyRB";
            this.DummyRB.Size = new System.Drawing.Size(31, 19);
            this.DummyRB.TabIndex = 0;
            this.DummyRB.TabStop = true;
            this.DummyRB.Text = "E";
            this.DummyRB.UseVisualStyleBackColor = true;
            this.DummyRB.Visible = false;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(12, 112);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(101, 25);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 179);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KysymysLb);
            this.Name = "Form1";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KysymysLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VastausDRB;
        private System.Windows.Forms.RadioButton VastausCRB;
        private System.Windows.Forms.RadioButton VastausBRB;
        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.RadioButton DummyRB;
        private System.Windows.Forms.Label VastausLB;
    }
}

