using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
    class IsNullOrEmpty: IStringValidate
    {

        bool StringValidator(String data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
        }
    }
}
