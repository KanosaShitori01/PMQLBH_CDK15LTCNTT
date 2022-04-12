using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class DataOutControl
    {
        DatabaseAccess DA = new DatabaseAccess();        
        public DataTable SelectData(string tableName)
        {
            return DA.SelectData(tableName);
        }
        public DataTable SelectData(string tableName, string id, string typeorder)
        {
            return DA.SelectDataORDER(tableName, id, typeorder);
        }
    }
}
