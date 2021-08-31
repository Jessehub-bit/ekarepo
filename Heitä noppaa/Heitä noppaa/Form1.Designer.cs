
namespace Heitä_noppaa
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
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.HeitaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::Heitä_noppaa.Properties.Resources.dice01;
            this.noppa01PB.Location = new System.Drawing.Point(11, 48);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(100, 100);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 0;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::Heitä_noppaa.Properties.Resources.dice01;
            this.noppa02PB.Location = new System.Drawing.Point(117, 48);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(100, 100);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 1;
            this.noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(11, 169);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(206, 50);
            this.HeitaBT.TabIndex = 2;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopan heitto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
        private System.Windows.Forms.Button HeitaBT;
        private System.Windows.Forms.Label label1;
    }
}

