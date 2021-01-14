
namespace QLSP
{
    partial class f302_chon_don_vi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_cmd_next = new System.Windows.Forms.Button();
            this.m_cmd_add_eur = new System.Windows.Forms.Button();
            this.m_dg_currency_list = new System.Windows.Forms.DataGridView();
            this.m_cmd_update = new System.Windows.Forms.Button();
            this.m_cmd_delete = new System.Windows.Forms.Button();
            this.m_cmd_clear_all = new System.Windows.Forms.Button();
            this.m_cmd_add_usd = new System.Windows.Forms.Button();
            this.m_cmd_add_rmb = new System.Windows.Forms.Button();
            this.m_cmd_add_krw = new System.Windows.Forms.Button();
            this.m_cmd_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dg_currency_list)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cmd_next
            // 
            this.m_cmd_next.Location = new System.Drawing.Point(807, 448);
            this.m_cmd_next.Name = "m_cmd_next";
            this.m_cmd_next.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_next.TabIndex = 29;
            this.m_cmd_next.Text = "Next";
            this.m_cmd_next.UseVisualStyleBackColor = true;
            this.m_cmd_next.Click += new System.EventHandler(this.m_cmd_next_Click);
            // 
            // m_cmd_add_eur
            // 
            this.m_cmd_add_eur.Location = new System.Drawing.Point(22, 120);
            this.m_cmd_add_eur.Name = "m_cmd_add_eur";
            this.m_cmd_add_eur.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_add_eur.TabIndex = 23;
            this.m_cmd_add_eur.Text = "Add EUR";
            this.m_cmd_add_eur.UseVisualStyleBackColor = true;
            this.m_cmd_add_eur.Click += new System.EventHandler(this.m_cmd_add_eur_Click);
            // 
            // m_dg_currency_list
            // 
            this.m_dg_currency_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dg_currency_list.Location = new System.Drawing.Point(181, 53);
            this.m_dg_currency_list.Name = "m_dg_currency_list";
            this.m_dg_currency_list.RowHeadersWidth = 51;
            this.m_dg_currency_list.RowTemplate.Height = 24;
            this.m_dg_currency_list.Size = new System.Drawing.Size(747, 372);
            this.m_dg_currency_list.TabIndex = 21;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Location = new System.Drawing.Point(179, 448);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_update.TabIndex = 20;
            this.m_cmd_update.Text = "Update";
            this.m_cmd_update.UseVisualStyleBackColor = true;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Location = new System.Drawing.Point(336, 448);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_delete.TabIndex = 19;
            this.m_cmd_delete.Text = "Delete";
            this.m_cmd_delete.UseVisualStyleBackColor = true;
            this.m_cmd_delete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // m_cmd_clear_all
            // 
            this.m_cmd_clear_all.Location = new System.Drawing.Point(493, 448);
            this.m_cmd_clear_all.Name = "m_cmd_clear_all";
            this.m_cmd_clear_all.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_clear_all.TabIndex = 18;
            this.m_cmd_clear_all.Text = "Clear All";
            this.m_cmd_clear_all.UseVisualStyleBackColor = true;
            this.m_cmd_clear_all.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // m_cmd_add_usd
            // 
            this.m_cmd_add_usd.Location = new System.Drawing.Point(22, 50);
            this.m_cmd_add_usd.Name = "m_cmd_add_usd";
            this.m_cmd_add_usd.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_add_usd.TabIndex = 22;
            this.m_cmd_add_usd.Text = "Add USD";
            this.m_cmd_add_usd.UseVisualStyleBackColor = true;
            this.m_cmd_add_usd.Click += new System.EventHandler(this.m_cmd_add_usd_Click);
            // 
            // m_cmd_add_rmb
            // 
            this.m_cmd_add_rmb.Location = new System.Drawing.Point(22, 190);
            this.m_cmd_add_rmb.Name = "m_cmd_add_rmb";
            this.m_cmd_add_rmb.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_add_rmb.TabIndex = 33;
            this.m_cmd_add_rmb.Text = "Add RMB";
            this.m_cmd_add_rmb.UseVisualStyleBackColor = true;
            this.m_cmd_add_rmb.Click += new System.EventHandler(this.m_cmd_add_rmb_Click);
            // 
            // m_cmd_add_krw
            // 
            this.m_cmd_add_krw.Location = new System.Drawing.Point(22, 260);
            this.m_cmd_add_krw.Name = "m_cmd_add_krw";
            this.m_cmd_add_krw.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_add_krw.TabIndex = 34;
            this.m_cmd_add_krw.Text = "Add KRW";
            this.m_cmd_add_krw.UseVisualStyleBackColor = true;
            this.m_cmd_add_krw.Click += new System.EventHandler(this.m_cmd_add_krw_Click);
            // 
            // m_cmd_export
            // 
            this.m_cmd_export.Location = new System.Drawing.Point(650, 448);
            this.m_cmd_export.Name = "m_cmd_export";
            this.m_cmd_export.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_export.TabIndex = 17;
            this.m_cmd_export.Text = "Export";
            this.m_cmd_export.UseVisualStyleBackColor = true;
            this.m_cmd_export.Click += new System.EventHandler(this.m_cmd_export_Click);
            // 
            // f302_chon_don_vi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 554);
            this.Controls.Add(this.m_cmd_add_krw);
            this.Controls.Add(this.m_cmd_add_rmb);
            this.Controls.Add(this.m_cmd_next);
            this.Controls.Add(this.m_cmd_add_eur);
            this.Controls.Add(this.m_cmd_add_usd);
            this.Controls.Add(this.m_dg_currency_list);
            this.Controls.Add(this.m_cmd_update);
            this.Controls.Add(this.m_cmd_delete);
            this.Controls.Add(this.m_cmd_clear_all);
            this.Controls.Add(this.m_cmd_export);
            this.Name = "f302_chon_don_vi";
            this.Text = "F302 - Chon don vi";
            ((System.ComponentModel.ISupportInitialize)(this.m_dg_currency_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_cmd_next;
        private System.Windows.Forms.Button m_cmd_add_eur;
        private System.Windows.Forms.DataGridView m_dg_currency_list;
        private System.Windows.Forms.Button m_cmd_update;
        private System.Windows.Forms.Button m_cmd_delete;
        private System.Windows.Forms.Button m_cmd_clear_all;
        private System.Windows.Forms.Button m_cmd_add_usd;
        private System.Windows.Forms.Button m_cmd_add_rmb;
        private System.Windows.Forms.Button m_cmd_add_krw;
        private System.Windows.Forms.Button m_cmd_export;
    }
}