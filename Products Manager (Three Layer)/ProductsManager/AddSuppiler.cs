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
    public partial class AddSuppiler : Form
    {
        public AddSuppiler()
        {
            InitializeComponent();
        }
        DataOutControl DOC = new DataOutControl();
        AddSuppilerControl ASC = new AddSuppilerControl();
        SuppilerProps SP = new SuppilerProps();
        ReproductionID RI = new ReproductionID();
        public string bindingId(DataTable dt)
        {
            ReproductionIdProps RIP = new ReproductionIdProps();
            RIP.id = dt.Rows[0]["MaNCC"].ToString();
            RIP.idCurrent = dt.Rows.Count;
            return RI.ReproductionO(RIP);
        }
        public void activeData()
        {
            DataTable dt = DOC.SelectData("NHA_CC");
            txt_mancc.Text = bindingId(dt);
        }
        public void saveSuppiler()
        {
            SP.maNCC = txt_mancc.Text;
            SP.tenNCC = txt_tenncc.Text;
            SP.sdt = txt_dienthoai.Text;
            SP.diachi = txt_diachi.Text;
            string res = ASC.AddSuppiler(SP);
            MessageBox.Show(res);
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            ListSuppilers LS = new ListSuppilers();
            LS.Show();
        }

        private void txt_mancc_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSuppiler_Load_1(object sender, EventArgs e)
        {
            activeData();
        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            saveSuppiler();
            activeData();
            SuppilerProps.alert = "OKEOKE";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
