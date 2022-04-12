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
    public partial class PMQLBH : Form
    {
        DataOutControl DOC = new DataOutControl();
        AutoCompleteControl AC_C = new AutoCompleteControl();
        SearchControl SC = new SearchControl();
        BPXControl BPXC = new BPXControl();
        ReproductionID RI = new ReproductionID();
        SavePNControl SPC = new SavePNControl();
        SavePNProps SPP = new SavePNProps();
        AddPNProps APNP = new AddPNProps();
        public static string nameAutoHH = "TENHH";
        public PMQLBH()
        {
            InitializeComponent();
        }
        public void WouldDisable()
        {
            txt_ghichu.Enabled = false;
            txt_diengiai.Enabled = false;
            txt_chietkhau.Enabled = false;
            cb_khohang.Enabled = false;
            txt_chungtugoc.Enabled = false;
        }
        public void SumAllMoney()
        {
            decimal tienhang = 0;
            decimal thue = 0;
            decimal chietkhau = 0;
            decimal tongcong = 0;
            for (int i = 0; i < dataGV_TBTT.RowCount - 1; i++)
            {
                tienhang += Convert.ToInt64(dataGV_TBTT.Rows[i].Cells["ThanhTien"].Value);
            }
            thue = (nup_thue.Value / 100) * tienhang;
            chietkhau = (nup_chietkhau.Value / 100) * tienhang;
            tongcong = tienhang + thue - chietkhau;
            txt_tienhang.Text = tienhang.ToString();
            txt_chietkhau.Text = chietkhau.ToString();
            txt_thue.Text = thue.ToString();
            txt_tongcong.Text = tongcong.ToString();
        }
        public void activeDGVPX()
        {
            DataGridViewRow dataGrid = dataGV_TTTK.CurrentRow;
            BPXProps BPXP = new BPXProps();
            int i = BPXControl.i;
            Dictionary<string, object>[] DataPX = BPXControl.dataBPX;
            BPXP.MaHang = dataGrid.Cells["MaHang"].Value.ToString();
            BPXP.TenHang = dataGrid.Cells["TenHang"].Value.ToString();
            BPXP.SoLuong = Convert.ToInt32(nup_soluong.Value);
            BPXP.DonGiaHT = Convert.ToInt32(dataGrid.Cells["DonGiaHT"].Value);
            BPXP.LengthGV = dataGV_TBTT.RowCount;
            if (BPXC.handleBPX(BPXP, 
                TasmaControl.exArrDGV(dataGV_TBTT, BPXP.MaHang)
            ))
                dataGV_TBTT.Rows.Add(
                    BPXControl.dataBPX[i]["MaHang_M"],
                    BPXControl.dataBPX[i]["TenHang"],
                    BPXControl.dataBPX[i]["SoLuong"],
                    BPXControl.dataBPX[i]["DonGiaHT"],
                    BPXControl.dataBPX[i]["ThanhTien"]
                );
            else if(!TasmaControl.exArrDGV(dataGV_TBTT, BPXP.MaHang))
                MessageBox.Show(String.Format("{0} đã tồn tại", BPXP.TenHang));
            else
                MessageBox.Show("Số lượng phải lớn hơn 0");
        }
        public void activeData()
        {
            dataGV_TTTK.DataSource = DOC.SelectData("HANG_HOA");
            cb_nhacc.DataSource = DOC.SelectData("NHA_CC");
            cb_nhacc.DisplayMember = "TenNCC";
            cb_nhacc.ValueMember = "MaNCC";
            cb_nhanvien.DataSource = DOC.SelectData("NHAN_VIEN");
            cb_nhanvien.DisplayMember = "TenNV";
            cb_nhanvien.ValueMember = "MaNV";
        }
        public void AutoCompleteSearch(string nameAu)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            string[] valAC = AC_C.displayAC("HANG_HOA", nameAu);
            foreach(var val in valAC)
            {
                acsc.Add(val);
            }
            txt_timkiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_timkiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_timkiem.AutoCompleteCustomSource = acsc;
        }
        public void Search()
        {
            SearchProp sp = new SearchProp();
            sp.tableName = "HANG_HOA";
            sp.idName = nameAutoHH;
            sp.idValue = txt_timkiem.Text;
            dataGV_TTTK.DataSource = SC.SearchingCtr(sp);
        }
        private void PMQLBH_Load(object sender, EventArgs e)
        {
            activeData();
            rad_ttmah.Checked = true;
            AutoCompleteSearch(nameAutoHH);
            WouldDisable();
            ReproductionIdProps RIP = new ReproductionIdProps();
            RIP.id = DOC.SelectData("CTPN").Rows[0]["SoPN"].ToString();
            RIP.idCurrent = DOC.SelectData("CTPN").Rows.Count;
            txt_tenPN.Text = RI.ReproductionO(RIP);
           // MessageBox.Show(dataGV_TBTT.Rows[0].Cells[0].OwningColumn.Name);
        }

        private void dataGV_TTTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_nhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rad_ttmah_CheckedChanged(object sender, EventArgs e)
        {
            nameAutoHH = "MAHH";
            AutoCompleteSearch(nameAutoHH);
        }

        private void rad_tttenh_CheckedChanged(object sender, EventArgs e)
        {
            nameAutoHH = "TENHH";
            AutoCompleteSearch(nameAutoHH);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            activeDGVPX();
            SumAllMoney();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            AddProduct ADPR = new AddProduct();
            ADPR.Show();
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            AddSuppiler AS = new AddSuppiler();
            AS.Show();
        }

        private void txt_tienhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_nhacc_Click(object sender, EventArgs e)
        {
            if (SuppilerProps.alert == "OKEOKE")
            {
                activeData();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            APNP.soPN = txt_tenPN.Text;
            APNP.ngayPN = dtp_ngay.Text;
            APNP.soTienPT = Convert.ToInt32(txt_tongcong.Text);
            APNP.soTienDT = Convert.ToInt32(txt_tienhang.Text);
            APNP.maNCC = cb_nhacc.SelectedValue.ToString();
            string res = "";
            SPC.addPN(APNP);
            for (int i = 0; i < dataGV_TBTT.RowCount - 1; i++)
            {
                SPP.soPN = txt_tenPN.Text;
                SPP.maHH = dataGV_TBTT.Rows[i].Cells["MaHang_M"].Value.ToString();
                SPP.soLuong = Convert.ToInt32(dataGV_TBTT.Rows[i].Cells["SoLuong_M"].Value);
                SPP.donGia = Convert.ToInt32(dataGV_TBTT.Rows[i].Cells["GiaNhap"].Value);
                res = SPC.savePN(SPP);
            }
            MessageBox.Show(res);
        }
    }
}
