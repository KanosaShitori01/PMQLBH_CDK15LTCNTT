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
    public partial class Login : Form
    {
        LoginControl LC = new LoginControl();
        LoginProp LP = new LoginProp();
        public Login()
        {
            InitializeComponent();
        }
        public void activeLogin()
        {
            LP.username = txt_tendangnhap.Text;
            LP.password = txt_matkhau.Text;
            string result = LC.confirmlogin(LP);
            switch (result)
            {
                case "required_username":
                    MessageBox.Show("Không được để tài khoản trống");
                    return;
                case "required_password":
                    MessageBox.Show("Không được để mật khẩu trống");
                    return;
                case "US_OR_PA-WRO":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            MessageBox.Show("Đăng Nhập Thành Công");
            PMQLBH QLBH = new PMQLBH();
            this.Hide();
            QLBH.Show();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            //var columns = new Dictionary<string, object>(){
            //    { "SoLuong", 50 },
            //    { "DonGia", 3600 }
            //};
           
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            activeLogin();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Close();
        }

        private void txt_tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)){
                txt_matkhau.Focus();
            } 
        }
    }
}
