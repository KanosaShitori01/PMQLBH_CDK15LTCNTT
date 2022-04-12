using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class AutoCompleteControl
    {
        public string[] displayAC(string tableName, string autoName)
        {
            DatabaseAccess access = new DatabaseAccess();
            int lengthAC = access.SelectData(tableName).Rows.Count;
            return access.AutoComplete(tableName, autoName, lengthAC);
        }
    }
}
