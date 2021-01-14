using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QLSP
{
    public partial class f301_chon_san_pham : Form
    {
        private List<Product> m_li_product = new List<Product>();
        private DataProductList_Ninh m_data_storage = new DataProductList_Ninh();
        private DataTable m_dt_product = new DataTable();
        private PCDirector m_pc_director = new PCDirector();
        private ConcretePCBuilder m_pc_builder = new ConcretePCBuilder();
        private string m_str_dataInput = @"..\..\Data\op_sp_kho.json";
        private string m_str_dataOutput = @"..\..\Data\op_chon_sp.json";
        private Dictionary<string, int> m_di_types = new Dictionary<string, int>();
        public f301_chon_san_pham()
        {
            InitializeComponent();
            LoadStorage();
            LoadTypes();
            InitDataTable();
            UpdateData();
            m_pc_director.PCBuilder = m_pc_builder;
            m_cmd_export.Enabled = false;
            m_cmd_next.Enabled = false;
        }

        private void InitDataTable()
        {
            m_dt_product.Columns.Add("Type", typeof(string));
            m_dt_product.Columns.Add("Name", typeof(string));
            m_dt_product.Columns.Add("Price", typeof(string));
            m_dt_product.Columns.Add("Warranty", typeof(string));
            m_dt_product.Columns.Add("Amount", typeof(string));
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemByType(m_cbo_type.GetItemText(m_cbo_type.SelectedItem));
            m_nud_amount.Value = 0;
        }
        private void LoadItemByType(string ip_str_type)
        {
            m_cbo_name.Text = "";
            m_cbo_name.Items.Clear();
            m_lbl_remaining_count.Text = "0";
            foreach (Product v_product in m_data_storage.products)
            {
                if (v_product.Type.Equals(ip_str_type))
                {
                    m_cbo_name.Items.Add(v_product.Name);
                }
            }
        }
        private void LoadTypes()
        {
            m_lbl_remaining_count.Text = "0";
            m_cbo_type.Items.Clear();
            foreach (KeyValuePair<string, int> v_kvp_type in m_di_types)
            {
                m_cbo_type.Items.Add(v_kvp_type.Key);
            }
        }
        private int FindProductID(string ip_str_type, string ip_str_name)
        {
            for (int v_i_it = 0; v_i_it < m_data_storage.products.Count; v_i_it++)
            {
                if (m_data_storage.products[v_i_it].Type.Equals(ip_str_type) 
                    && m_data_storage.products[v_i_it].Name.Equals(ip_str_name))
                {
                    return v_i_it;
                }
            }
            return -1;
        }

        private void LoadStorage()
        {
            m_cbo_type.Items.Clear();
            using (StreamReader file = File.OpenText(m_str_dataInput))
            {
                JsonSerializer serializer = new JsonSerializer();
                m_data_storage = (DataProductList_Ninh) serializer.Deserialize(file, typeof(DataProductList_Ninh));
            }
            foreach (Product v_product in m_data_storage.products)
            {
                if (!m_di_types.ContainsKey(v_product.Type))
                {
                    m_di_types.Add(v_product.Type, 1);
                }
            }
        }
        
        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v_i_id = FindProductID(m_cbo_type.Text, m_cbo_name.Text);
            m_lbl_remaining_count.Text = m_data_storage.products[v_i_id].Availability;
            m_nud_amount.Value = 0;
        }

        private void AmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int remainingNumber = 0;
            try
            {
                remainingNumber = Int32.Parse(m_lbl_remaining_count.Text);
            }
            catch (FormatException v_e)
            {
                // Console.WriteLine(v_e.Message);
                throw v_e;
            }
            if (m_nud_amount.Value > remainingNumber)
            {
                m_nud_amount.Value = remainingNumber;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int v_i_id = FindProductID(m_cbo_type.Text, m_cbo_name.Text);
            if (m_nud_amount.Value == 0 || m_cbo_type.SelectedIndex == -1 || m_cbo_name.SelectedIndex == -1) return;
            m_pc_builder.Add(m_cbo_type.GetItemText(m_cbo_type.SelectedItem), m_cbo_name.GetItemText(m_cbo_name.SelectedItem), m_nud_amount.Value.ToString());
            m_pc_builder.UpdatePriceWarranty(m_pc_builder.GetProduct().Count - 1, m_data_storage.products[v_i_id].VND, m_data_storage.products[v_i_id].Warranty);
            UpdateData();
        }

        private void UpdateData()
        {
            m_li_product = m_pc_builder.GetProduct();
            if (m_li_product.Count > 0)
            {
                m_cmd_export.Enabled = true;
            }
            else
            {
                m_cmd_export.Enabled = false;
            }
            UpdateDataTable();
            UpdateDataGridView();
        }
        private void UpdateDataTable()
        {
            m_dt_product.Rows.Clear();
            foreach (Product v_product in m_li_product)
            {
                m_dt_product.Rows.Add(v_product.Type, v_product.Name, v_product.Prices, v_product.Warranty, v_product.Amount);
            } 
        }
        private void UpdateDataGridView()
        {
            m_dgv_product.DataSource = m_dt_product;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            m_pc_builder.Remove(m_dgv_product.CurrentCell.RowIndex);
            UpdateData();
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
            m_pc_builder.Reset();
            UpdateData();
        }

        private void Build_Basic_Click(object sender, EventArgs e)
        {
            m_pc_builder.Reset();
            m_pc_director.BuildBasic();
            UpdateData();
        }

        private void Build_Advanced_Click(object sender, EventArgs e)
        {
            m_pc_builder.Reset();
            m_pc_director.BuildAdvanced();
            UpdateData();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            f302_chon_don_vi us_f302 = new f302_chon_don_vi();
            us_f302.Show();
            Hide();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            m_cmd_next.Enabled = true;
            DataProductList_Ninh v_dataProduct = new DataProductList_Ninh();
            v_dataProduct.products = m_li_product;
            using (StreamWriter file = File.CreateText(m_str_dataOutput))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, v_dataProduct);
                MessageBox.Show("Data Exported!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (m_dgv_product.CurrentCell.RowIndex < 0) return;
        }

        private void m_dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearInfo();
            LoadTypes();
            int v_i_item_index = m_dgv_product.CurrentCell.RowIndex;
            if (v_i_item_index < 0 || v_i_item_index >= m_li_product.Count) return;
            m_cbo_type.SelectedIndex = m_cbo_type.FindStringExact(m_li_product[v_i_item_index].Type);
            LoadItemByType(m_li_product[v_i_item_index].Type);
            m_cbo_name.SelectedIndex = m_cbo_name.FindStringExact(m_li_product[v_i_item_index].Name);
        }

        private void ClearInfo()
        {
            m_cbo_type.Items.Clear();
            m_cbo_name.Items.Clear();
            m_cbo_type.Text = "";
            m_cbo_name.Text = "";
            m_nud_amount.Value = 0;
            m_lbl_remaining_count.Text = "0";
        }
    }
}
