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
    public class SearchControl
    {
        public DataTable SearchingCtr(SearchProp prop)
        {
            DatabaseAccess access = new DatabaseAccess();
            return access.SelectData(prop.tableName, prop.idName, prop.idValue);
        }
    }
}
