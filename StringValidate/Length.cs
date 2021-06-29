using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
    class Length: IStringValidate
    {
        bool StringValidator(String data)
        {
            if (data.Length > 8)
            {
                return false;
            }
        }
    }
}
