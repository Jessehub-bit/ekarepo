
namespace _15._Tehtävä___Sekuntikello
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaynnistaBt = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LopetaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(12, 9);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(585, 128);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00.000";
            // 
            // KaynnistaBt
            // 
            this.KaynnistaBt.Location = new System.Drawing.Point(39, 158);
            this.KaynnistaBt.Name = "KaynnistaBt";
            this.KaynnistaBt.Size = new System.Drawing.Size(128, 42);
            this.KaynnistaBt.TabIndex = 1;
            this.KaynnistaBt.Text = "Käynnistä";
            this.KaynnistaBt.UseVisualStyleBackColor = true;
            this.KaynnistaBt.Click += new System.EventHandler(this.KaynnistaBt_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(432, 158);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(128, 42);
            this.TyhjennaBT.TabIndex = 2;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(239, 158);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(128, 42);
            this.LopetaBT.TabIndex = 3;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 240);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.KaynnistaBt);
            this.Controls.Add(this.AikaLB);
            this.Name = "Form1";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button KaynnistaBt;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LopetaBT;
    }
}

