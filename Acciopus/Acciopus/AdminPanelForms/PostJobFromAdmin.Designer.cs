
namespace Acciopus.AdminPanelForms
{
    partial class PostJobFromAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostJobFromAdmin));
            this.ilan_ekle = new System.Windows.Forms.Panel();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.tecrube = new System.Windows.Forms.ComboBox();
            this.maas = new System.Windows.Forms.TextBox();
            this.meslek = new System.Windows.Forms.ComboBox();
            this.baslik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firma_adi = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ilan_ekle
            // 
            this.ilan_ekle.BackColor = System.Drawing.Color.Transparent;
            this.ilan_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_ekle.Location = new System.Drawing.Point(278, 432);
            this.ilan_ekle.Name = "ilan_ekle";
            this.ilan_ekle.Size = new System.Drawing.Size(175, 57);
            this.ilan_ekle.TabIndex = 26;
            this.ilan_ekle.Click += new System.EventHandler(this.ilan_ekle_Click);
            // 
            // aciklama
            // 
            this.aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aciklama.Location = new System.Drawing.Point(442, 305);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(155, 96);
            this.aciklama.TabIndex = 25;
            this.aciklama.Text = "";
            // 
            // tecrube
            // 
            this.tecrube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tecrube.FormattingEnabled = true;
            this.tecrube.Items.AddRange(new object[] {
            "Lütfen birini seçiniz!",
            "Stajyer",
            "0-1 Yıl",
            "1-3 Yıl",
            "3-5 Yıl",
            "5+"});
            this.tecrube.Location = new System.Drawing.Point(443, 245);
            this.tecrube.Name = "tecrube";
            this.tecrube.Size = new System.Drawing.Size(152, 26);
            this.tecrube.TabIndex = 24;
            // 
            // maas
            // 
            this.maas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maas.Location = new System.Drawing.Point(440, 175);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(152, 19);
            this.maas.TabIndex = 23;
            // 
            // meslek
            // 
            this.meslek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.meslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meslek.FormattingEnabled = true;
            this.meslek.Location = new System.Drawing.Point(152, 318);
            this.meslek.Name = "meslek";
            this.meslek.Size = new System.Drawing.Size(152, 26);
            this.meslek.TabIndex = 22;
            // 
            // baslik
            // 
            this.baslik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(152, 250);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(152, 19);
            this.baslik.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(346, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Açıklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(346, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tecrübe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(370, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Aranan Meslek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Başlık:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firma Adı:";
            // 
            // firma_adi
            // 
            this.firma_adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firma_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firma_adi.Location = new System.Drawing.Point(152, 178);
            this.firma_adi.Name = "firma_adi";
            this.firma_adi.Size = new System.Drawing.Size(152, 19);
            this.firma_adi.TabIndex = 14;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(663, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 24);
            this.exit.TabIndex = 27;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // PostJobFromAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acciopus.Properties.Resources.ilan_ekle;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ilan_ekle);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.tecrube);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.meslek);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firma_adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PostJobFromAdmin";
            this.Text = "PostJobFromAdmin";
            this.Load += new System.EventHandler(this.PostJobFromAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ilan_ekle;
        private System.Windows.Forms.RichTextBox aciklama;
        private System.Windows.Forms.ComboBox tecrube;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.ComboBox meslek;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firma_adi;
        private System.Windows.Forms.Label exit;
    }
}