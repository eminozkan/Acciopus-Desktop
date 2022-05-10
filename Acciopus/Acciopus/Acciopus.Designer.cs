
namespace Acciopus
{
    partial class Acciopus
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acciopus));
            this.activePanel = new System.Windows.Forms.Panel();
            this.giris = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.giris_button = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.kayit = new System.Windows.Forms.Panel();
            this.kayitbutton = new System.Windows.Forms.Button();
            this.telefontb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.parolatekrartb = new System.Windows.Forms.TextBox();
            this.parolatb = new System.Windows.Forms.TextBox();
            this.soyisimtb = new System.Windows.Forms.TextBox();
            this.isimtb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hakkinda = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iletisim = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.anasayfa_lbl = new System.Windows.Forms.Label();
            this.hakkinda_lbl = new System.Windows.Forms.Label();
            this.iletisim_lbl = new System.Windows.Forms.Label();
            this.giris_lbl = new System.Windows.Forms.Label();
            this.giris.SuspendLayout();
            this.kayit.SuspendLayout();
            this.anasayfa.SuspendLayout();
            this.hakkinda.SuspendLayout();
            this.iletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.Transparent;
            this.activePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activePanel.Location = new System.Drawing.Point(212, 60);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(600, 500);
            this.activePanel.TabIndex = 0;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Transparent;
            this.giris.BackgroundImage = global::Acciopus.Properties.Resources.login2;
            this.giris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.giris.Controls.Add(this.linkLabel1);
            this.giris.Controls.Add(this.label4);
            this.giris.Controls.Add(this.giris_button);
            this.giris.Controls.Add(this.password);
            this.giris.Controls.Add(this.email);
            this.giris.Location = new System.Drawing.Point(1006, 64);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(600, 500);
            this.giris.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.Location = new System.Drawing.Point(245, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "tıklayınız...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üye olmak için";
            // 
            // giris_button
            // 
            this.giris_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_button.Location = new System.Drawing.Point(243, 372);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(106, 32);
            this.giris_button.TabIndex = 2;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(232, 339);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(168, 22);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(232, 284);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 22);
            this.email.TabIndex = 0;
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.Transparent;
            this.kayit.BackgroundImage = global::Acciopus.Properties.Resources.signup1;
            this.kayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kayit.Controls.Add(this.kayitbutton);
            this.kayit.Controls.Add(this.telefontb);
            this.kayit.Controls.Add(this.emailtb);
            this.kayit.Controls.Add(this.parolatekrartb);
            this.kayit.Controls.Add(this.parolatb);
            this.kayit.Controls.Add(this.soyisimtb);
            this.kayit.Controls.Add(this.isimtb);
            this.kayit.Controls.Add(this.dateTimePicker1);
            this.kayit.Controls.Add(this.label17);
            this.kayit.Controls.Add(this.tip);
            this.kayit.Controls.Add(this.label16);
            this.kayit.Controls.Add(this.label15);
            this.kayit.Controls.Add(this.label14);
            this.kayit.Controls.Add(this.label13);
            this.kayit.Controls.Add(this.label11);
            this.kayit.Controls.Add(this.label6);
            this.kayit.Controls.Add(this.label5);
            this.kayit.Location = new System.Drawing.Point(972, 451);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(600, 500);
            this.kayit.TabIndex = 1;
            // 
            // kayitbutton
            // 
            this.kayitbutton.Location = new System.Drawing.Point(282, 431);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.Size = new System.Drawing.Size(79, 23);
            this.kayitbutton.TabIndex = 16;
            this.kayitbutton.Text = "Kayıt Ol";
            this.kayitbutton.UseVisualStyleBackColor = true;
            // 
            // telefontb
            // 
            this.telefontb.Location = new System.Drawing.Point(397, 290);
            this.telefontb.Name = "telefontb";
            this.telefontb.Size = new System.Drawing.Size(114, 20);
            this.telefontb.TabIndex = 15;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(156, 293);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(117, 20);
            this.emailtb.TabIndex = 14;
            // 
            // parolatekrartb
            // 
            this.parolatekrartb.Location = new System.Drawing.Point(397, 240);
            this.parolatekrartb.Name = "parolatekrartb";
            this.parolatekrartb.Size = new System.Drawing.Size(114, 20);
            this.parolatekrartb.TabIndex = 13;
            // 
            // parolatb
            // 
            this.parolatb.Location = new System.Drawing.Point(156, 237);
            this.parolatb.Name = "parolatb";
            this.parolatb.Size = new System.Drawing.Size(117, 20);
            this.parolatb.TabIndex = 12;
            // 
            // soyisimtb
            // 
            this.soyisimtb.Location = new System.Drawing.Point(397, 187);
            this.soyisimtb.Name = "soyisimtb";
            this.soyisimtb.Size = new System.Drawing.Size(114, 20);
            this.soyisimtb.TabIndex = 11;
            // 
            // isimtb
            // 
            this.isimtb.Location = new System.Drawing.Point(154, 187);
            this.isimtb.Name = "isimtb";
            this.isimtb.Size = new System.Drawing.Size(119, 20);
            this.isimtb.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 347);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(195, 386);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "Üye Tipi :";
            // 
            // tip
            // 
            this.tip.FormattingEnabled = true;
            this.tip.Location = new System.Drawing.Point(275, 386);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(121, 21);
            this.tip.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(159, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "Doğum Tarihi :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(326, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Telefon :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(97, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Email :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(279, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Parola(Tekrar) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(91, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Parola :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(322, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Soyisim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(107, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "İsim :";
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Transparent;
            this.anasayfa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anasayfa.Controls.Add(this.label3);
            this.anasayfa.Controls.Add(this.label2);
            this.anasayfa.Controls.Add(this.label1);
            this.anasayfa.Location = new System.Drawing.Point(1006, 516);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(600, 500);
            this.anasayfa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 180);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acciopus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anasayfa";
            // 
            // hakkinda
            // 
            this.hakkinda.BackColor = System.Drawing.Color.Transparent;
            this.hakkinda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hakkinda.Controls.Add(this.label7);
            this.hakkinda.Controls.Add(this.label8);
            this.hakkinda.Controls.Add(this.label9);
            this.hakkinda.Location = new System.Drawing.Point(632, 566);
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(600, 500);
            this.hakkinda.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(502, 220);
            this.label7.TabIndex = 2;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(268, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Acciopus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Proje Hakkında";
            // 
            // iletisim
            // 
            this.iletisim.BackColor = System.Drawing.Color.Transparent;
            this.iletisim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iletisim.Controls.Add(this.label10);
            this.iletisim.Controls.Add(this.label12);
            this.iletisim.Location = new System.Drawing.Point(12, 566);
            this.iletisim.Name = "iletisim";
            this.iletisim.Size = new System.Drawing.Size(600, 500);
            this.iletisim.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 160);
            this.label10.TabIndex = 2;
            this.label10.Text = "İsim : Muhammet Emin Özkan\r\n\r\nÖğrenci Numarası : 202503049\r\n\r\nMail Adresi : info@" +
    "eminozkan.net\r\n\r\nTelefon : 0 535 062 49 14\r\n\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "İletişim";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(995, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 6;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(968, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(19, 20);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // anasayfa_lbl
            // 
            this.anasayfa_lbl.AutoSize = true;
            this.anasayfa_lbl.BackColor = System.Drawing.Color.Transparent;
            this.anasayfa_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfa_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa_lbl.ForeColor = System.Drawing.Color.White;
            this.anasayfa_lbl.Location = new System.Drawing.Point(360, 9);
            this.anasayfa_lbl.Name = "anasayfa_lbl";
            this.anasayfa_lbl.Size = new System.Drawing.Size(84, 20);
            this.anasayfa_lbl.TabIndex = 8;
            this.anasayfa_lbl.Text = "Anasayfa";
            this.anasayfa_lbl.Click += new System.EventHandler(this.anasayfa_lbl_Click);
            // 
            // hakkinda_lbl
            // 
            this.hakkinda_lbl.AutoSize = true;
            this.hakkinda_lbl.BackColor = System.Drawing.Color.Transparent;
            this.hakkinda_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hakkinda_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkinda_lbl.ForeColor = System.Drawing.Color.White;
            this.hakkinda_lbl.Location = new System.Drawing.Point(463, 9);
            this.hakkinda_lbl.Name = "hakkinda_lbl";
            this.hakkinda_lbl.Size = new System.Drawing.Size(130, 20);
            this.hakkinda_lbl.TabIndex = 9;
            this.hakkinda_lbl.Text = "Proje Hakkında";
            this.hakkinda_lbl.Click += new System.EventHandler(this.hakkinda_lbl_Click);
            // 
            // iletisim_lbl
            // 
            this.iletisim_lbl.AutoSize = true;
            this.iletisim_lbl.BackColor = System.Drawing.Color.Transparent;
            this.iletisim_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iletisim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iletisim_lbl.ForeColor = System.Drawing.Color.White;
            this.iletisim_lbl.Location = new System.Drawing.Point(616, 9);
            this.iletisim_lbl.Name = "iletisim_lbl";
            this.iletisim_lbl.Size = new System.Drawing.Size(66, 20);
            this.iletisim_lbl.TabIndex = 10;
            this.iletisim_lbl.Text = "İletişim";
            this.iletisim_lbl.Click += new System.EventHandler(this.iletisim_lbl_Click);
            // 
            // giris_lbl
            // 
            this.giris_lbl.AutoSize = true;
            this.giris_lbl.BackColor = System.Drawing.Color.Transparent;
            this.giris_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_lbl.ForeColor = System.Drawing.Color.White;
            this.giris_lbl.Location = new System.Drawing.Point(813, 13);
            this.giris_lbl.Name = "giris_lbl";
            this.giris_lbl.Size = new System.Drawing.Size(114, 16);
            this.giris_lbl.TabIndex = 11;
            this.giris_lbl.Text = "Giriş Yap / Üye Ol";
            this.giris_lbl.Click += new System.EventHandler(this.giris_lbl_Click);
            // 
            // Acciopus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acciopus.Properties.Resources.background_test1;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.giris_lbl);
            this.Controls.Add(this.iletisim_lbl);
            this.Controls.Add(this.hakkinda_lbl);
            this.Controls.Add(this.anasayfa_lbl);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.iletisim);
            this.Controls.Add(this.hakkinda);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.activePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acciopus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciopus";
            this.Load += new System.EventHandler(this.Acciopus_Load);
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.kayit.ResumeLayout(false);
            this.kayit.PerformLayout();
            this.anasayfa.ResumeLayout(false);
            this.anasayfa.PerformLayout();
            this.hakkinda.ResumeLayout(false);
            this.hakkinda.PerformLayout();
            this.iletisim.ResumeLayout(false);
            this.iletisim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Panel anasayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel hakkinda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel iletisim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label anasayfa_lbl;
        private System.Windows.Forms.Label hakkinda_lbl;
        private System.Windows.Forms.Label iletisim_lbl;
        private System.Windows.Forms.Panel giris;
        private System.Windows.Forms.Label giris_lbl;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel giris_button;
        private System.Windows.Forms.Panel kayit;
        private System.Windows.Forms.Button kayitbutton;
        private System.Windows.Forms.TextBox telefontb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox parolatekrartb;
        private System.Windows.Forms.TextBox parolatb;
        private System.Windows.Forms.TextBox soyisimtb;
        private System.Windows.Forms.TextBox isimtb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox tip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

