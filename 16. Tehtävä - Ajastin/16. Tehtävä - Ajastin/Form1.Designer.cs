
namespace _16._Tehtävä___Ajastin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "00:00";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(9, 42);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinuutitCB.Size = new System.Drawing.Size(75, 23);
            this.MinuutitCB.TabIndex = 3;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(115, 42);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SekunnitCB.Size = new System.Drawing.Size(85, 23);
            this.SekunnitCB.TabIndex = 4;
            this.SekunnitCB.SelectedIndexChanged += new System.EventHandler(this.SekunnitCB_SelectedIndexChanged);
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(21, 157);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(75, 23);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(112, 157);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(75, 23);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 197);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

