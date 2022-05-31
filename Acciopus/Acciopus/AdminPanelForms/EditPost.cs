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
    internal partial class EditPost : Form
    {
        Post.Post ilan = new Post.Post();
        public User.User user = new User.User();

        public EditPost()
        {
            InitializeComponent();
            
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

        private void setTextsValues()
        {
            firma_adi.Text = ilan.ilan_firma_adi;
            baslik.Text = ilan.ilan_baslik;
            getJobList();
            meslek.SelectedIndex = ilan.ilan_aranan_meslek_id;
            maas.Text = ilan.ilan_teklif_edilen_maas;
            tecrube.SelectedIndex = tecrube.Items.IndexOf(ilan.ilan_istenen_tecrube_suresi);
            aciklama.Text = ilan.ilan_aciklama;
        }
        
        public void setIlan(Post.Post ilan)
        {
            this.ilan = ilan;
        }
        public void setUser(User.User user)
        {
            this.user = user;
        }

        

        private void panel1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Ilanlar set " +
                "ilan_firma_adi = @p1 ,"+
                "ilan_aranan_meslek_id = @p2 ,"+
                "ilan_baslik = @p3 ,"+
                "ilan_aciklama = @p4 ,"+
                "ilan_teklif_edilen_maas = @p5 ,"+
                "ilan_istenen_tecrube_suresi = @p6 ,"+
                "ilan_tarihi = @p7 " +
                "where ilan_id = @id ");

            command.Parameters.AddWithValue("@p1",firma_adi.Text);
            command.Parameters.AddWithValue("@p2",meslek.SelectedIndex);
            command.Parameters.AddWithValue("@p3",baslik.Text);
            command.Parameters.AddWithValue("@p4",aciklama.Text);
            command.Parameters.AddWithValue("@p5",maas.Text);
            command.Parameters.AddWithValue("@p6",tecrube.Text);
            command.Parameters.AddWithValue("@p7",DateTime.Now);
            command.Parameters.AddWithValue("@id", ilan.ilan_id) ;

            SqlCommandStatements state = App.sendSqlCommand(command);

            if(state == SqlCommandStatements.Success)
            {
                MessageBox.Show("İlan başarıyla düzenlendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exit_Click(sender,e);
            }
            else
            {
                MessageBox.Show("İlan düzenlenirken hata meydana geldi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void İlan_Duzenle_Load(object sender, EventArgs e)
        {
            id.Text = ilan.ilan_id.ToString();
            setTextsValues();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.setUser(user);
            this.Hide();
            panel.Show();
        }

    }
}
