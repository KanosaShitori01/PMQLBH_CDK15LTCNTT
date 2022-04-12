
namespace ProductsManager
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sohd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenhh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mahh = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.btn_quayve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_sohd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tenhh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mahh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(117, 139);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(131, 20);
            this.txt_soluong.TabIndex = 5;
            this.txt_soluong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng";
            // 
            // txt_sohd
            // 
            this.txt_sohd.Location = new System.Drawing.Point(117, 106);
            this.txt_sohd.Name = "txt_sohd";
            this.txt_sohd.Size = new System.Drawing.Size(131, 20);
            this.txt_sohd.TabIndex = 3;
            this.txt_sohd.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Hóa Đơn";
            // 
            // txt_tenhh
            // 
            this.txt_tenhh.Location = new System.Drawing.Point(117, 69);
            this.txt_tenhh.Name = "txt_tenhh";
            this.txt_tenhh.Size = new System.Drawing.Size(131, 20);
            this.txt_tenhh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // txt_mahh
            // 
            this.txt_mahh.Enabled = false;
            this.txt_mahh.Location = new System.Drawing.Point(117, 31);
            this.txt_mahh.Name = "txt_mahh";
            this.txt_mahh.Size = new System.Drawing.Size(131, 20);
            this.txt_mahh.TabIndex = 0;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(287, 40);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.SoHD,
            this.SoLuong});
            this.dataGV.Location = new System.Drawing.Point(12, 204);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(350, 167);
            this.dataGV.TabIndex = 2;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellClick);
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã HH";
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên HH";
            this.TenHH.Name = "TenHH";
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "DonGiaHienTai";
            this.SoHD.HeaderText = "Đơn Giá HT";
            this.SoHD.Name = "SoHD";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(287, 78);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(75, 23);
            this.btn_taomoi.TabIndex = 3;
            this.btn_taomoi.Text = "Tạo Mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // btn_quayve
            // 
            this.btn_quayve.Location = new System.Drawing.Point(287, 115);
            this.btn_quayve.Name = "btn_quayve";
            this.btn_quayve.Size = new System.Drawing.Size(75, 23);
            this.btn_quayve.TabIndex = 4;
            this.btn_quayve.Text = "Quay Về";
            this.btn_quayve.UseVisualStyleBackColor = true;
            this.btn_quayve.Click += new System.EventHandler(this.btn_quayve_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 383);
            this.Controls.Add(this.btn_quayve);
            this.Controls.Add(this.btn_taomoi);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_mahh;
        private System.Windows.Forms.TextBox txt_sohd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenhh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_taomoi;
        private System.Windows.Forms.Button btn_quayve;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}