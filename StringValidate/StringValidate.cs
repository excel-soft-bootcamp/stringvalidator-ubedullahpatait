using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
    class StringValidate
    {
        IStringValidate _stringvalidate;

        public bool StringValidate(IStringValidate stringvalidate)
        {
            this._stringvalidate = stringvalidate;
        }

        public bool StringValidator(string data)
        {

            return _stringvalidate.StringValidator(data);
        }

    }
}
