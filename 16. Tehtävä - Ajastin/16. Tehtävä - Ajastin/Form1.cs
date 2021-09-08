﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._Tehtävä___Ajastin
{
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
        }

        private void SekunnitCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
            MinuutitCB.SelectedIndex = 0;
            SekunnitCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            label3.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekuntit = kokonaisaika - (minuutit * 60);
                label3.Text = minuutit + ":" + sekuntit;
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
