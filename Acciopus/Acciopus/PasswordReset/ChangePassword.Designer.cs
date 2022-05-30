
namespace Acciopus.PasswordReset
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.sifre_yenile = new System.Windows.Forms.Panel();
            this.iptal = new System.Windows.Forms.Panel();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.new_pass_r = new System.Windows.Forms.TextBox();
            this.old_pass_visible = new System.Windows.Forms.Panel();
            this.new_pass_visible = new System.Windows.Forms.Panel();
            this.new_pass_r_visible = new System.Windows.Forms.Panel();
            this.generate_pass = new System.Windows.Forms.Panel();
            this.captcha_label = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // sifre_yenile
            // 
            this.sifre_yenile.BackColor = System.Drawing.Color.Transparent;
            this.sifre_yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifre_yenile.Location = new System.Drawing.Point(298, 504);
            this.sifre_yenile.Name = "sifre_yenile";
            this.sifre_yenile.Size = new System.Drawing.Size(147, 57);
            this.sifre_yenile.TabIndex = 0;
            this.sifre_yenile.Click += new System.EventHandler(this.sifre_yenile_Click);
            // 
            // iptal
            // 
            this.iptal.BackColor = System.Drawing.Color.Transparent;
            this.iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iptal.Location = new System.Drawing.Point(99, 504);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(147, 57);
            this.iptal.TabIndex = 1;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // old_pass
            // 
            this.old_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.old_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.old_pass.Location = new System.Drawing.Point(175, 217);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(208, 20);
            this.old_pass.TabIndex = 2;
            this.old_pass.UseSystemPasswordChar = true;
            // 
            // new_pass
            // 
            this.new_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_pass.Location = new System.Drawing.Point(175, 304);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(183, 20);
            this.new_pass.TabIndex = 3;
            this.new_pass.UseSystemPasswordChar = true;
            // 
            // new_pass_r
            // 
            this.new_pass_r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_pass_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_pass_r.Location = new System.Drawing.Point(175, 363);
            this.new_pass_r.Name = "new_pass_r";
            this.new_pass_r.Size = new System.Drawing.Size(208, 20);
            this.new_pass_r.TabIndex = 4;
            this.new_pass_r.UseSystemPasswordChar = true;
            // 
            // old_pass_visible
            // 
            this.old_pass_visible.BackColor = System.Drawing.Color.Transparent;
            this.old_pass_visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.old_pass_visible.Location = new System.Drawing.Point(402, 214);
            this.old_pass_visible.Name = "old_pass_visible";
            this.old_pass_visible.Size = new System.Drawing.Size(30, 30);
            this.old_pass_visible.TabIndex = 5;
            this.old_pass_visible.Click += new System.EventHandler(this.old_pass_visible_Click);
            // 
            // new_pass_visible
            // 
            this.new_pass_visible.BackColor = System.Drawing.Color.Transparent;
            this.new_pass_visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_pass_visible.Location = new System.Drawing.Point(402, 301);
            this.new_pass_visible.Name = "new_pass_visible";
            this.new_pass_visible.Size = new System.Drawing.Size(30, 30);
            this.new_pass_visible.TabIndex = 6;
            this.new_pass_visible.Click += new System.EventHandler(this.new_pass_visible_Click);
            // 
            // new_pass_r_visible
            // 
            this.new_pass_r_visible.BackColor = System.Drawing.Color.Transparent;
            this.new_pass_r_visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_pass_r_visible.Location = new System.Drawing.Point(402, 357);
            this.new_pass_r_visible.Name = "new_pass_r_visible";
            this.new_pass_r_visible.Size = new System.Drawing.Size(30, 30);
            this.new_pass_r_visible.TabIndex = 7;
            this.new_pass_r_visible.Click += new System.EventHandler(this.new_pass_r_visible_Click);
            // 
            // generate_pass
            // 
            this.generate_pass.BackColor = System.Drawing.Color.Transparent;
            this.generate_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_pass.Location = new System.Drawing.Point(363, 299);
            this.generate_pass.Name = "generate_pass";
            this.generate_pass.Size = new System.Drawing.Size(30, 30);
            this.generate_pass.TabIndex = 7;
            this.toolTip1.SetToolTip(this.generate_pass, "Parola oluşturmak için tıklayınız.");
            this.generate_pass.Click += new System.EventHandler(this.generate_pass_Click);
            // 
            // captcha_label
            // 
            this.captcha_label.AutoSize = true;
            this.captcha_label.BackColor = System.Drawing.Color.Transparent;
            this.captcha_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.captcha_label.Location = new System.Drawing.Point(71, 440);
            this.captcha_label.Name = "captcha_label";
            this.captcha_label.Size = new System.Drawing.Size(92, 25);
            this.captcha_label.TabIndex = 8;
            this.captcha_label.Text = "Captcha";
            // 
            // captcha
            // 
            this.captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.captcha.Location = new System.Drawing.Point(169, 440);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(184, 29);
            this.captcha.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(463, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 24);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acciopus.Properties.Resources.password_change;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.captcha_label);
            this.Controls.Add(this.generate_pass);
            this.Controls.Add(this.new_pass_r_visible);
            this.Controls.Add(this.new_pass_visible);
            this.Controls.Add(this.old_pass_visible);
            this.Controls.Add(this.new_pass_r);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.iptal);
            this.Controls.Add(this.sifre_yenile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sifre_yenile;
        private System.Windows.Forms.Panel iptal;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.TextBox new_pass_r;
        private System.Windows.Forms.Panel old_pass_visible;
        private System.Windows.Forms.Panel new_pass_visible;
        private System.Windows.Forms.Panel new_pass_r_visible;
        private System.Windows.Forms.Panel generate_pass;
        private System.Windows.Forms.Label captcha_label;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}