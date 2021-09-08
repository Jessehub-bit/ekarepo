using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17._Tehtävä___Muistio
{
    public partial class NotepadForm : Form
    {
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void UusiTiedosto()
        {
            try
            {
                if(!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");
                }
                else
                {
                    richTextBox1.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
            
        }

        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas tekstiformaatti (*.rtf) | *.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                OpenFileDialog = new OpenFileDialog();
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(OpenFileDialog.FileName);
                    Text = OpenFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avataessa tiedostoa: " + ex);
            }
        }


       
        private void NotepadForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    TallennaTiedosto();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void kirjaisinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
    }
}
