using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class AddProductControl
    {
        private string nameTable = "HANG_HOA";
        public string addPD(AddProductProp props)
        {
            DatabaseAccess access = new DatabaseAccess();
            Dictionary<string, object> columns = new Dictionary<string, object>();
            columns.Add("MaHH", String.Format("'{0}'",props.maHH));
            columns.Add("TenHH", String.Format("N'{0}'",props.tenHH));
            columns.Add("DonGiaHienTai", props.soHD);
            columns.Add("SoLuong", props.soLuong);
            if (props.maHH == "")
                return "required_mahh";
            if (props.tenHH == "")
                return "required_tenhh";
            if (props.soHD == 0)
                return "required_sohd";
            if (props.soLuong == 0)
                return "required_sol";
           

            return access.InsertData(nameTable, columns) + " " + props.tenHH;
        }
        public string growID(string id, int currentID)
        {
            string newID = "";
            string partStr = id.Substring(0, id.Length - 1);
            currentID++;
            newID = partStr + currentID;  

            return newID;
        }
    }
}
