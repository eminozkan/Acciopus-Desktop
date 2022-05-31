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
    internal partial class PostJobFromAdmin : Form
    {
        User.User user = new User.User();


        public void setUser(User.User usr)
        {
            this.user = usr;
        }

        public PostJobFromAdmin()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AdminPanel form = new AdminPanel();
            form.setUser(user);
            form.Show();

            this.Hide();

        }

        private SqlCommandStatements addJobPost()
        {
            SqlConnection conn = new SqlConnection(Config.Configuration.getConnectionString());
            SqlCommandStatements result = SqlCommandStatements.Fail;
            try
            {
                SqlCommand addJobPost = new SqlCommand("insert into Ilanlar (ilan_firma_adi,ilan_paylasan_id,ilan_aranan_meslek_id,ilan_baslik,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);

                addJobPost.Parameters.AddWithValue("@p1", firma_adi.Text);
                addJobPost.Parameters.AddWithValue("@p2", user.getID());
                addJobPost.Parameters.AddWithValue("@p3", meslek.SelectedIndex);
                addJobPost.Parameters.AddWithValue("@p4", baslik.Text);
                addJobPost.Parameters.AddWithValue("@p5", aciklama.Text);
                addJobPost.Parameters.AddWithValue("@p6", maas.Text);
                addJobPost.Parameters.AddWithValue("@p7", tecrube.SelectedItem.ToString());
                addJobPost.Parameters.AddWithValue("@p8", DateTime.Now);

                conn.Open();
                addJobPost.ExecuteNonQuery();
                conn.Close();
                result = SqlCommandStatements.Success;

            }
            catch (Exception e)
            {
                SqlCommand sendExceptiontoDatabase = new SqlCommand("Insert into Exception (Exception_Message,Exception_DateTime) values(@p1,@p2)", conn);

                sendExceptiontoDatabase.Parameters.AddWithValue("@p1", e.Message.ToString());
                sendExceptiontoDatabase.Parameters.AddWithValue("@p2", DateTime.Now);
                sendExceptiontoDatabase.ExecuteNonQuery();
                conn.Close();
            }

            return result;
        }

        private void ilan_ekle_Click(object sender, EventArgs e)
        {
            Boolean isAnyFieldEmpty = ((firma_adi.Text.Length == 0) || (baslik.Text.Length == 0) || (meslek.SelectedIndex == 0) || (maas.Text.Length == 0) || (aciklama.Text.Length == 0) || (tecrube.SelectedIndex == 0));
            if (isAnyFieldEmpty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommandStatements state = addJobPost();
                if (state == SqlCommandStatements.Success)
                {
                    MessageBox.Show("İlanınız başarıyla eklendi!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AdminPanel form = new AdminPanel();
                    form.setUser(user);
                    form.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hata!, İlanınız eklenemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void getJobList()
        {
            SqlConnection conn = new SqlConnection(Config.Configuration.getConnectionString());
            meslek.Items.Add("Lutfen birini seçiniz!");
            try
            {



                SqlCommand cmd = new SqlCommand("Select meslek_adi from Meslekler", conn);

                SqlDataReader reader;

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String Meslek = reader["meslek_adi"].ToString();
                    meslek.Items.Add(Meslek);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                SqlCommand sendExceptiontoDatabase = new SqlCommand("Insert into Exception (Exception_Message,Exception_DateTime) values(@p1,@p2)", conn);

                sendExceptiontoDatabase.Parameters.AddWithValue("@p1", e.Message.ToString());
                sendExceptiontoDatabase.Parameters.AddWithValue("@p2", DateTime.Now);
                sendExceptiontoDatabase.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void PostJobFromAdmin_Load(object sender, EventArgs e)
        {
            tecrube.SelectedIndex = 0;
            getJobList();
            meslek.SelectedIndex = 0;
        }
    }
    
}
