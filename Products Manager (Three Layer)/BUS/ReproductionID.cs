using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ReproductionID
    {
        public string ReproductionO(ReproductionIdProps props)
        {
            string newId = props.id.Substring(0, props.id.Length - 1);
            newId += props.idCurrent + 1;
            return newId;
        }
    }
}
