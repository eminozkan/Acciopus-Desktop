using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.AdminPanelForms
{
    internal partial class AdminPanel : Form
    {
        private User.User activeUser = new User.User();


        public void setUser(User.User user)
        {
            this.activeUser = user;
        }

    

        public AdminPanel()
        {
            InitializeComponent();
            
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            FillDataGrid1();
            FillDataGrid2();
            FillDataGrid3();
            FillDataGrid4();
        }





        //Tab1

        private void FillDataGrid1()
        {
            String datagrid1 = DataGridViewFunctions.getDataGrid1SqlString();
            SqlCommand getUserInfo = new SqlCommand(datagrid1);
            getUserInfo.Parameters.AddWithValue("@p1", activeUser.getID());
            App.FillDataGrid(getUserInfo, "Kullanici", dataGridView1);
            DataGridViewFunctions.setDataGrid1Settings(dataGridView1);
        }

        private void kullanici_ekle_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            
            addUser.Show();
            addUser.setUser(activeUser);
            this.Hide();
            
        }


        
        private void kullanici_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("delete from Kullanici where kullanici_id = @p1");
                    command.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    SqlCommandStatements state = App.sendSqlCommand(command);
                    if (state == SqlCommandStatements.Success)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGrid1();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        //tab2

        private void FillDataGrid2()
        {
            SqlCommand command = new SqlCommand(DataGridViewFunctions.getDataGridView2SqlString());
            App.FillDataGrid(command, "Ilanlar", dataGridView2);
            DataGridViewFunctions.setDataGrid2Settings(dataGridView2);
        }

        private void ilan_ekle_Click(object sender, EventArgs e)
        {
            PostJobFromAdmin form = new PostJobFromAdmin();
            form.setUser(activeUser);

            this.Hide();

            form.Show();
        }

        private void ilan_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null) {
                DialogResult result = MessageBox.Show("İlanı silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("delete from Ilanlar where ilan_id = @p1");
                    command.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                    SqlCommandStatements state = App.sendSqlCommand(command);
                    if(state == SqlCommandStatements.Success)
                    {
                        MessageBox.Show("İlan başarıyla silindi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataGrid2();
                    }
                    else
                    {
                        MessageBox.Show("İlan silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilanı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ilan_duzenle_Click(object sender, EventArgs e)
        {

            Post.Post ilan = new Post.Post();
            ilan.ilan_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            ilan.ilan_firma_adi = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ilan.ilan_aranan_meslek_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
            ilan.ilan_baslik = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            ilan.ilan_aciklama = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            ilan.ilan_teklif_edilen_maas = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            ilan.ilan_istenen_tecrube_suresi = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            ilan.ilan_tarihi = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[8].Value);

            EditPost panel = new EditPost();
            panel.setIlan(ilan);
            panel.setUser(activeUser);
            panel.Show();
            this.Hide();


        }


        //tab3

        private void FillDataGrid4()
        {
            SqlCommand sql = new SqlCommand(DataGridViewFunctions.getDataGridView4SqlString());
            App.FillDataGrid(sql, "Basvuru", dataGridView4);
            DataGridViewFunctions.setDataGridView4Settings(dataGridView4);
        }

        private void basvuru_sil_Click(object sender, EventArgs e)
        {
            if(dataGridView4.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand("delete from Basvuru where basvuru_id = @p1");
                cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value));

                SqlCommandStatements state = App.sendSqlCommand(cmd);
                if(state == SqlCommandStatements.Success)
                {
                    MessageBox.Show("Başvuru başarıyla silindi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGrid4();
                }
                else
                {
                    MessageBox.Show("Başvuru silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz başvuruyu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //tab4
        private void FillDataGrid3()
        {
            SqlCommand sql = new SqlCommand(DataGridViewFunctions.getDataGrid3SqlString());
            App.FillDataGrid(sql, "Hatalar", dataGridView3);
            DataGridViewFunctions.setDataGrid3Settings(dataGridView3);
        }

        private void hata_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                SqlCommand sql = new SqlCommand("delete from Hatalar where bug_id = @p1");
                sql.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
                SqlCommandStatements state = App.sendSqlCommand(sql);
                if(state == SqlCommandStatements.Success)
                {
                    MessageBox.Show("Hata raporu başarıyla silindi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGrid3();
                }
                else
                {
                    MessageBox.Show("Hata raporu silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz hata raporunu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        //Move Tab
        private Boolean isUserMovingTab = false;
        Point MoveLocation = new Point();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = true;
                MoveLocation.X = e.X;
                MoveLocation.Y = e.Y;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isUserMovingTab)
            {
                this.Location = new Point(this.Location.X + (e.X - MoveLocation.X), this.Location.Y + (e.Y - MoveLocation.Y));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = false;
            }
        }




        //contextMenuStrip
        private void sifre_degis_Click(object sender, EventArgs e)
        {
            PasswordReset.ChangePassword newPass = new PasswordReset.ChangePassword();
            newPass.ID = activeUser.getID();

            newPass.Show();
        }


        private LogOffStatements AskUserToLogOff()
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış Yapmak İstediginize emin misiniz?", "Çıkış Yap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                return LogOffStatements.UserWantsToQuit;
            }
            else
            {
                return LogOffStatements.UserDoesntWantToQuit;
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

        private void bugBildir_Click(object sender, EventArgs e)
        {
            BugReports.ReportABug bug = new BugReports.ReportABug();
            bug.Show();
        }


    }
}
