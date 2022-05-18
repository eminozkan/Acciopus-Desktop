using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.WorkerPanelForms
{
    class DataGridViewFunctions
    {

        private static String dataGridView1SqlCommand = "Select ilan_id,ilan_paylasan_id,ilan_baslik,ilan_firma_adi,meslek_adi,ilan_aciklama,ilan_teklif_edilen_maas,ilan_istenen_tecrube_suresi,ilan_tarihi from Is_ilan as t1 INNER JOIN Meslekler as t2 ON t1.ilan_aranan_meslek_id = t2.meslek_id";

        private static SqlCommand dataGridView2SqlCommand =new SqlCommand( "Select basvuru_id,ilan_firma_adi,basvuru_aciklama,basvuru_tarihi from Basvuru INNER JOIN Is_ilan ON Basvuru.basvurulan_ilan_id = Is_ilan.ilan_id where basvuru_yapan_id = @p1");



        public static String getDataGrid1SqlString()
        {
            return dataGridView1SqlCommand;
        }

        public static SqlCommand getDataGrid2SqlString()
        {
            return dataGridView2SqlCommand;
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
            ArrayList d2ColumnsName = new ArrayList();
            d2ColumnsName.Add("Başvuru ID");
            d2ColumnsName.Add("Başvuru Yapılan Firma Adı");
            d2ColumnsName.Add("Açıklama");
            d2ColumnsName.Add("Başvuru Tarihi");

            int index = 0;
            foreach(String text in d2ColumnsName)
            {
                dataGridView2.Columns[index].HeaderText = text;
                index++;
            }

            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 282;


            
        }
    }
}
