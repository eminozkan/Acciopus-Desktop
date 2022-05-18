using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.WorkerPanelForms
{
    internal partial class RequestJob : Form
    {

        public String FirmaAdi;
        public String IlanBaslik;
        public User.User user;
        public int ilan_id;

        public RequestJob()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
            {
                length.Text = (richTextBox1.Text.Length.ToString() + "/500");
            }
            else
            {
                length.Text = "0/500";
            }
        }

        private void RequestJob_Load(object sender, EventArgs e)
        {
            textBox1.Text = IlanBaslik;
            textBox2.Text = FirmaAdi;
            dateTimePicker1.Value = DateTime.Now;
            length.Text = "0/500";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App.MakeJobRequest(user, ilan_id, richTextBox1.Text);
        }
    }
}
