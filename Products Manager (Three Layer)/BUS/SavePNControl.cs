using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class SavePNControl
    {
        public DatabaseAccess access = new DatabaseAccess();
        public string savePN(SavePNProps propsS)
        {
            Dictionary<string, object> CTPN_obj = new Dictionary<string, object>();
            CTPN_obj.Add("SoPN", String.Format("'{0}'", propsS.soPN));
            CTPN_obj.Add("MaHH", String.Format("'{0}'", propsS.maHH));
            CTPN_obj.Add("SoLuong", propsS.soLuong);
            CTPN_obj.Add("DonGia", propsS.donGia);
     
            if (access.InsertData("CTPN", CTPN_obj) == "Đã thêm thành công")
                return "Đã lưu thành công phiếu nhập " + propsS.soPN;
            else return "Lưu thất bại";
        }
        public string addPN(AddPNProps propsA)
        {
            Dictionary<string, object> PN_obj = new Dictionary<string, object>();
            PN_obj.Add("SoPN", String.Format("'{0}'", propsA.soPN));
            PN_obj.Add("NgayPN", String.Format("'{0}'", propsA.ngayPN));
            PN_obj.Add("MaNCC", String.Format("'{0}'", propsA.maNCC));
            PN_obj.Add("SoTienPhaiTra", propsA.soTienPT);
            PN_obj.Add("SoTieDaTra", propsA.soTienDT);
            if (access.InsertData("PHIEU_NHAP", PN_obj) == "Đã thêm thành công")
                return "Đã lưu thành công phiếu nhập " + propsA.soPN;
            else return "Lưu thất bại";
        }
    }
}
