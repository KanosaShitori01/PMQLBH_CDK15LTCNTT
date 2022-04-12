using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProductsManager
{
    class TasmaControl
    {
        public static bool exArrDGV(DataGridView dgv, string mh)
        {
            bool flag = true;
            if (dgv.RowCount >= 2)
            {
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    if (dgv.Rows[i].Cells["MaHang_M"].Value.ToString() == mh)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }   
    }
}
