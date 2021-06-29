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

            string data = "excelsoft";
            StringValidate nullorempty = new StringValidate(new IsNullOrEmpty());
            nullorempty.StringValidator(data);

            StringValidate lengthcheck = new StringValidate(new Length());
            lengthcheck.StringValidator(data);

            StringValidate startwith = new StringValidate(new StartsWith());
            startwith.StringValidator(data);



        }
    }
}
