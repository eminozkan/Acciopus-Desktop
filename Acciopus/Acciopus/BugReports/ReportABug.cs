using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.BugReports
{
    public partial class ReportABug : Form
    {
        public ReportABug()
        {
            InitializeComponent();
        }

        private void report_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && richTextBox1.Text.Length > 0)
            {
                
                SqlCommand cmd = new SqlCommand("insert into Hatalar (bug_konu,bug_mesaj) values (@p1,@p2)");
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", richTextBox1.Text);
                App.sendSqlCommand(cmd);

                MessageBox.Show("Desteğiniz için teşekkürler!");
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
