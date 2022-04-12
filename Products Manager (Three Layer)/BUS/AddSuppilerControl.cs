using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class AddSuppilerControl 
    {
        public string AddSuppiler(SuppilerProps props)
        {
            DatabaseAccess access = new DatabaseAccess();
            Dictionary<string, object> columns = new Dictionary<string, object>();
            columns.Add("MaNCC", String.Format("'{0}'",props.maNCC));
            columns.Add("TenNCC", String.Format("'{0}'", props.tenNCC));
            columns.Add("DienThoaiNCC", String.Format("'{0}'", props.sdt));
            columns.Add("DiaChiNCC", String.Format("'{0}'", props.diachi));
            if (props.tenNCC == "") return "Không được để trống tên NCC";
            if (props.sdt == "") return "Không được để trống SĐT";
            if (props.diachi == "") return "Không được để trống địa chỉ";

            return access.InsertData("NHA_CC", columns);
        }
    }
}
