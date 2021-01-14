using Newtonsoft.Json;
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

namespace QLSP
{
    public partial class f302_chon_don_vi : Form
    {
        private List<Currency> m_li_currencies = new List<Currency>();
        private DataTable m_dt_currency = new DataTable();
        private ConcreteCurrencyBuilder m_currencyBuilder = new ConcreteCurrencyBuilder();
        private DataProductList_Ninh m_dataProduct = new DataProductList_Ninh();
        private string m_str_dataInput = @"..\..\Data\op_chon_sp.json";
        private string m_str_dataOutput = @"..\..\Data\ip_sanpham_baogia.json";
        public f302_chon_don_vi()
        {
            InitializeComponent();
            InitDataTable();
            ReadProductList();
            m_cmd_export.Enabled = false;
        }
        private void ReadProductList()
        {
            using (StreamReader file = File.OpenText(m_str_dataInput))
            {
                JsonSerializer serializer = new JsonSerializer();
                m_dataProduct = (DataProductList_Ninh)serializer.Deserialize(file, typeof(DataProductList_Ninh));
            }
        }
        private void InitDataTable()
        {
            m_dt_currency.Columns.Add("Type", typeof(string));
        }
        private void UpdateDataTable()
        {
            m_dt_currency.Rows.Clear();
            foreach (Currency currency in m_li_currencies)
            {
                m_dt_currency.Rows.Add(currency.Type);
            }
        }
        private void UpdateDataGridView()
        {
            m_dg_currency_list.DataSource = m_dt_currency;
        }
        private void UpdateData()
        {
            m_li_currencies = m_currencyBuilder.GetCurrencies();
            if (m_li_currencies.Count > 0) m_cmd_export.Enabled = true;
            else m_cmd_export.Enabled = false;
            UpdateDataTable();
            UpdateDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.Remove(m_dg_currency_list.CurrentCell.RowIndex);
            UpdateData();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.Reset();
            UpdateData();
        }

        private void m_cmd_add_usd_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.AddUSD();
            UpdateData();
        }

        private void m_cmd_add_eur_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.AddEUR();
            UpdateData();
        }

        private void m_cmd_add_rmb_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.AddRMB();
            UpdateData();
        }

        private void m_cmd_add_krw_Click(object sender, EventArgs e)
        {
            m_currencyBuilder.AddKRW();
            UpdateData();
        }

        private void m_cmd_export_Click(object sender, EventArgs e)
        {
            m_cmd_next.Enabled = true;
            m_dataProduct.currency = m_li_currencies;
            using (StreamWriter file = File.CreateText(m_str_dataOutput))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, m_dataProduct);
                MessageBox.Show("Data Exported!");
            }
        }

        private void m_cmd_next_Click(object sender, EventArgs e)
        {
            f103_bao_gia us_f103 = new f103_bao_gia();
            us_f103.Show();
            this.Close();
        }
    }
}
