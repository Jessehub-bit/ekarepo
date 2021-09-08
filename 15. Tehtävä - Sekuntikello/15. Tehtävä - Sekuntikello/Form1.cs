using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _15._Tehtävä___Sekuntikello
{
   
    public partial class Form1 : Form
    {
        private Stopwatch sekkari;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

        private void KaynnistaBt_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }
    }
}
