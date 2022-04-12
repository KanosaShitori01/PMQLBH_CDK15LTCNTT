using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class BPXControl
    {
        public static int i = 0;
        public static Dictionary<string,object>[] dataBPX = new Dictionary<string,object>[1];
        public bool handleBPX(BPXProps props, bool Duplicheck)
        {
            bool result = true;
            dataBPX = new Dictionary<string, object>[props.LengthGV];
            if(props.SoLuong > 0 && Duplicheck)
            {
                dataBPX[i] = new Dictionary<string, object>();
                dataBPX[i].Add("MaHang_M", props.MaHang);
                dataBPX[i].Add("TenHang", props.TenHang);
                dataBPX[i].Add("SoLuong", props.SoLuong);
                dataBPX[i].Add("DonGiaHT", props.DonGiaHT);
                dataBPX[i].Add("ThanhTien", props.SoLuong * props.DonGiaHT);
                i++;
            }
            else result = false;

            return result;
        }
        public bool duplicateCheck(BPXProps props , Dictionary<string,object>[] pairs)
        {
            return false;
        }
    }
}
