using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.tehtävä___CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluGD.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            ONroTB.Text = "";
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string enimi = EnimiTB.Text;
            string snimi = SnimiTB.Text;
            string puhelin = PuhTB.Text;
            string email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiselijanumero", "Tyhjää kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            string enimi = EnimiTB.Text;
            string snimi = SnimiTB.Text;
            string puhelin = PuhTB.Text;
            string email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (oid.Equals("") || (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjää kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if(lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijian päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluGD.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TietotauluGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluGD.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TietotauluGD.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TietotauluGD.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TietotauluGD.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TietotauluGD.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = TietotauluGD.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluGD.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }
    }
}
