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

            UserData1 data = new UserData1();
            String _String = data._Name("excel");


            UserData2 data2 = new UserData2();
            String _null = data2._Name(null);


            UserData3 data3 = new UserData3();
            String _Empty = data3._Name("");
            


            StringValidator _validator = new StringValidator();

            bool ValidateString = _validator.IsValidString(_String);
            bool ValidateNull = _validator.IsValidString(_null);
            bool ValidateEmpty = _validator.IsValidString(_Empty);

            Console.WriteLine(ValidateString);
            Console.WriteLine(ValidateNull);
            Console.WriteLine(ValidateEmpty);
          




        }
    }
}
