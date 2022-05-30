using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.WorkerPanelForms
{
    internal partial class WorkerPanel : Form
    {


        private User.User activeUser = new User.User();
        private Boolean isUserMovingTab = false;
        Point MoveLocation = new Point();

        public WorkerPanel()
        {
            InitializeComponent();
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = true;
                MoveLocation.X = e.X;
                MoveLocation.Y = e.Y;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isUserMovingTab)
            {
                this.Location = new Point(this.Location.X + (e.X - MoveLocation.X), this.Location.Y + (e.Y - MoveLocation.Y));
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = false;
            }
        }

        private LogOffStatements AskUserToLogOff()
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış Yapmak İstediginize emin misiniz?", "Çıkış Yap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                return LogOffStatements.UserWantsToQuit;
            }
            else
            {
                return LogOffStatements.UserDoesntWantToQuit;
            }
        }
        public void setUser(User.User usr)
        {
            activeUser = usr;
            
        }
  

        private void Mainpanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.StopSession();
            Application.Exit();
        }

        private void Mainpanel_Load(object sender, EventArgs e)
        {
            App.FillDataGrid(DataGridViewFunctions.getDataGrid1SqlString(), "Kullanici", dataGridView1);
            DataGridViewFunctions.setDataGridView1Settings(dataGridView1);
            SqlCommand sql = DataGridViewFunctions.getDataGrid2SqlString();
            sql.Parameters.AddWithValue("@p1", activeUser.getID());
            App.FillDataGrid(DataGridViewFunctions.getDataGrid2SqlString(), "Basvuru", dataGridView2);
            DataGridViewFunctions.setDataGridView2Settings(dataGridView2);
            comboBox1.SelectedIndex = 0;
            firma_rb.Checked = true;
        }


        private void logoff_Click(object sender, EventArgs e)
        {
            LogOffStatements state = AskUserToLogOff();
            if (state == LogOffStatements.UserWantsToQuit)
            {
                App.StopSession();
                Application.Exit();
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                WorkerPanelForms.RequestJob requestJob = new WorkerPanelForms.RequestJob();
                requestJob.user = activeUser;
                requestJob.FirmaAdi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                MessageBox.Show(requestJob.FirmaAdi);
                requestJob.IlanBaslik = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                requestJob.ilan_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                requestJob.Show();
            }
            else
            {
                MessageBox.Show("Lütfen başvuru yapmak istediginiz ilanı seçiniz!");
            }

        }

        private void ilan_arama_TextChanged(object sender, EventArgs e)
        {
            if(ilan_arama.Text.Length > 0)
            {
                if (firma_rb.Checked)
                {
                    String dataGridView1SearchSql = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Ilanlar as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id where ilan_firma_adi LIKE '%" + ilan_arama.Text + "%'";
                    SqlCommand search = new SqlCommand(dataGridView1SearchSql);
                    
                    App.FillDataGrid(search, "Ilanlar", dataGridView1);
                }else if (meslek_rb.Checked)
                {
                    String dataGridView1SearchSql = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Ilanlar as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id where meslek_adi LIKE '%" + ilan_arama.Text + "%'";
                    SqlCommand search = new SqlCommand(dataGridView1SearchSql);
                    
                    App.FillDataGrid(search, "Ilanlar", dataGridView1);
                }else if (baslik_rb.Checked)
                {
                    String dataGridView1SearchSql = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Ilanlar as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id where ilan_baslik LIKE '%" + ilan_arama.Text +"%'";
                    SqlCommand search = new SqlCommand(dataGridView1SearchSql);
                    
                    App.FillDataGrid(search, "Ilanlar", dataGridView1);
                }
                DataGridViewFunctions.setDataGridView1Settings(dataGridView1);

            }
            else
            {
                App.FillDataGrid(DataGridViewFunctions.getDataGrid1SqlString(), "Kullanici", dataGridView1);
                DataGridViewFunctions.setDataGridView1Settings(dataGridView1);
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            LogOffStatements state = AskUserToLogOff();
            if (state == LogOffStatements.UserWantsToQuit)
            {
                App.StopSession();
                Application.Exit();
            }
        }

        private void sifre_degis_Click(object sender, EventArgs e)
        {
            PasswordReset.ChangePassword newPass = new PasswordReset.ChangePassword();
            newPass.ID = activeUser.getID();

            newPass.Show();

        }
    }
}
