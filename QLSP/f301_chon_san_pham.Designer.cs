
namespace QLSP
{
    partial class f301_chon_san_pham
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
            this.m_cmd_add = new System.Windows.Forms.Button();
            this.m_cmd_export = new System.Windows.Forms.Button();
            this.m_cmd_clear_all = new System.Windows.Forms.Button();
            this.m_cmd_delete = new System.Windows.Forms.Button();
            this.m_cmd_update = new System.Windows.Forms.Button();
            this.m_dgv_product = new System.Windows.Forms.DataGridView();
            this.m_cmd_build_basic = new System.Windows.Forms.Button();
            this.m_cmd_build_advanced = new System.Windows.Forms.Button();
            this.m_cbo_type = new System.Windows.Forms.ComboBox();
            this.m_cbo_name = new System.Windows.Forms.ComboBox();
            this.m_lbl_type = new System.Windows.Forms.Label();
            this.m_lbl_name = new System.Windows.Forms.Label();
            this.m_lbl_amount = new System.Windows.Forms.Label();
            this.m_cmd_next = new System.Windows.Forms.Button();
            this.m_nud_amount = new System.Windows.Forms.NumericUpDown();
            this.m_lbl_remaining = new System.Windows.Forms.Label();
            this.m_lbl_remaining_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cmd_add
            // 
            this.m_cmd_add.Location = new System.Drawing.Point(12, 489);
            this.m_cmd_add.Name = "m_cmd_add";
            this.m_cmd_add.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_add.TabIndex = 0;
            this.m_cmd_add.Text = "Add";
            this.m_cmd_add.UseVisualStyleBackColor = true;
            this.m_cmd_add.Click += new System.EventHandler(this.Add_Click);
            // 
            // m_cmd_export
            // 
            this.m_cmd_export.Location = new System.Drawing.Point(640, 489);
            this.m_cmd_export.Name = "m_cmd_export";
            this.m_cmd_export.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_export.TabIndex = 1;
            this.m_cmd_export.Text = "Export";
            this.m_cmd_export.UseVisualStyleBackColor = true;
            this.m_cmd_export.Click += new System.EventHandler(this.Export_Click);
            // 
            // m_cmd_clear_all
            // 
            this.m_cmd_clear_all.Location = new System.Drawing.Point(483, 489);
            this.m_cmd_clear_all.Name = "m_cmd_clear_all";
            this.m_cmd_clear_all.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_clear_all.TabIndex = 2;
            this.m_cmd_clear_all.Text = "Clear All";
            this.m_cmd_clear_all.UseVisualStyleBackColor = true;
            this.m_cmd_clear_all.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Location = new System.Drawing.Point(326, 489);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_delete.TabIndex = 3;
            this.m_cmd_delete.Text = "Delete";
            this.m_cmd_delete.UseVisualStyleBackColor = true;
            this.m_cmd_delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Location = new System.Drawing.Point(169, 489);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_update.TabIndex = 4;
            this.m_cmd_update.Text = "Update";
            this.m_cmd_update.UseVisualStyleBackColor = true;
            this.m_cmd_update.Click += new System.EventHandler(this.Update_Click);
            // 
            // m_dgv_product
            // 
            this.m_dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgv_product.Location = new System.Drawing.Point(171, 94);
            this.m_dgv_product.Name = "m_dgv_product";
            this.m_dgv_product.RowHeadersWidth = 51;
            this.m_dgv_product.RowTemplate.Height = 24;
            this.m_dgv_product.Size = new System.Drawing.Size(747, 372);
            this.m_dgv_product.TabIndex = 5;
            this.m_dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgv_product_CellContentClick);
            // 
            // m_cmd_build_basic
            // 
            this.m_cmd_build_basic.Location = new System.Drawing.Point(12, 94);
            this.m_cmd_build_basic.Name = "m_cmd_build_basic";
            this.m_cmd_build_basic.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_build_basic.TabIndex = 6;
            this.m_cmd_build_basic.Text = "Build Basic";
            this.m_cmd_build_basic.UseVisualStyleBackColor = true;
            this.m_cmd_build_basic.Click += new System.EventHandler(this.Build_Basic_Click);
            // 
            // m_cmd_build_advanced
            // 
            this.m_cmd_build_advanced.Location = new System.Drawing.Point(12, 151);
            this.m_cmd_build_advanced.Name = "m_cmd_build_advanced";
            this.m_cmd_build_advanced.Size = new System.Drawing.Size(121, 40);
            this.m_cmd_build_advanced.TabIndex = 7;
            this.m_cmd_build_advanced.Text = "Build Advanced ";
            this.m_cmd_build_advanced.UseVisualStyleBackColor = true;
            this.m_cmd_build_advanced.Click += new System.EventHandler(this.Build_Advanced_Click);
            // 
            // m_cbo_type
            // 
            this.m_cbo_type.FormattingEnabled = true;
            this.m_cbo_type.Items.AddRange(new object[] {
            "RAM",
            "SSD",
            "HDD",
            "Mainboard",
            "GraphicCard",
            "CPU"});
            this.m_cbo_type.Location = new System.Drawing.Point(12, 240);
            this.m_cbo_type.Name = "m_cbo_type";
            this.m_cbo_type.Size = new System.Drawing.Size(121, 24);
            this.m_cbo_type.TabIndex = 8;
            this.m_cbo_type.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // m_cbo_name
            // 
            this.m_cbo_name.FormattingEnabled = true;
            this.m_cbo_name.Location = new System.Drawing.Point(12, 305);
            this.m_cbo_name.Name = "m_cbo_name";
            this.m_cbo_name.Size = new System.Drawing.Size(121, 24);
            this.m_cbo_name.TabIndex = 9;
            this.m_cbo_name.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            // 
            // m_lbl_type
            // 
            this.m_lbl_type.AutoSize = true;
            this.m_lbl_type.Location = new System.Drawing.Point(53, 217);
            this.m_lbl_type.Name = "m_lbl_type";
            this.m_lbl_type.Size = new System.Drawing.Size(40, 17);
            this.m_lbl_type.TabIndex = 10;
            this.m_lbl_type.Text = "Type";
            // 
            // m_lbl_name
            // 
            this.m_lbl_name.AutoSize = true;
            this.m_lbl_name.Location = new System.Drawing.Point(49, 282);
            this.m_lbl_name.Name = "m_lbl_name";
            this.m_lbl_name.Size = new System.Drawing.Size(45, 17);
            this.m_lbl_name.TabIndex = 11;
            this.m_lbl_name.Text = "Name";
            // 
            // m_lbl_amount
            // 
            this.m_lbl_amount.AutoSize = true;
            this.m_lbl_amount.Location = new System.Drawing.Point(38, 369);
            this.m_lbl_amount.Name = "m_lbl_amount";
            this.m_lbl_amount.Size = new System.Drawing.Size(56, 17);
            this.m_lbl_amount.TabIndex = 13;
            this.m_lbl_amount.Text = "Amount";
            // 
            // m_cmd_next
            // 
            this.m_cmd_next.Location = new System.Drawing.Point(797, 489);
            this.m_cmd_next.Name = "m_cmd_next";
            this.m_cmd_next.Size = new System.Drawing.Size(121, 53);
            this.m_cmd_next.TabIndex = 14;
            this.m_cmd_next.Text = "Next";
            this.m_cmd_next.UseVisualStyleBackColor = true;
            this.m_cmd_next.Click += new System.EventHandler(this.Next_Click);
            // 
            // m_nud_amount
            // 
            this.m_nud_amount.Location = new System.Drawing.Point(12, 389);
            this.m_nud_amount.Name = "m_nud_amount";
            this.m_nud_amount.Size = new System.Drawing.Size(121, 22);
            this.m_nud_amount.TabIndex = 15;
            this.m_nud_amount.ValueChanged += new System.EventHandler(this.AmountNumericUpDown_ValueChanged);
            // 
            // m_lbl_remaining
            // 
            this.m_lbl_remaining.AutoSize = true;
            this.m_lbl_remaining.Location = new System.Drawing.Point(9, 343);
            this.m_lbl_remaining.Name = "m_lbl_remaining";
            this.m_lbl_remaining.Size = new System.Drawing.Size(79, 17);
            this.m_lbl_remaining.TabIndex = 16;
            this.m_lbl_remaining.Text = "Remaining:";
            // 
            // m_lbl_remaining_count
            // 
            this.m_lbl_remaining_count.AutoSize = true;
            this.m_lbl_remaining_count.Location = new System.Drawing.Point(94, 343);
            this.m_lbl_remaining_count.Name = "m_lbl_remaining_count";
            this.m_lbl_remaining_count.Size = new System.Drawing.Size(16, 17);
            this.m_lbl_remaining_count.TabIndex = 17;
            this.m_lbl_remaining_count.Text = "0";
            // 
            // f301_chon_san_pham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 554);
            this.Controls.Add(this.m_lbl_remaining_count);
            this.Controls.Add(this.m_lbl_remaining);
            this.Controls.Add(this.m_nud_amount);
            this.Controls.Add(this.m_cmd_next);
            this.Controls.Add(this.m_lbl_amount);
            this.Controls.Add(this.m_lbl_name);
            this.Controls.Add(this.m_lbl_type);
            this.Controls.Add(this.m_cbo_name);
            this.Controls.Add(this.m_cbo_type);
            this.Controls.Add(this.m_cmd_build_advanced);
            this.Controls.Add(this.m_cmd_build_basic);
            this.Controls.Add(this.m_dgv_product);
            this.Controls.Add(this.m_cmd_update);
            this.Controls.Add(this.m_cmd_delete);
            this.Controls.Add(this.m_cmd_clear_all);
            this.Controls.Add(this.m_cmd_export);
            this.Controls.Add(this.m_cmd_add);
            this.Name = "f301_chon_san_pham";
            this.Text = "F301 - Chon san pham";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_cmd_add;
        private System.Windows.Forms.Button m_cmd_export;
        private System.Windows.Forms.Button m_cmd_clear_all;
        private System.Windows.Forms.Button m_cmd_delete;
        private System.Windows.Forms.Button m_cmd_update;
        private System.Windows.Forms.DataGridView m_dgv_product;
        private System.Windows.Forms.Button m_cmd_build_basic;
        private System.Windows.Forms.Button m_cmd_build_advanced;
        private System.Windows.Forms.ComboBox m_cbo_type;
        private System.Windows.Forms.ComboBox m_cbo_name;
        private System.Windows.Forms.Label m_lbl_type;
        private System.Windows.Forms.Label m_lbl_name;
        private System.Windows.Forms.Label m_lbl_amount;
        private System.Windows.Forms.Button m_cmd_next;
        private System.Windows.Forms.NumericUpDown m_nud_amount;
        private System.Windows.Forms.Label m_lbl_remaining;
        private System.Windows.Forms.Label m_lbl_remaining_count;
    }
}

