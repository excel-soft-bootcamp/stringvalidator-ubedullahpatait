using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidate
{
    class Program
    {
        static void Main(string[] args)
        {

            string data = "excel";
            StringValidator _nullorempty = new StringValidator(new IsNullOrEmpty());
            _nullorempty.IsValidString(data);

            StringValidator _length = new StringValidator(new Length());
            _length.IsValidString(data);

            StringValidator _startwith = new StringValidator(new StartsWith());
            _startwith.IsValidString(data);



        }
    }
}
