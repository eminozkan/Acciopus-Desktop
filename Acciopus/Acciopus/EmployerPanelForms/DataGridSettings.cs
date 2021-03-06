using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.EmployerPanelForms
{
    class DataGridSettings
    {

        private static String dataGridView1SqlString = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Ilanlar as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id";

        private static String dataGridView2SqlString = "Select basvuru_id,kullanici_adi,kullanici_soyadi,kullanici_mail,kullanici_telefon,basvurulan_ilan_id,basvuru_aciklama,basvuru_tarihi,basvuru_durum from Basvuru INNER JOIN Kullanici ON basvuru_yapan_id = kullanici_id INNER JOIN Ilanlar ON ilan_id = basvurulan_ilan_id where ilan_paylasan_id = @p1 ";

        private static String dataGridView3SqlString = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Ilanlar as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id where ilan_paylasan_id = @p1";

        public static String getDataGrid1SqlString()
        {
            return dataGridView1SqlString;
        }

        public static String getDataGrid2SqlString()
        {
            return dataGridView2SqlString;
        }

        public static String getDataGrid3SqlString()
        {
            return dataGridView3SqlString;
        }

        public static void setDataGridView1Settings(DataGridView dataGridView1)
        {
            ArrayList d1ColumnsName = new ArrayList();
            d1ColumnsName.Add("İlan ID");
            d1ColumnsName.Add("Paylaşan ID");
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
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 350;
            dataGridView1.Columns[8].Width = 123;
        }



        public static void setDataGridView2Settings(DataGridView dataGridView2)
        {
            ArrayList d1ColumnsName = new ArrayList();
            d1ColumnsName.Add("Başvuru ID");
            d1ColumnsName.Add("Başvuran Adı");
            d1ColumnsName.Add("Başvuran Soyadı");
            d1ColumnsName.Add("Başvuran Mail");
            d1ColumnsName.Add("Başvuran Telefon");
            d1ColumnsName.Add("Başvurulan İlan ID");
            d1ColumnsName.Add("Başvuru Açıklama");
            d1ColumnsName.Add("Başvuru Tarihi");
            d1ColumnsName.Add("Başvuru Durumu");

            int index = 0;
            foreach (String text in d1ColumnsName)
            {
                dataGridView2.Columns[index].HeaderText = text;
                index++;
            }

            dataGridView2.Columns[5].Visible = false;

            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 90;
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[4].Width = 80;
            dataGridView2.Columns[5].Width = 80;
            dataGridView2.Columns[6].Width = 150;
            dataGridView2.Columns[7].Width = 80;
            dataGridView2.Columns[8].Width = 80;


        }

        public static void setDataGridView3Settings(DataGridView dataGridView3)
        {
            ArrayList d3ColumnsName = new ArrayList();
            d3ColumnsName.Add("İlan ID");
            d3ColumnsName.Add("Paylaşan ID");
            d3ColumnsName.Add("İlan Başlığı");
            d3ColumnsName.Add("Firma Adı");
            d3ColumnsName.Add("Aranan Meslek");
            d3ColumnsName.Add("Açıklama");
            d3ColumnsName.Add("Teklif Edilen Maaş");
            d3ColumnsName.Add("Aranan Tecrübe Süresi");
            d3ColumnsName.Add("İlan Tarihi");

            int index = 0;
            foreach (String text in d3ColumnsName)
            {
                dataGridView3.Columns[index].HeaderText = text;
                index++;
            }



            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Width = 250;
            dataGridView3.Columns[3].Width = 100;
            dataGridView3.Columns[4].Width = 200;
            dataGridView3.Columns[5].Width = 350;
            dataGridView3.Columns[8].Width = 123;
        }

    }
}
