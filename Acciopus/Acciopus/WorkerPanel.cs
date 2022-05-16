using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus
{
    internal partial class WorkerPanel : Form
    {
        private User.User activeUser = new User.User();
        private Boolean isUserMovingTab = false;
        Point MoveLocation = new Point(); 
        
        public WorkerPanel()
        {
            InitializeComponent();
            
        }

        public void setUser(User.User usr)
        {
            activeUser = usr;
        }


        private void setDataGridView1Settings()
        {
            ArrayList d1ColumnsName = new ArrayList();
            d1ColumnsName.Add("İlan ID");
            d1ColumnsName.Add("İlan Başlığı");
            d1ColumnsName.Add("Firma Adı");
            d1ColumnsName.Add("Aranan Meslek");
            d1ColumnsName.Add("Açıklama");
            d1ColumnsName.Add("Teklif Edilen Maaş");
            d1ColumnsName.Add("Aranan Tecrübe Süresi");
            d1ColumnsName.Add("İlan Tarihi");

            int index = 0;
            foreach (String text in d1ColumnsName)
            {
                dataGridView1.Columns[index].HeaderText = text;
                index++;
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 350;
            dataGridView1.Columns[7].Width = 123;

        }
        

        private void Mainpanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.StopSession();
            Application.Exit();
        }

        private void Mainpanel_Load(object sender, EventArgs e)
        {
            
            String sqlCommand = "Select ilan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Is_ilan as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id";
            App.FillDataGrid(sqlCommand, "Kullanici", dataGridView1);
            setDataGridView1Settings();




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void logoff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış Yapmak İstediginize emin misiniz?", "Çıkış Yap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                App.StopSession();
                Application.Exit();
            }
           

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = true;
                MoveLocation.X = e.X;
                MoveLocation.Y = e.Y;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isUserMovingTab)
            {
                this.Location = new Point(this.Location.X + (e.X - MoveLocation.X), this.Location.Y + (e.Y - MoveLocation.Y));
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isUserMovingTab = false;
            }
        }


    }
}
