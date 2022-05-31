using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.AdminPanelForms
{
    class DataGridViewFunctions
    { 
   
        private static String DataGridView1SqlString = "Select kullanici_id,kullanici_adi,kullanici_soyadi,kullanici_parola,kullanici_mail,kullanici_telefon,kullanici_dogum_tarihi,kullanici_tip,kullanici_kayit_tarihi from Kullanici INNER JOIN Kullanici_Tip ON Kullanici.kullanici_tip_id = Kullanici_Tip.kullanici_tip_id where kullanici_id != @p1";

        public static String getDataGrid1SqlString()
        {
            return DataGridView1SqlString;
        }

        public static void setDataGrid1Settings(DataGridView dgv)
        {
            ArrayList d1ColumnsName = new ArrayList();
            d1ColumnsName.Add("Kullanıcı ID");
            d1ColumnsName.Add("Kullanıcı Adı");
            d1ColumnsName.Add("Kullanıcı Soyadı");
            d1ColumnsName.Add("Kullanıcı Parola");
            d1ColumnsName.Add("Kullanıcı Mail");
            d1ColumnsName.Add("Kullanıcı Telefon");
            d1ColumnsName.Add("Doğum Tarihi");
            d1ColumnsName.Add("Kullanıcı Tipi");
            d1ColumnsName.Add("Kayıt Tarihi");

            int index = 0;
            foreach(String headername in d1ColumnsName)
            {
                dgv.Columns[index].HeaderText = headername;
                index++;
            }

            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Width = 120;
            dgv.Columns[5].Width = 120;
            dgv.Columns[6].Width = 120;
            dgv.Columns[8].Width = 120;


        }


        private static String DataGridView2SqlString = "Select ilan_id,ilan_firma_adi,ilan_baslik,ilan_aranan_meslek_id,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi,kullanici_id,kullanici_mail from Ilanlar INNER JOIN Meslekler ON Meslekler.meslek_id = ilan_aranan_meslek_id INNER JOIN Kullanici ON Kullanici.kullanici_id = ilan_paylasan_id";



        public static String getDataGridView2SqlString()
        {
            return DataGridView2SqlString;
        }


        public static void setDataGrid2Settings(DataGridView dgv)
        {
            ArrayList d2ColumnsName = new ArrayList();
            d2ColumnsName.Add("İlan ID");
            d2ColumnsName.Add("İlan Firma Adı");
            d2ColumnsName.Add("İlan Başlık");
            d2ColumnsName.Add("İlan Aranan meslek id");
            d2ColumnsName.Add("Meslek");
            d2ColumnsName.Add("Açıklama");
            d2ColumnsName.Add("Maaş");
            d2ColumnsName.Add("Tecrübe");
            d2ColumnsName.Add("Tarih");
            d2ColumnsName.Add("Ekleyen ID");
            d2ColumnsName.Add("Ekleyen Mail");


            int index = 0;
            foreach (String headername in d2ColumnsName)
            {
                dgv.Columns[index].HeaderText = headername;
                index++;
            }

            dgv.Columns[3].Visible = false;

            
        }


        private static String DataGrid3SqlString = "select * from Hatalar";

        public static String getDataGrid3SqlString()
        {
            return DataGrid3SqlString;
        }

        public static void setDataGrid3Settings(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Hata ID";
            dgv.Columns[1].HeaderText = "Hata Konusu";
            dgv.Columns[2].HeaderText = "Hata Mesajı";
        }


        private static String dataGridView4SqlString = "Select basvuru_id,kullanici_adi,kullanici_soyadi,kullanici_mail,kullanici_telefon,basvurulan_ilan_id,basvuru_aciklama,basvuru_tarihi,basvuru_durum from Basvuru INNER JOIN Kullanici ON basvuru_yapan_id = kullanici_id";


        public static String getDataGridView4SqlString()
        {
            return dataGridView4SqlString;
        }

        public static void setDataGridView4Settings(DataGridView dgv)
        {
            ArrayList dgvColumnsName = new ArrayList();
            dgvColumnsName.Add("Başvuru ID");
            dgvColumnsName.Add("Başvuran Adı");
            dgvColumnsName.Add("Başvuran Soyadı");
            dgvColumnsName.Add("Başvuran Mail");
            dgvColumnsName.Add("Başvuran Telefon");
            dgvColumnsName.Add("Başvurulan İlan ID");
            dgvColumnsName.Add("Başvuru Açıklama");
            dgvColumnsName.Add("Başvuru Tarihi");
            dgvColumnsName.Add("Başvuru Durumu");

            int index = 0;
            foreach (String text in dgvColumnsName)
            {
                dgv.Columns[index].HeaderText = text;
                index++;
            }

            dgv.Columns[5].Visible = false;

            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 90;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 80;
            dgv.Columns[5].Width = 80;
            dgv.Columns[6].Width = 150;
            dgv.Columns[7].Width = 80;
            dgv.Columns[8].Width = 80;
        }
    }
}
