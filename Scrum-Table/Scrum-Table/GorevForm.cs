using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum_Table
{
    public partial class GorevForm : Form
    {
        public Baglanti baglanti;

        public GorevForm()
        {
            InitializeComponent();
        }

        private void btnTakEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < baglanti.Hikayeler.Count(); i++)
            {
                if (baglanti.Hikayeler[i].HBaslik == cbsec.SelectedItem.ToString())
                {
                    Gorev gorev = new Gorev();
                    gorev.GorevBasligi = txtGbaslik.Text;
                    gorev.GorevAciklamasi = txtGaciklama.Text;
                    baglanti.Hikayeler[i].GorevYarat(gorev);
                }
            }
            MessageBox.Show("Gorev başarıyla eklendi.");
        }

        private void GorevForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < baglanti.Hikayeler.Count(); i++)
            {
                cbsec.Items.Add(baglanti.Hikayeler[i].HBaslik.ToString());
            }
        }
    }
}
