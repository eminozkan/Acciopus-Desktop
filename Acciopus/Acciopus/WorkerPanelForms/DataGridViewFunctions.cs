using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.WorkerPanelForms
{
    class DataGridViewFunctions
    {
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

        }
    }
}
