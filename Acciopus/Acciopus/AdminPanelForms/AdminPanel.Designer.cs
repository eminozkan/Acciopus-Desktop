
namespace Acciopus.AdminPanelForms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifre_degis = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.bugBildir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kullanici_sil = new System.Windows.Forms.Panel();
            this.kullanici_ekle = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ilan_duzenle = new System.Windows.Forms.Panel();
            this.ilan_sil = new System.Windows.Forms.Panel();
            this.ilan_ekle = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.basvuru_sil = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hata_sil = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(1210, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 77);
            this.panel3.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifre_degis,
            this.cikis,
            this.bugBildir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // sifre_degis
            // 
            this.sifre_degis.Image = global::Acciopus.Properties.Resources.change_pass_icon2;
            this.sifre_degis.Name = "sifre_degis";
            this.sifre_degis.Size = new System.Drawing.Size(140, 22);
            this.sifre_degis.Text = "Şifre Değiştir";
            this.sifre_degis.Click += new System.EventHandler(this.sifre_degis_Click);
            // 
            // cikis
            // 
            this.cikis.Image = global::Acciopus.Properties.Resources.exit_icon;
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(140, 22);
            this.cikis.Text = "Çıkış Yap!";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // bugBildir
            // 
            this.bugBildir.Image = global::Acciopus.Properties.Resources.bug;
            this.bugBildir.Name = "bugBildir";
            this.bugBildir.Size = new System.Drawing.Size(140, 22);
            this.bugBildir.Text = "Hata Bildir!";
            this.bugBildir.Click += new System.EventHandler(this.bugBildir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 56);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 637);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Acciopus.Properties.Resources.admin_kullanici;
            this.tabPage1.Controls.Add(this.kullanici_sil);
            this.tabPage1.Controls.Add(this.kullanici_ekle);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1258, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kullanici_sil
            // 
            this.kullanici_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullanici_sil.Location = new System.Drawing.Point(1042, 336);
            this.kullanici_sil.Name = "kullanici_sil";
            this.kullanici_sil.Size = new System.Drawing.Size(171, 55);
            this.kullanici_sil.TabIndex = 2;
            this.kullanici_sil.Click += new System.EventHandler(this.kullanici_sil_Click);
            // 
            // kullanici_ekle
            // 
            this.kullanici_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kullanici_ekle.Location = new System.Drawing.Point(1031, 200);
            this.kullanici_ekle.Name = "kullanici_ekle";
            this.kullanici_ekle.Size = new System.Drawing.Size(171, 55);
            this.kullanici_ekle.TabIndex = 1;
            this.kullanici_ekle.Click += new System.EventHandler(this.kullanici_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Acciopus.Properties.Resources.admin_ilanlar;
            this.tabPage2.Controls.Add(this.ilan_duzenle);
            this.tabPage2.Controls.Add(this.ilan_sil);
            this.tabPage2.Controls.Add(this.ilan_ekle);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1258, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İlanlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ilan_duzenle
            // 
            this.ilan_duzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_duzenle.Location = new System.Drawing.Point(1044, 264);
            this.ilan_duzenle.Name = "ilan_duzenle";
            this.ilan_duzenle.Size = new System.Drawing.Size(168, 57);
            this.ilan_duzenle.TabIndex = 3;
            this.ilan_duzenle.Click += new System.EventHandler(this.ilan_duzenle_Click);
            // 
            // ilan_sil
            // 
            this.ilan_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_sil.Location = new System.Drawing.Point(1044, 371);
            this.ilan_sil.Name = "ilan_sil";
            this.ilan_sil.Size = new System.Drawing.Size(168, 57);
            this.ilan_sil.TabIndex = 2;
            this.ilan_sil.Click += new System.EventHandler(this.ilan_sil_Click);
            // 
            // ilan_ekle
            // 
            this.ilan_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_ekle.Location = new System.Drawing.Point(1044, 157);
            this.ilan_ekle.Name = "ilan_ekle";
            this.ilan_ekle.Size = new System.Drawing.Size(168, 57);
            this.ilan_ekle.TabIndex = 1;
            this.ilan_ekle.Click += new System.EventHandler(this.ilan_ekle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(960, 518);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Acciopus.Properties.Resources.admin_basvurular;
            this.tabPage4.Controls.Add(this.basvuru_sil);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1258, 611);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Başvurular";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // basvuru_sil
            // 
            this.basvuru_sil.Location = new System.Drawing.Point(1050, 260);
            this.basvuru_sil.Name = "basvuru_sil";
            this.basvuru_sil.Size = new System.Drawing.Size(159, 65);
            this.basvuru_sil.TabIndex = 1;
            this.basvuru_sil.Click += new System.EventHandler(this.basvuru_sil_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(44, 60);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(905, 499);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Acciopus.Properties.Resources.themecolor;
            this.tabPage3.Controls.Add(this.hata_sil);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1258, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hatalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hata_sil
            // 
            this.hata_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata_sil.Location = new System.Drawing.Point(815, 249);
            this.hata_sil.Name = "hata_sil";
            this.hata_sil.Size = new System.Drawing.Size(118, 63);
            this.hata_sil.TabIndex = 1;
            this.hata_sil.Text = "Hata Raporunu Sil";
            this.hata_sil.UseVisualStyleBackColor = true;
            this.hata_sil.Click += new System.EventHandler(this.hata_sil_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(328, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(403, 522);
            this.dataGridView3.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acciopus.Properties.Resources.kullanicibg1;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sifre_degis;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.ToolStripMenuItem bugBildir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel kullanici_ekle;
        private System.Windows.Forms.Panel kullanici_sil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel ilan_ekle;
        private System.Windows.Forms.Panel ilan_sil;
        private System.Windows.Forms.Panel ilan_duzenle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button hata_sil;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel basvuru_sil;
    }
}