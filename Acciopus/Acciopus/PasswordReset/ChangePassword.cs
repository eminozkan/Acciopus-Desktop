using Aspose.Cells.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.PasswordReset
{
    public partial class ChangePassword : Form
    {

        public int ID = -1;

        Boolean isOldPassVisible = false;
        Boolean isNewPassVisible = false;
        Boolean isNewPassRVisible = false;
        private static char[] characters = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int CaptchaResult;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void createCaptcha()
        {
            int num1, num2;
            Random rnd = new Random();

            num1 = rnd.Next(0, 70);
            num2 = rnd.Next(0, 20);

            CaptchaResult = num1 + num2;

            captcha_label.Text = num1.ToString() + " + " + num2.ToString() + "=";

           
        }

        private void old_pass_visible_Click(object sender, EventArgs e)
        {
            if (!isOldPassVisible)
            {
                old_pass.UseSystemPasswordChar = false;
                isOldPassVisible = true;
            }
            else
            {
                old_pass.UseSystemPasswordChar = true;
                isOldPassVisible = false;
            }
        }

        private void new_pass_visible_Click(object sender, EventArgs e)
        {
            if (!isNewPassVisible)
            {
                new_pass.UseSystemPasswordChar = false;
                isNewPassVisible = true;
            }
            else
            {
                new_pass.UseSystemPasswordChar = true;
                isNewPassVisible = false;
            }
        }

        private void new_pass_r_visible_Click(object sender, EventArgs e)
        {
            if (!isNewPassRVisible)
            {
                new_pass_r.UseSystemPasswordChar = false;
                isNewPassRVisible = true;
            }
            else
            {
                new_pass_r.UseSystemPasswordChar = true;
                isNewPassRVisible = false;
            }
        }

        private void generate_pass_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                int number = Convert.ToInt32(rnd.Next(0, 67));
                sb.Append(characters[number]);
            }

            new_pass.Text = sb.ToString();
            new_pass_r.Text = sb.ToString();
        }

        private void sifre_yenile_Click(object sender, EventArgs e)
        {
            if (captcha.Text.Equals(CaptchaResult.ToString()))
            {
                OldPasswordStatements state = PasswordFunctions.CheckPassword(ID, old_pass.Text);
                if (state == OldPasswordStatements.NotSame)
                {
                    MessageBox.Show("Eski şifrenizi yanlış girdiniz!");
                }
                else
                {
                    PasswordChangeStatements newPassState = PasswordFunctions.ChangePassword(ID, new_pass.Text);
                    if(newPassState == PasswordChangeStatements.Success)
                    {
                        MessageBox.Show("Şifreniz başarıyla değiştirildi!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hata!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Doğrulama işlemini yanlış yaptınız!");

                createCaptcha();
            }

            
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            createCaptcha();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
