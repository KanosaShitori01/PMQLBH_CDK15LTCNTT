using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlClient;
namespace ProductsManager
{
    public partial class PMQLBH : Form
    {
        public PMQLBH()
        {
            InitializeComponent();
        }
        public void activeDataSQL()
        {
            dataGV_TTTK.DataSource = cls_hanghoa.selectHH();
            cb_nhacc.DataSource = cls_nhacc.selectNCC();
            cb_nhacc.ValueMember = "MaNCC";
            cb_nhacc.DisplayMember = "TenNCC";
        }
        private void PMQLBH_Load(object sender, EventArgs e)
        {
            activeDataSQL();
        }

        private void dataGV_TTTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_nhacc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
