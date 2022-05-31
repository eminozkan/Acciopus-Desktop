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

namespace Acciopus.EmployerPanelForms
{
    internal partial class EmployerForm : Form
    {

        private Boolean isUserMovingTab = false;
        Point MoveLocation = new Point();
 

        private User.User activeUser = new User.User();


        public EmployerForm()
        {
            InitializeComponent();
        }

        private void FillDataGrid1()
        {
            App.FillDataGrid(DataGridSettings.getDataGrid1SqlString(),"Ilanlar",dataGridView1);
            DataGridSettings.setDataGridView1Settings(dataGridView1);
        }

        private void FillDataGrid2()
        {
            
            SqlCommand sql = new SqlCommand(DataGridSettings.getDataGrid2SqlString());
            sql.Parameters.AddWithValue("@p1", activeUser.getID());
            App.FillDataGrid(sql, "Basvuru", dataGridView2);
            DataGridSettings.setDataGridView2Settings(dataGridView2);          
        }

        private void FillDataGrid3()
        {
            SqlCommand sql = new SqlCommand(DataGridSettings.getDataGrid3SqlString());
            sql.Parameters.AddWithValue("@p1", activeUser.getID());
            App.FillDataGrid(sql, "Ilanlar", dataGridView3);
            DataGridSettings.setDataGridView3Settings(dataGridView3);
        }

        public void setUser(User.User user)
        {
            activeUser = user;
        }

        private void EmployerForm_Load(object sender, EventArgs e)
        {
            FillDataGrid1();
            FillDataGrid2();
            FillDataGrid3();

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

        private void sifre_degis_Click(object sender, EventArgs e)
        {
            PasswordReset.ChangePassword newPass = new PasswordReset.ChangePassword();
            newPass.ID = activeUser.getID();

            newPass.Show();
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


        private void add_post_Click(object sender, EventArgs e)
        {
            PostJob post = new PostJob();
            post.setUser(activeUser);
            post.Show();

            this.Hide();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.CurrentRow != null)
            {
                int basvuru_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                RequestStatements state = App.setRequestStateToApproved(basvuru_id);
                if (state == RequestStatements.Success)
                {
                    MessageBox.Show("Seçtiğiniz başvuru onaylandı!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata meydana geldi!.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                FillDataGrid2();
            }
            else
            {
                MessageBox.Show("Onaylamak istediğiniz başvuruyu seçiniz.","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void reddet_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int basvuru_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                RequestStatements state = App.setRequestStateToNonApproved(basvuru_id);
                if (state == RequestStatements.Success)
                {
                    MessageBox.Show("Seçtiğiniz başvuru reddedildi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata meydana geldi!.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                FillDataGrid2();
            }
            else
            {
                MessageBox.Show("Reddetmek istediğiniz başvuruyu seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ilan_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                SqlCommand deletePost = new SqlCommand("Delete from Ilanlar where ilan_id = @p1");
                deletePost.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

                SqlCommandStatements state = App.sendSqlCommand(deletePost);
                if (state == SqlCommandStatements.Success)
                {
                    MessageBox.Show("İlan başarıyla silindi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Hata meydana geldi!.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                FillDataGrid3();
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ilanı seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bugBildir_Click(object sender, EventArgs e)
        {
            BugReports.ReportABug bug = new BugReports.ReportABug();
            bug.Show();
        }
    }
}
