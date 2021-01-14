using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSP
{
    public partial class f101_bang_gia : Form
    {
        public f101_bang_gia()
        {
            InitializeComponent();
            
        }
        public void rec_type(int ip_i_type)
        {
            if (ip_i_type == 0)
            {
                rbtn_kho.Enabled = false;
            }
            else
            {
                rbtn_baogia.Enabled = false;
            }
        }
        private void m_cmd_next_Click(object sender, EventArgs e)
        {
            if (rbtn_kho.Checked)
            {
                f102_kho f102 = new f102_kho();
                f102.Show();
            }
            else if (rbtn_baogia.Checked)
            {
                f103_bao_gia f103 = new f103_bao_gia();
                f103.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            f002_menu f002 = new f002_menu();
            f002.Show();
            this.Close();
        }
    }
}
