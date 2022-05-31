
namespace Acciopus.WorkerPanelForms
{
    partial class WorkerPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.basvuru = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baslik_rb = new System.Windows.Forms.RadioButton();
            this.firma_rb = new System.Windows.Forms.RadioButton();
            this.meslek_rb = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilan_arama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ilan_sil = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.basvuru_arama = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sifre_degis = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.bugBildir = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(2, 74);
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1279, 649);
            this.tabcontrol.TabIndex = 1;
            this.tabcontrol.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_SelectedIndexChanged);
            this.tabcontrol.TabIndexChanged += new System.EventHandler(this.tabcontrol_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Acciopus.Properties.Resources.basvuru_yap;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.basvuru);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.ilan_arama);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İlanlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // basvuru
            // 
            this.basvuru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basvuru.Location = new System.Drawing.Point(1085, 531);
            this.basvuru.Name = "basvuru";
            this.basvuru.Size = new System.Drawing.Size(135, 55);
            this.basvuru.TabIndex = 9;
            this.basvuru.Click += new System.EventHandler(this.basvuru_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baslik_rb);
            this.groupBox1.Controls.Add(this.firma_rb);
            this.groupBox1.Controls.Add(this.meslek_rb);
            this.groupBox1.Location = new System.Drawing.Point(972, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 42);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Filtresi Seçiniz";
            // 
            // baslik_rb
            // 
            this.baslik_rb.AutoSize = true;
            this.baslik_rb.Location = new System.Drawing.Point(100, 16);
            this.baslik_rb.Name = "baslik_rb";
            this.baslik_rb.Size = new System.Drawing.Size(53, 17);
            this.baslik_rb.TabIndex = 7;
            this.baslik_rb.TabStop = true;
            this.baslik_rb.Text = "Başlık";
            this.baslik_rb.UseVisualStyleBackColor = true;
            // 
            // firma_rb
            // 
            this.firma_rb.AutoSize = true;
            this.firma_rb.Location = new System.Drawing.Point(13, 16);
            this.firma_rb.Name = "firma_rb";
            this.firma_rb.Size = new System.Drawing.Size(68, 17);
            this.firma_rb.TabIndex = 5;
            this.firma_rb.TabStop = true;
            this.firma_rb.Text = "Firma Adı";
            this.firma_rb.UseVisualStyleBackColor = true;
            // 
            // meslek_rb
            // 
            this.meslek_rb.AutoSize = true;
            this.meslek_rb.Location = new System.Drawing.Point(171, 16);
            this.meslek_rb.Name = "meslek_rb";
            this.meslek_rb.Size = new System.Drawing.Size(77, 17);
            this.meslek_rb.TabIndex = 6;
            this.meslek_rb.TabStop = true;
            this.meslek_rb.Text = "Meslek Adı";
            this.meslek_rb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Acciopus.Properties.Resources._1024px_Search_Icon_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1080, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ilan_arama
            // 
            this.ilan_arama.Location = new System.Drawing.Point(1116, 62);
            this.ilan_arama.Name = "ilan_arama";
            this.ilan_arama.Size = new System.Drawing.Size(134, 20);
            this.ilan_arama.TabIndex = 3;
            this.ilan_arama.TextChanged += new System.EventHandler(this.ilan_arama_TextChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Salmon;
            this.dataGridView1.Location = new System.Drawing.Point(13, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1237, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-21, -94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 53);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Acciopus.Properties.Resources.basvuru_tab2;
            this.tabPage2.Controls.Add(this.ilan_sil);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.basvuru_arama);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Başvurularım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ilan_sil
            // 
            this.ilan_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ilan_sil.Location = new System.Drawing.Point(1025, 291);
            this.ilan_sil.Name = "ilan_sil";
            this.ilan_sil.Size = new System.Drawing.Size(143, 54);
            this.ilan_sil.TabIndex = 13;
            this.ilan_sil.Click += new System.EventHandler(this.ilan_sil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1039, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Firma Adı:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Acciopus.Properties.Resources._1024px_Search_Icon_svg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1042, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // basvuru_arama
            // 
            this.basvuru_arama.Location = new System.Drawing.Point(1078, 59);
            this.basvuru_arama.Name = "basvuru_arama";
            this.basvuru_arama.Size = new System.Drawing.Size(134, 20);
            this.basvuru_arama.TabIndex = 9;
            this.basvuru_arama.TextChanged += new System.EventHandler(this.basvuru_arama_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(951, 490);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 56);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(1210, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 77);
            this.panel3.TabIndex = 9;
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
            // WorkerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciopus Uygulaması";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainpanel_FormClosed);
            this.Load += new System.EventHandler(this.Mainpanel_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ilan_arama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton firma_rb;
        private System.Windows.Forms.RadioButton meslek_rb;
        private System.Windows.Forms.RadioButton baslik_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sifre_degis;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.ToolStripMenuItem bugBildir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox basvuru_arama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel basvuru;
        private System.Windows.Forms.Panel ilan_sil;
    }
}