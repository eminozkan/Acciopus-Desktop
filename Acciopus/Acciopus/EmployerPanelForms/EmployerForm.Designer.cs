
namespace Acciopus.EmployerPanelForms
{
    partial class EmployerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifre_degis = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.bugBildir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ilanlar = new System.Windows.Forms.TabPage();
            this.add_post = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.basvurular = new System.Windows.Forms.TabPage();
            this.reddet = new System.Windows.Forms.Panel();
            this.onayla = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ilanlarim = new System.Windows.Forms.TabPage();
            this.ilan_sil = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ilanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.basvurular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ilanlarim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(1210, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 77);
            this.panel3.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifre_degis,
            this.cikis,
            this.bugBildir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // sifre_degis
            // 
            this.sifre_degis.Image = global::Acciopus.Properties.Resources.change_pass_icon2;
            this.sifre_degis.Name = "sifre_degis";
            this.sifre_degis.Size = new System.Drawing.Size(180, 22);
            this.sifre_degis.Text = "Şifre Değiştir";
            this.sifre_degis.Click += new System.EventHandler(this.sifre_degis_Click);
            // 
            // cikis
            // 
            this.cikis.Image = global::Acciopus.Properties.Resources.exit_icon;
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(180, 22);
            this.cikis.Text = "Çıkış Yap!";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // bugBildir
            // 
            this.bugBildir.Image = global::Acciopus.Properties.Resources.bug;
            this.bugBildir.Name = "bugBildir";
            this.bugBildir.Size = new System.Drawing.Size(180, 22);
            this.bugBildir.Text = "Hata Bildir!";
            this.bugBildir.Click += new System.EventHandler(this.bugBildir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 56);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ilanlar);
            this.tabControl1.Controls.Add(this.basvurular);
            this.tabControl1.Controls.Add(this.ilanlarim);
            this.tabControl1.Location = new System.Drawing.Point(2, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 637);
            this.tabControl1.TabIndex = 13;
            // 
            // ilanlar
            // 
            this.ilanlar.BackColor = System.Drawing.Color.Salmon;
            this.ilanlar.BackgroundImage = global::Acciopus.Properties.Resources.ilanlar;
            this.ilanlar.Controls.Add(this.add_post);
            this.ilanlar.Controls.Add(this.dataGridView1);
            this.ilanlar.Location = new System.Drawing.Point(4, 22);
            this.ilanlar.Name = "ilanlar";
            this.ilanlar.Padding = new System.Windows.Forms.Padding(3);
            this.ilanlar.Size = new System.Drawing.Size(1258, 611);
            this.ilanlar.TabIndex = 0;
            this.ilanlar.Text = "İlanlar";
            // 
            // add_post
            // 
            this.add_post.BackColor = System.Drawing.Color.Transparent;
            this.add_post.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_post.Location = new System.Drawing.Point(1004, 503);
            this.add_post.Name = "add_post";
            this.add_post.Size = new System.Drawing.Size(152, 65);
            this.add_post.TabIndex = 2;
            this.add_post.Click += new System.EventHandler(this.add_post_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1192, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // basvurular
            // 
            this.basvurular.BackColor = System.Drawing.Color.Salmon;
            this.basvurular.BackgroundImage = global::Acciopus.Properties.Resources.basvurular;
            this.basvurular.Controls.Add(this.reddet);
            this.basvurular.Controls.Add(this.onayla);
            this.basvurular.Controls.Add(this.dataGridView2);
            this.basvurular.Location = new System.Drawing.Point(4, 22);
            this.basvurular.Name = "basvurular";
            this.basvurular.Padding = new System.Windows.Forms.Padding(3);
            this.basvurular.Size = new System.Drawing.Size(1258, 611);
            this.basvurular.TabIndex = 1;
            this.basvurular.Text = "Başvurular";
            // 
            // reddet
            // 
            this.reddet.BackColor = System.Drawing.Color.Transparent;
            this.reddet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reddet.Location = new System.Drawing.Point(1029, 341);
            this.reddet.Name = "reddet";
            this.reddet.Size = new System.Drawing.Size(138, 52);
            this.reddet.TabIndex = 4;
            this.reddet.Click += new System.EventHandler(this.reddet_Click);
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.Transparent;
            this.onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onayla.Location = new System.Drawing.Point(1030, 185);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(138, 52);
            this.onayla.TabIndex = 3;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 469);
            this.dataGridView2.TabIndex = 0;
            // 
            // ilanlarim
            // 
            this.ilanlarim.BackgroundImage = global::Acciopus.Properties.Resources.basvuru_tab2;
            this.ilanlarim.Controls.Add(this.ilan_sil);
            this.ilanlarim.Controls.Add(this.dataGridView3);
            this.ilanlarim.Location = new System.Drawing.Point(4, 22);
            this.ilanlarim.Name = "ilanlarim";
            this.ilanlarim.Size = new System.Drawing.Size(1258, 611);
            this.ilanlarim.TabIndex = 2;
            this.ilanlarim.Text = "İlanlarım";
            this.ilanlarim.UseVisualStyleBackColor = true;
            // 
            // ilan_sil
            // 
            this.ilan_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_sil.Location = new System.Drawing.Point(1026, 292);
            this.ilan_sil.Name = "ilan_sil";
            this.ilan_sil.Size = new System.Drawing.Size(143, 53);
            this.ilan_sil.TabIndex = 1;
            this.ilan_sil.Click += new System.EventHandler(this.ilan_sil_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(857, 463);
            this.dataGridView3.TabIndex = 0;
            // 
            // EmployerForm
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
            this.Name = "EmployerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployerForm";
            this.Load += new System.EventHandler(this.EmployerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ilanlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.basvurular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ilanlarim.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage ilanlar;
        private System.Windows.Forms.TabPage basvurular;
        private System.Windows.Forms.TabPage ilanlarim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel add_post;
        private System.Windows.Forms.Panel onayla;
        private System.Windows.Forms.Panel reddet;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel ilan_sil;
    }
}