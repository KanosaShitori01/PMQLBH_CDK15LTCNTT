using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class LoginControl
    {
        DatabaseAccess DA = new DatabaseAccess();
        public string confirmlogin(LoginProp prop)
        {
            if (prop.username == "") 
                return "required_username";
            if (prop.password == "") 
                return "required_password";

            return DA.CheckLogin(prop);
        }
    }
}
