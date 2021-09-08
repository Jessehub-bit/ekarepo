
namespace _18._Tehtävä___Pudotusvalikosta_riippuva_pudotusvalikko
{
    partial class AvainhenkilotForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.VastuuhloCB = new System.Windows.Forms.ComboBox();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitoseten Avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // VastuuhloCB
            // 
            this.VastuuhloCB.FormattingEnabled = true;
            this.VastuuhloCB.Location = new System.Drawing.Point(192, 96);
            this.VastuuhloCB.Name = "VastuuhloCB";
            this.VastuuhloCB.Size = new System.Drawing.Size(121, 23);
            this.VastuuhloCB.TabIndex = 4;
            this.VastuuhloCB.TextChanged += new System.EventHandler(this.VastuuhloCB_TextChanged);
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(12, 96);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(121, 23);
            this.OppilaitosCB.TabIndex = 5;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(12, 136);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(41, 15);
            this.OsoiteLB.TabIndex = 6;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(12, 168);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(75, 15);
            this.PostinumeroLB.TabIndex = 7;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 200);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(95, 15);
            this.PostitoimipaikkaLB.TabIndex = 8;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(15, 232);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(47, 15);
            this.PuhelinLB.TabIndex = 9;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(193, 232);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(47, 15);
            this.PuhLB.TabIndex = 13;
            this.PuhLB.Text = "Puhelin";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Location = new System.Drawing.Point(192, 200);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(65, 15);
            this.SahkopostiLB.TabIndex = 12;
            this.SahkopostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(193, 168);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(43, 15);
            this.OsastoLB.TabIndex = 11;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(193, 136);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(36, 15);
            this.TitteliLB.TabIndex = 10;
            this.TitteliLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.VastuuhloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VastuuhloCB;
        private System.Windows.Forms.ComboBox OppilaitosCB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label SahkopostiLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label TitteliLB;
    }
}

