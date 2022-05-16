using System;
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
    public partial class Mainpanel : Form
    {
        public Mainpanel()
        {
            InitializeComponent();
        }

        private void Mainpanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.StopSession();
            Application.Exit();
        }

        private void Mainpanel_Load(object sender, EventArgs e)
        {
            String sqlCommand = "Select * from Kullanici";
            App.FillDataGrid(sqlCommand, "Kullanici", dataGridView1);
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

    }
}
