using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace ProductsManager
{
    public partial class AddProduct : Form
    {
        public AddProductProp APPR = new AddProductProp();
        public AddProductControl APC = new AddProductControl();
        public DataOutControl DOC = new DataOutControl();
        public AddProduct()
        {
            InitializeComponent();
        }
        public string bindingID_box()
        {
            DataTable dataHH = DOC.SelectData("HANG_HOA");
            string maHH = dataGV.CurrentRow.Cells["MaHH"].Value.ToString();
            int lastID = dataHH.Rows.Count;

            return APC.growID(maHH, lastID);
        }
        public void activeDataGV()
        {
            dataGV.DataSource = DOC.SelectData("HANG_HOA");
            txt_mahh.Text = bindingID_box();
        }
        public void saveProduct()
        {
            APPR.maHH = txt_mahh.Text;
            APPR.tenHH = txt_tenhh.Text;
            APPR.soHD = Convert.ToInt32(txt_sohd.Text);
            APPR.soLuong = Convert.ToInt32(txt_soluong.Text);
            string res = APC.addPD(APPR);
            switch (res)
            {
                case "required_mahh":
                    MessageBox.Show("Không được để trống mã hàng hóa");
                    return;
                case "required_tenhh":
                    MessageBox.Show("Không được để trống tên hàng hóa");
                    return;
                case "required_sohd":
                    MessageBox.Show("Không được để trống số hóa đơn");
                    return;
                case "required_sol":
                    MessageBox.Show("Không được để trống số lượng");
                    return;
            }
            MessageBox.Show(res);
            activeDataGV();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            activeDataGV();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            saveProduct();
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingID_box();
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            txt_mahh.Text = bindingID_box();
            txt_tenhh.Text = "";
            txt_sohd.Text = "0";
            txt_soluong.Text = "0";
        }
        private void btn_quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
