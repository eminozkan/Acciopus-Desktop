
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baslik_rb = new System.Windows.Forms.RadioButton();
            this.firma_rb = new System.Windows.Forms.RadioButton();
            this.meslek_rb = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ilan_arama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Acciopus.Properties.Resources.themecolor;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.ilan_arama);
            this.tabPage1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Başvuru Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Salmon;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1271, 450);
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
            this.tabPage2.BackgroundImage = global::Acciopus.Properties.Resources.themecolor;
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Başvurularım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(850, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(850, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(850, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(153, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yapılacak İşlemi Seçiniz.",
            "Başvuruyu Düzelt",
            "Başvuruyu Sil"});
            this.comboBox1.Location = new System.Drawing.Point(1044, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(732, 490);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 56);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ilan_arama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton firma_rb;
        private System.Windows.Forms.RadioButton meslek_rb;
        private System.Windows.Forms.RadioButton baslik_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sifre_degis;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        private System.Windows.Forms.ToolStripMenuItem bugBildir;
    }
}