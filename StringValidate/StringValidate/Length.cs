using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
    public class Length: Ivalid
    {
       public bool IsValidString(String data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
