using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._Tehtävä___Kahvila
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            mesitaPL.Visible = true;
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaisin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa ja makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan!\n";
            MeistaLB.Font = new Font("Arial", 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesitaPL.Visible = true;
            ruutaPL.Visible = false;
            juomatPL.Visible = false;
            herkutPl.Visible = false;
            koriPL.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mesitaPL.Visible = false;
            ruutaPL.Visible = true;
            juomatPL.Visible = false;
            herkutPl.Visible = false;
            koriPL.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mesitaPL.Visible = false;
            ruutaPL.Visible = false;
            juomatPL.Visible = true;
            herkutPl.Visible = false;
            koriPL.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mesitaPL.Visible = false;
            ruutaPL.Visible = false;
            juomatPL.Visible = false;
            herkutPl.Visible = true;
            koriPL.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mesitaPL.Visible = false;
            ruutaPL.Visible = false;
            juomatPL.Visible = false;
            herkutPl.Visible = false;
            koriPL.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
