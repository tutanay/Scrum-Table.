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
    public partial class ScrumForm : Form
    {
        public Baglanti baglanti;
        public HikayeForm HF;
        public GorevForm GF;
        public List<Button> Gorevler; /// ////////
        public ScrumForm()

        {
            Gorevler = new List<Button>();
            baglanti = new Baglanti();
            HF = new HikayeForm();
            GF = new GorevForm();

            InitializeComponent();
            pnlBasla.AllowDrop = true;

            pnlYapim.AllowDrop = true;

            pnlTest.AllowDrop = true;

            pnlTamam.AllowDrop = true;

        }


        public void KontrolButonu()
        {
            for (int i = 0; i < Gorevler.Count(); i++)

            {
                for (int j = i + 1; j < Gorevler.Count(); j++)
                {
                    if (Gorevler[i].Text == Gorevler[j].Text)
                        pnlBasla.Controls.Remove(Gorevler[i]);
                }
            }

        }
        public void HikayeveGorevYaratmaButonu()
        {
            int top = 40;
            int top2 = 40;

            for (int i = 0; i < baglanti.Hikayeler.Count(); i++)
            {
                Button buttonStory = new Button();
                buttonStory.Text = baglanti.Hikayeler[i].HBaslik;
                buttonStory.Width = 100;
                buttonStory.Height = 100;
                buttonStory.BackColor = System.Drawing.Color.White;
                buttonStory.Left = 40;
                buttonStory.Top = top;
                top += buttonStory.Height + 2;
                pnlHikaye.Controls.Add(buttonStory);
                buttonStory.Click += btnHikaye_Click;

                pnlBasla.DragEnter += pnlBasla_DragEnter;
                pnlYapim.DragEnter += pnlYapim_DragEnter;
                pnlTest.DragEnter += pnlTest_DragEnter;
                pnlTamam.DragEnter += pnlTamam_DragEnter;

                pnlBasla.DragEnter += pnlBasla_DragDrop;
                pnlYapim.DragDrop += pnlYapim_DragDrop;
                pnlTest.DragDrop += pnlTest_DragDrop;
                pnlTamam.DragEnter += pnlTamam_DragDrop;
                for (int j = 0; j < baglanti.Hikayeler[i].Gorevler.Count(); j++)
                {
                    Button buttonTask = new Button();
                    buttonTask.Text = baglanti.Hikayeler[i].Gorevler[j].GorevBasligi;
                    buttonTask.Width = 100;
                    buttonTask.Height = (buttonStory.Height / baglanti.Hikayeler[i].Gorevler.Count());
                    buttonTask.BackColor = System.Drawing.Color.White;
                    buttonTask.Left = 40;
                    buttonTask.Top = top2;
                    pnlBasla.Controls.Add(buttonTask);
                    top2 += buttonTask.Height;
                    buttonTask.Click += ButtonTask_Click;
                    buttonTask.MouseDown += ButtonTask_MouseDown;
                    Gorevler.Add(buttonTask);
                }
            }
        }

        private void btnHikaye_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string temp = "";
            for (int j = 0; j < baglanti.Hikayeler.Count(); j++)
            {

                if (b.Text == baglanti.Hikayeler[j].HBaslik)
                {
                    temp += "Hikayenin Başlığı = " + baglanti.Hikayeler[j].HBaslik + Environment.NewLine + "Hikaye Yazarı = " + baglanti.Hikayeler[j].HYazar + Environment.NewLine +
                            "Hikaye Açıklaması = " + baglanti.Hikayeler[j].HAciklama;

                    break;
                }

            }

            MessageBox.Show(temp);
        }

        private void pnlTamam_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void pnlTest_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void pnlYapim_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void pnlBasla_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void pnlTamam_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlTest_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlYapim_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlBasla_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        public void ButtonTask_MouseDown(object sender, MouseEventArgs e)
        {
            Button button2 = (Button)sender;
            button2.DoDragDrop(button2, DragDropEffects.Move);


            button2.PerformClick();

        }
        private void ButtonTask_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string temp = "";
            for (int j = 0; j < baglanti.Hikayeler.Count(); j++)
            {
                for (int i = 0; i < baglanti.Hikayeler[j].Gorevler.Count(); i++)
                {

                    if (b.Text == baglanti.Hikayeler[j].Gorevler[i].GorevBasligi)
                    {

                        temp += "Gorev Başlığı = " + baglanti.Hikayeler[j].Gorevler[i].GorevBasligi + Environment.NewLine +
                                Environment.NewLine + "Task Description = " + baglanti.Hikayeler[j].Gorevler[i].GorevAciklamasi;

                        break;
                    }

                }


            }

            MessageBox.Show(temp);

        }
        public void Closer()
        {
            HF.Close();
            GF.Close();

            pnlHikaye.Visible = false;
            pnlBasla.Visible = false;
            pnlYapim.Visible = false;
            pnlTest.Visible = false;
            pnlTamam.Visible = false;
            txtHikaye.Visible = false;
            txtBasla.Visible = false;
            txtYapim.Visible = false;
            txtTest.Visible = false;
            txtTamam.Visible = false;
        }




        private void ScrumForm_Load(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            HF.Close();
            GF.Close();

            pnlHikaye.Visible = true;
            pnlBasla.Visible = true;
            pnlYapim.Visible = true;
            pnlTest.Visible = true;
            pnlTamam.Visible = true;
            txtHikaye.Visible = true;
            txtBasla.Visible = true;
            txtYapim.Visible = true;
            txtTest.Visible = true;
            txtTamam.Visible = true;

            pnlBasla.Controls.Clear();
            HikayeveGorevYaratmaButonu();
            KontrolButonu();

            if (pnlBasla.Visible == true)
            {
                btnGoster.Enabled = false;
            }
        }

        private void ScrumForm_Load_1(object sender, EventArgs e)
        {
            Closer();
        }

        private void btnHikaye_Click_1(object sender, EventArgs e)
        {
            Closer();

            HF = new HikayeForm();
            HF.MdiParent = this;
            HF.baglanti = this.baglanti;
            HF.Show();
            HF.BringToFront();
            btnGoster.Enabled = true;
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            Closer();
            GF = new GorevForm();
            GF.MdiParent = this;
            GF.baglanti = this.baglanti;
            GF.Show();
            GF.BringToFront();
            btnGoster.Enabled = true;
        }
    }
}

    
        
    

