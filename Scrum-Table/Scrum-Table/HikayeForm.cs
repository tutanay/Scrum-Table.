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

    public partial class HikayeForm : Form
    {
        public Baglanti baglanti;

        public HikayeForm()
        {
            InitializeComponent();
        }

        private void btnHikayeEkle_Click(object sender, EventArgs e)
        {
            Hikayee hikayee = new Hikayee();
            hikayee.HBaslik = txthbaslik.Text;
            hikayee.HYazar = txthyazar.Text;
            hikayee.HAciklama = txthaciklama.Text;
 
           baglanti.HikayeYarat(hikayee);

            MessageBox.Show("Hikaye başarıyla eklenmiştir.");
        }
    }
}
