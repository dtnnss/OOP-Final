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
    public partial class f002_menu : Form
    {
        public f002_menu()
        {
            InitializeComponent();
            timer1.Start();
            m_cmd_question.Enabled = true;
        }
        int m_i_type;
        public void authen(int ip_i_type)
        {
            m_i_type = ip_i_type;
            if (m_i_type == 1)
            {
                m_cmd_chonsp.Enabled = false;
                m_cmd_xuathd.Enabled = false;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.m_lbl_date.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void m_cmd_xuathd_Click(object sender, EventArgs e)
        {
            f201_thanh_toan us_thanhtoan = new f201_thanh_toan();
            us_thanhtoan.Show();
            this.Hide();
        }

        private void m_cmd_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn chức năng 'Chọn sản phẩm' để lựa chọn sản phẩm của bạn " +
                            ", sau đó chọn chức năng 'Xem bảng giá' để xem qua giá thành sản phẩm ." +
                            " Cuối cùng chọn chức năng 'Xuất hóa đơn' để xuất loại hóa đơn thanh toán bạn muốn dùng ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f101_bang_gia us_f101 = new f101_bang_gia();
            us_f101.rec_type(m_i_type);
            us_f101.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e){
            f001_dang_nhap us_dangnhap = new f001_dang_nhap();
            us_dangnhap.Show();
            this.Close();
        }

        private void m_cmd_chonsp_Click(object sender, EventArgs e)
        {
            f301_chon_san_pham us_f301 = new f301_chon_san_pham();
            us_f301.Show();
            this.Close();
        }
    }
}
