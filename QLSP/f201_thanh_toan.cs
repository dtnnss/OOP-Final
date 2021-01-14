using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace QLSP
{
    public partial class f201_thanh_toan : Form
    {
        public f201_thanh_toan()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {                   
            Chandler_101 us_h1 = new Chdt_102();
            Chandler_101 us_h2 = new Chdgtgt_103();
            
            us_h1.SetSuccessor(us_h2);
            us_h1.HandleRequest(m_cbo_loaihd.SelectedItem.ToString());
            
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            f002_menu us_menu = new f002_menu();
            us_menu.Show();
        }

        private void m_cbo_loaihd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    abstract class Chandler_101

    {
        protected Chandler_101 successor;

        public void SetSuccessor(Chandler_101 successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(string ip_str_request);
    }
    class Chdt_102 : Chandler_101
    {
        string m_str_json_product = @"C:\Users\Tuan\source\repos\Bill-with-Chain-of-Responsibility\QLSP\Data\sanpham.json";
        public override void HandleRequest(string ip_str_request)
        {
            if (ip_str_request == "Hóa đơn thường")
            {
             
                f203_info_hdt us_hoadonThuong = new f203_info_hdt();
                
                us_hoadonThuong.Show();
            }
            else if (successor != null)
            {
                successor.HandleRequest(ip_str_request);
            }
        }
    }
    class Chdgtgt_103 : Chandler_101
    {
        string m_str_json_product = @"C:\Users\Tuan\source\repos\QLSP\QLSP\Data\sanpham.json";
        public override void HandleRequest(string ip_str_request)
        {
            if (ip_str_request == "Hóa đơn GTGT")
            {
                
                f202_info_hdgtgt us_hoadonGTGT = new f202_info_hdgtgt();
                
                us_hoadonGTGT.Show();
            }
            else if (successor != null)
            {
                successor.HandleRequest(ip_str_request);
            }
        }
    }
}
