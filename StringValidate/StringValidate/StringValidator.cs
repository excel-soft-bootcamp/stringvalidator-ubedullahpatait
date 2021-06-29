using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
   public class StringValidator
    {
        public bool IsValidString(String data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            if (data.Length > 8)
            {
                return false;
            }
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }


    }
}
