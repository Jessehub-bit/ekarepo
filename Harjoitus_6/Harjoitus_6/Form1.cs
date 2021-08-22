using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jesse" && SalasanaTB.Text == "Kiss@123")
            {
                SalasanaOikeinPanel.Visible = true;
                SalasanaPanel.Visible = false;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjä tunnus tai salsana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
