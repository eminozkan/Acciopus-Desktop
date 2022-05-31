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
    internal partial class AddUser : Form
    {

        User.User activeUser = new User.User();
        public AddUser()
        {
            InitializeComponent();
        }



        Boolean isPasswordVisible = false;

        public void setUser(User.User user)
        {
            this.activeUser = user;
        }

        private void kullanici_ekle_Click(object sender, EventArgs e)
        {
            Boolean isAnyFieldEmpty = !((ad.Text.Length > 0) || (soyad.Text.Length > 0) || (parola.Text.Length > 0) || (mail.Text.Length > 0) || (telefon.Text.Length > 0) || (dateTimePicker1.Value != null) || (radioButton1.Checked || radioButton2.Checked));

            if (!isAnyFieldEmpty)
            {

                SqlCommand command = new SqlCommand("insert into Kullanici (kullanici_adi,kullanici_soyadi,kullanici_parola,kullanici_mail,kullanici_telefon,kullanici_dogum_tarihi,kullanici_tip_id,kullanici_kayit_tarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)");

                int tip = -1;
                command.Parameters.AddWithValue("@p1", ad.Text);
                command.Parameters.AddWithValue("@p2", soyad.Text);
                command.Parameters.AddWithValue("@p3", Encryption.Encryption.EncryptPassword(parola.Text));
                command.Parameters.AddWithValue("@p4", mail.Text);
                command.Parameters.AddWithValue("@p5", telefon.Text);
                command.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
                if (radioButton1.Checked)
                {
                    tip = 4;
                }
                else if (radioButton2.Checked)
                {
                    tip = 5;
                }
                command.Parameters.AddWithValue("@p7", tip);
                command.Parameters.AddWithValue("@p8", DateTime.Now);

                SqlCommandStatements state = App.sendSqlCommand(command);
                if(state == SqlCommandStatements.Success)
                {
                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminPanel panel = new AdminPanel();
                    panel.setUser(activeUser);
                    panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş alan olmamalıdır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.setUser(activeUser);
            panel.Show();
            this.Hide();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void new_pass_visible_Click(object sender, EventArgs e)
        {
            
            if (!isPasswordVisible)
            {
                parola.UseSystemPasswordChar = false;
                isPasswordVisible = true;
            }
            else
            {
                parola.UseSystemPasswordChar = true;
                isPasswordVisible = false;
            }
        }
    }
}
