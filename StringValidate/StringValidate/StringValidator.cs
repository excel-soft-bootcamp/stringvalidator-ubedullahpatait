using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
  public   class StringValidator
    {
        Ivalid _validate;

        public StringValidator(Ivalid validate)
        {
            this._validate = validate;
        }

        public bool IsValidString(string data)
        {

            return _validate.IsValidString(data);
        }


    }
}
