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
        Point MoveLocation;
        Boolean isUserMovingTab;
        

        public Acciopus()
        {
            InitializeComponent();
        }

        private void Acciopus_Load(object sender, EventArgs e)
        {
            next = nextPage.Hakkinda;
            tip.SelectedIndex = 0;
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

            label18.Text += Config.Configuration.getAuthorName();
          
        }

        public void setPanelToVisible(Panel p)
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


            anasayfa.Visible = false;
            anasayfa.Enabled = false;

            p.Visible = true;
            p.Enabled = true;
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
            setPanelToVisible(anasayfa);
        }

        private void hakkinda_lbl_Click(object sender, EventArgs e)
        {
            setPanelToVisible(hakkinda);
        }

        private void iletisim_lbl_Click(object sender, EventArgs e)
        {
            setPanelToVisible(iletisim);

        }

        private void giris_lbl_Click(object sender, EventArgs e)
        {
            setPanelToVisible(giris);
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setPanelToVisible(kayit);
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            
            Boolean arePasswordsSame = parolatb.Text.Equals(parolatekrartb.Text) ? true : false;
        
            if (arePasswordsSame)
            {
                User.User user = new User.User();
                user.setName(isimtb.Text);
                user.setSurname(soyisimtb.Text);
                
                user.setPassword(Encryption.Encryption.EncryptPassword(parolatb.Text));
     
                
                user.setEmail(emailtb.Text);
                user.setPhone(telefontb.Text);
                user.setDateOfBirth(dateTimePicker1.Value);
                if(tip.SelectedIndex == 0)
                {
                    user.setTypetoWorker();
                }else if(tip.SelectedIndex == 1)
                {
                    user.setTypetoEmployer();
                }
                App.SignUp(user);
            }
            else
            {
                MessageBox.Show("Parola Eşleşmiyor!");
            }
        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            Boolean isUserSigned = App.TryToLogin(email.Text, password.Text);
            if (isUserSigned)
            {
                
                User.User usr = new User.User();
                usr.setEmail(email.Text);
                
                App.StartSession(usr);
                
                
                if(usr.getType() == User.UserType.SystemAdmin)
                {
                    MessageBox.Show(usr.getType().ToString() + " paneli!");
                }
                else if (usr.getType() == User.UserType.Admin)
                {
                    MessageBox.Show(usr.getType() + " paneli!");
                }
                else if(usr.getType() == User.UserType.Employer)
                {
                    MessageBox.Show(usr.getType() + " paneli!");
                }
                else if(usr.getType() == User.UserType.Worker)
                {
                    WorkerPanel panel = new WorkerPanel();
                    panel.setUser(usr) ;
                    panel.Show();
                    this.Hide();
                }
                
                

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                isUserMovingTab = true;
                MoveLocation.X = e.X;
                MoveLocation.Y = e.Y;
            }
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isUserMovingTab)
            {
                this.Location = new Point(this.Location.X + (e.X - MoveLocation.X),this.Location.Y+( e.Y - MoveLocation.Y));
            }
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isUserMovingTab = false;
            }
        }
    }
}
