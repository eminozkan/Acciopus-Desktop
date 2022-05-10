using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus
{

    enum nextPage
    {
        Anasayfa,
        Hakkinda,
        Iletisim
    }

    public partial class Acciopus : Form
    {
        nextPage next;
        public Acciopus()
        {
            InitializeComponent();
        }

        private void Acciopus_Load(object sender, EventArgs e)
        {
            next = nextPage.Hakkinda;

            anasayfa.Location = new Point(activePanel.Location.X, activePanel.Location.Y);
            hakkinda.Location = new Point(activePanel.Location.X, activePanel.Location.Y);
            iletisim.Location = new Point(activePanel.Location.X, activePanel.Location.Y);
            giris.Location = new Point(activePanel.Location.X, activePanel.Location.Y);
            kayit.Location = new Point(activePanel.Location.X, activePanel.Location.Y);
            anasayfa.Visible = true;
            anasayfa.Enabled = true;

            hakkinda.Visible = false;
            hakkinda.Enabled = false;
            

            iletisim.Visible = false;
            iletisim.Enabled = false;
        

            giris.Visible = false;
            giris.Enabled = false;

            kayit.Visible = false;
            kayit.Enabled = false;
          
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (next == nextPage.Anasayfa)
            {
                iletisim.Visible = false;
                iletisim.Enabled = false;

                anasayfa.Visible = true;
                anasayfa.Enabled = true;

                next = nextPage.Hakkinda;
            }
            else if (next == nextPage.Hakkinda)
            {
                anasayfa.Visible = false;
                anasayfa.Enabled = false;

                hakkinda.Visible = true;
                hakkinda.Enabled = true;

                next = nextPage.Iletisim;
            }
            else if (next == nextPage.Iletisim)
            {
                hakkinda.Visible = false;
                hakkinda.Enabled = false;

                iletisim.Visible = true;
                iletisim.Enabled = true;

                next = nextPage.Anasayfa;
            }
        }


        private void anasayfa_lbl_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            giris.Visible = false;
            giris.Enabled = false;

            kayit.Visible = false;
            kayit.Enabled = false;


            iletisim.Visible = false;
            iletisim.Enabled = false;

            hakkinda.Visible = false;
            hakkinda.Enabled = false;

            
            anasayfa.Visible = true;
            anasayfa.Enabled = true;

            next = nextPage.Hakkinda;
        }

        private void hakkinda_lbl_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;

            giris.Visible = false;
            giris.Enabled = false;

            iletisim.Visible = false;
            iletisim.Enabled = false;

            kayit.Visible = false;
            kayit.Enabled = false;

            iletisim.Visible = false;
            iletisim.Enabled = false;

            anasayfa.Visible = false;
            anasayfa.Enabled = false;


            hakkinda.Visible = true;
            hakkinda.Enabled = true;

            next = nextPage.Iletisim;
        }

        private void iletisim_lbl_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            giris.Visible = false;
            giris.Enabled = false;

            kayit.Visible = false;
            kayit.Enabled = false;

            iletisim.Visible = false;
            iletisim.Enabled = false;

            anasayfa.Visible = false;
            anasayfa.Enabled = false;


            hakkinda.Visible = false;
            hakkinda.Enabled = false;

            iletisim.Visible = true;
            iletisim.Enabled = true;

    }

        private void giris_lbl_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            kayit.Visible = false;
            kayit.Enabled = false;


            anasayfa.Visible = false;
            anasayfa.Enabled = false;


            hakkinda.Visible = false;
            hakkinda.Enabled = false;


            iletisim.Visible = false;
            iletisim.Enabled = false;

            giris.Visible = true;
            giris.Enabled = true;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Enabled = false;
            giris.Visible = false;
            giris.Enabled = false;
            kayit.Visible = true;
            kayit.Enabled = true;



            anasayfa.Visible = false;
            anasayfa.Enabled = false;


            hakkinda.Visible = false;
            hakkinda.Enabled = false;


            iletisim.Visible = false;
            iletisim.Enabled = false;

            
            
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {

        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            App.TryToLogin(email.Text,password.Text);
        }
    }
}
